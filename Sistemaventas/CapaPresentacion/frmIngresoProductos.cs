using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Modales;
using CapaPresentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmIngresoProductos : Form
    {
        private Usuario _Usuario;
        public frmIngresoProductos(Usuario oUsuario=null)
        {
            _Usuario = oUsuario;
            InitializeComponent();
        }

        private void backIngresoProducto_Click(object sender, EventArgs e)
        {
            Inicio nuevaVentana = new Inicio(Inicio.usuarioActual);
            nuevaVentana.Show();
            this.Hide();
        }

        private void frmIngresoProductos_Load(object sender, EventArgs e)
        {
            cboTipodocumento.Items.Add(new opcionCombo() { Valor = "Boleta",Texto="Boleta" });
            cboTipodocumento.Items.Add(new opcionCombo() { Valor = "Factura", Texto = "Factura" });
            cboTipodocumento.DisplayMember = "Texto";
            cboTipodocumento.ValueMember = "Valor";
            cboTipodocumento.SelectedIndex= 0;  

            txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");

            txtCodigo.Text = "0";
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            using(var modal=new mdProducto())
            {
                var result=modal.ShowDialog();

                if (result == DialogResult.OK) {
                    txtIdproducto.Text = modal._Producto.IdProducto.ToString();
                    txtCodigo.Text = modal._Producto.Codigo;
                    txtProducto.Text = modal._Producto.Nombre;
                    txtCompra.Select();
                    
                }
                else
                {
                    txtCodigo.Select();
                }
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter) { 
                Producto oProducto=new CN_Producto().Listar().Where(p=> p.Codigo==txtCodigo.Text && p.Estado== true).FirstOrDefault(); 
                if (oProducto!=null)
                {
                    
                    txtIdproducto.Text=oProducto.IdProducto.ToString();
                    txtProducto.Text=oProducto.Nombre;
                    txtCompra.Select();
                }
                else
                {
                    txtCodigo.BackColor = Color.MistyRose;
                    txtIdproducto.Text = "0";
                    txtProducto.Text ="";
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            decimal precioCompra = 0;
            decimal precioVenta = 0;
            bool producto_existe = false;

            if (int.Parse(txtIdproducto.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un producto","Mensaje",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if(!decimal.TryParse(txtVenta.Text, out precioVenta)) {
                MessageBox.Show("Precio de venta------Formato ingresado erroneamente","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                txtVenta.Select();
                return;
            }
            if (!decimal.TryParse(txtCompra.Text, out precioCompra))
            {
                MessageBox.Show("Precio de compra------Formato ingresado erroneamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCompra.Select();
                return;
            }

            foreach (DataGridViewRow fila in dgvData.Rows)
            {
                if (fila.Cells["IdProducto"].Value.ToString() == txtIdproducto.Text)
                {
                    producto_existe = true;
                    break;
                }
            }
            if (!producto_existe)
            {

                dgvData.Rows.Add(new object[] {
                    txtIdproducto.Text,
                    txtProducto.Text,
                    precioCompra.ToString("0.00"),
                    precioVenta.ToString("0.00"),
                    txtCantidad.Value.ToString(),
                    (txtCantidad.Value * precioCompra).ToString("0.00")

                });

                calcularTotal();
                limpiarProducto();
                txtCodigo.Select();

            }

            
        }
        private void limpiarProducto()
        {
            txtIdproducto.Text = "0";
            txtCodigo.Text = "";
            txtCodigo.BackColor = Color.White;
            txtProducto.Text = "";
            txtCompra.Text = "";
            txtVenta.Text = "";
            txtCantidad.Value = 1;
        }

        private void calcularTotal()
        {
            decimal total = 0;
            if (dgvData.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvData.Rows)
                    total += Convert.ToDecimal(row.Cells["Subtotal"].Value.ToString());
            }
            txtTotalPagar.Text = total.ToString("0.00");
        }

        private void dgvData_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 6)
            {

                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.delete25.Width;
                var h = Properties.Resources.delete25.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.delete25, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvData.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    dgvData.Rows.RemoveAt(indice);
                    calcularTotal();
                }
            }
        }

        private void txtCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txtCompra.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
                {
                    e.Handled = true;
                }
                else
                {
                    if (Char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void txtVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txtVenta.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
                {
                    e.Handled = true;
                }
                else
                {
                    if (Char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void btnRegistrarCompra_Click(object sender, EventArgs e)
        {
            if (txtNombreProveedor.Text == "")
            {
                MessageBox.Show("Debe seleccionar un proveedor","Mensaje",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (dgvData.Rows.Count < 1)
            {
                MessageBox.Show("Debe ingresar productos en la compra", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DataTable detalle_compra = new DataTable();

            detalle_compra.Columns.Add("IdProducto", typeof(int));
            detalle_compra.Columns.Add("PrecioCompra", typeof(decimal));
            detalle_compra.Columns.Add("PrecioVenta", typeof(decimal));
            detalle_compra.Columns.Add("Cantidad", typeof(int));
            detalle_compra.Columns.Add("MontoTotal", typeof(decimal));

            foreach (DataGridViewRow row in dgvData.Rows)
            {
                detalle_compra.Rows.Add(
                    new object[] {
                       Convert.ToInt32(row.Cells["IdProducto"].Value.ToString()),
                       row.Cells["PrecioCompra"].Value.ToString(),
                       row.Cells["PrecioVenta"].Value.ToString(),
                       row.Cells["Cantidad"].Value.ToString(),
                       row.Cells["SubTotal"].Value.ToString()
                    });

            }

            int idcorrelativo = new CN_Compra().ObtenerCorrelativo();
            string numerodocumento = string.Format("{0:00000}", idcorrelativo);

            Compra oCompra = new Compra()
            {
                oUsuario = new Usuario() { IdUsuario = _Usuario.IdUsuario },
                Proveedor = txtNombreProveedor.Text,
                TipoDocumento = ((opcionCombo)cboTipodocumento.SelectedItem).Texto,
                NumeroDocumento = numerodocumento,
                MontoTotal = Convert.ToDecimal(txtTotalPagar.Text)
            };

            string mensaje = string.Empty;
            bool respuesta = new CN_Compra().Registrar(oCompra, detalle_compra, out mensaje);

            if (respuesta)
            {
                var result = MessageBox.Show("Numero de compra generada:\n" + numerodocumento + "\n\n¿Desea copiar al portapapeles?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                    Clipboard.SetText(numerodocumento);
                txtNombreProveedor.Text = "";
                dgvData.Rows.Clear();
                calcularTotal();

            }
            else
            {
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }
    }
}

