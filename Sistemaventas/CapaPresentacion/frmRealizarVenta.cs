using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Modales;
using CapaPresentacion.Utilidades;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using iTextSharpTextRectangle = iTextSharp.text.Rectangle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmRealizarVenta : Form
    {
        private Usuario _Usuario;
        public frmRealizarVenta(Usuario oUsuario=null)
        {
            _Usuario = oUsuario;
            InitializeComponent();
        }

        private void backRventa_Click(object sender, EventArgs e)
        {
            Inicio nuevaVentana = new Inicio(Inicio.usuarioActual);
            nuevaVentana.Show();
            this.Hide();
        }

        private void frmRealizarVenta_Load(object sender, EventArgs e)
        {
            cboTipodocumento.Items.Add(new opcionCombo() { Valor = "Boleta", Texto = "Boleta" });
            cboTipodocumento.Items.Add(new opcionCombo() { Valor = "Factura", Texto = "Factura" });
            cboTipodocumento.DisplayMember = "Texto";
            cboTipodocumento.ValueMember = "Valor";
            cboTipodocumento.SelectedIndex = 0;

            txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtIdproducto.Text = "0";
            txtPagacon.Text = "";
            txtCambio.Text = "";
            txtTotalPagar.Text = "0";
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            using (var modal = new mdCliente())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtDNI.Text = modal._Cliente.Documento;
                    txtNombreCliente.Text = modal._Cliente.Nombre;
                    txtApellidoCliente.Text = modal._Cliente.Apellido;
                    txtCodigo.Select();
                }
                else
                {
                    txtDNI.Select();
                }

            }
        }

        private void btnBuscarProducto_Click_1(object sender, EventArgs e)
        {
            using (var modal = new mdProducto())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtIdproducto.Text = modal._Producto.IdProducto.ToString();
                    txtCodigo.Text = modal._Producto.Codigo;
                    txtProducto.Text = modal._Producto.Nombre;
                    txtPrecio.Text = modal._Producto.PrecioVenta.ToString("0.00");
                    txtStock.Text = modal._Producto.Stock.ToString();
                    txtCantidad.Select();
                }
                else
                {
                    txtCodigo.Select();
                }

            }
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {

                Producto oProducto = new CN_Producto().Listar().Where(p => p.Codigo == txtCodigo.Text && p.Estado == true).FirstOrDefault();

                if (oProducto != null)
                {
                    
                    txtIdproducto.Text = oProducto.IdProducto.ToString();
                    txtProducto.Text = oProducto.Nombre;
                    txtPrecio.Text = oProducto.PrecioVenta.ToString("0.00");
                    txtStock.Text = oProducto.Stock.ToString();
                    txtCantidad.Select();
                }
                else
                {
                    txtCodigo.BackColor = Color.MistyRose;
                    txtIdproducto.Text = "0";
                    txtProducto.Text = "";
                    txtPrecio.Text = "";
                    txtStock.Text = "";
                    txtCantidad.Value = 1;
                }
            }
        }

        static void MostrarMensajeDeEspera(string mensaje,string partearriba)
        {
            Thread t = new Thread(() =>
            {
                MessageBox.Show(mensaje, partearriba, MessageBoxButtons.OK, MessageBoxIcon.Information);
            });

            t.Start();
            Thread.Sleep(5000);
            if (t.IsAlive)
                t.Abort();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            decimal precio = 0;
            bool producto_existe = false;

            if (int.Parse(txtIdproducto.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!decimal.TryParse(txtPrecio.Text, out precio))
            {
                MessageBox.Show("Precio - Formato moneda incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPrecio.Select();
                return;
            }

            if (Convert.ToInt32(txtStock.Text) < Convert.ToInt32(txtCantidad.Value.ToString()))
            {
                MessageBox.Show("La cantidad no puede ser mayor al stock", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

                bool respuesta = new CN_Venta().RestarStock(
                    Convert.ToInt32(txtIdproducto.Text),
                    Convert.ToInt32(txtCantidad.Value.ToString())
                    );

                if (respuesta)
                {
                    dgvData.Rows.Add(new object[] {
                        txtIdproducto.Text,
                        txtProducto.Text,
                        precio.ToString("0.00"),
                        txtCantidad.Value.ToString(),
                        (txtCantidad.Value * precio).ToString("0.00")
                    });

                    calcularTotal();
                    limpiarProducto();
                    txtCodigo.Select();
                }
            }



        }

        private void calcularTotal()
        {
            decimal total = 0;
            if (dgvData.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvData.Rows)
                    total += Convert.ToDecimal(row.Cells["SubTotal"].Value.ToString());
            }
            txtTotalPagar.Text = total.ToString("0.00");
        }

        private void limpiarProducto()
        {
            txtIdproducto.Text = "0";
            txtCodigo.Text = "";
            txtProducto.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
            txtCantidad.Value = 1;
        }

        private void dgvData_CellPainting_1(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 5)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.delete25.Width;
                var h = Properties.Resources.delete25.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.delete25, new System.Drawing.Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void dgvData_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvData.Columns[e.ColumnIndex].Name == "btneliminar")
            {
                int index = e.RowIndex;
                if (index >= 0)
                {
                    bool respuesta = new CN_Venta().SumarStock(
                        Convert.ToInt32(dgvData.Rows[index].Cells["IdProducto"].Value.ToString()),
                        Convert.ToInt32(dgvData.Rows[index].Cells["Cantidad"].Value.ToString()));

                    if (respuesta)
                    {
                        dgvData.Rows.RemoveAt(index);
                        calcularTotal();
                    }

                }
            }
        }

        private void txtPrecio_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txtPrecio.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
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

        private void txtPagacon_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txtPagacon.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
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

        private void calcularcambio()
        {

            if (txtTotalPagar.Text.Trim() == "")
            {
                MessageBox.Show("No existen productos en la venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            decimal pagacon;
            decimal total = Convert.ToDecimal(txtTotalPagar.Text);

            if (txtPagacon.Text.Trim() == "")
            {
                txtPagacon.Text = "0";
            }

            if (decimal.TryParse(txtPagacon.Text.Trim(), out pagacon))
            {

                if (pagacon < total)
                {
                    txtCambio.Text = "0.00";
                }
                else
                {
                    decimal cambio = pagacon - total;
                    txtCambio.Text = cambio.ToString("0.00");

                }
            }



        }

        private void txtPagacon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                calcularcambio();
            }
        }

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {

            if (txtDNI.Text == "")
            {
                MessageBox.Show("Debe ingresar documento del cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            if (txtNombreCliente.Text == "")
            {
                MessageBox.Show("Debe ingresar nombre del cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (dgvData.Rows.Count < 1)
            {
                MessageBox.Show("Debe ingresar productos en la venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }



            DataTable detalle_venta = new DataTable();

            detalle_venta.Columns.Add("IdProducto", typeof(int));
            detalle_venta.Columns.Add("PrecioVenta", typeof(decimal));
            detalle_venta.Columns.Add("Cantidad", typeof(int));
            detalle_venta.Columns.Add("SubTotal", typeof(decimal));


            foreach (DataGridViewRow row in dgvData.Rows)
            {
                detalle_venta.Rows.Add(new object[] {
                    row.Cells["IdProducto"].Value.ToString(),
                    row.Cells["Precio"].Value.ToString(),
                    row.Cells["Cantidad"].Value.ToString(),
                    row.Cells["SubTotal"].Value.ToString()
                });
            }


            int idcorrelativo = new CN_Venta().ObtenerCorrelativo();
            string numeroDocumento = string.Format("{0:00000}", idcorrelativo);
            calcularcambio();

            Venta oVenta = new Venta()
            {

                oUsuario = new Usuario() { IdUsuario = _Usuario.IdUsuario },
                TipoDocumento = ((opcionCombo)cboTipodocumento.SelectedItem).Texto,
                NumeroDocumento = numeroDocumento,
                DocumnentoCliente = txtDNI.Text,
                NombreCliente = txtNombreCliente.Text,
                MontoPago = Convert.ToDecimal(txtPagacon.Text),
                MontoCambio = Convert.ToDecimal(txtCambio.Text),
                MontoTotal = Convert.ToDecimal(txtTotalPagar.Text)
            };
            Random random = new Random();
            int CAE = random.Next(0, 99999999);

            DateTime fechaActual = DateTime.Now;
            DateTime fechaVencimientoCae = fechaActual.AddDays(3);

            string Texto_Html = Properties.Resources.Venta.ToString();
            Negocio odatos = new CN_Negocio().ObtenerDatos();

            Texto_Html = Texto_Html.Replace("@nombrenegocio", odatos.Nombre.ToUpper());
            Texto_Html = Texto_Html.Replace("@CUITNegocio", odatos.CUIT);
            Texto_Html = Texto_Html.Replace("@direcnegocio", odatos.Direccion);

            Texto_Html = Texto_Html.Replace("@numerodocumento", numeroDocumento);


            Texto_Html = Texto_Html.Replace("@doccliente", txtDNI.Text);
            Texto_Html = Texto_Html.Replace("@nombrecliente", txtNombreCliente.Text);

            string filas = string.Empty;
            foreach (DataGridViewRow row in dgvData.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["Producto"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Precio"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Cantidad"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["SubTotal"].Value.ToString() + "</td>";
                filas += "</tr>";
            }
            Texto_Html = Texto_Html.Replace("@filas", filas);
            Texto_Html = Texto_Html.Replace("@montototal", txtTotalPagar.Text);
            Texto_Html = Texto_Html.Replace("@CAE", CAE.ToString());
            Texto_Html = Texto_Html.Replace("@vencimientocae", fechaVencimientoCae.ToString());


            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("Venta_{0}.pdf", numeroDocumento);
            savefile.Filter = "Pdf Files|*.pdf";

            string mensaje = string.Empty;
            bool respuesta = new CN_Venta().Registrar(oVenta, detalle_venta, out mensaje);

            MostrarMensajeDeEspera("Conectando con la afip...","Espere");

            Thread.Sleep(3000);

            MostrarMensajeDeEspera("CAE obtenido exitosamente!", "Alert");

            Console.WriteLine("CAE obtenido exitosamente");

            if (respuesta)
            {
                var result = MessageBox.Show("Numero de venta generada:\n" + numeroDocumento + "\n\n¿Desea copiar al portapapeles?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                    Clipboard.SetText(numeroDocumento);

                txtDNI.Text = "";
                txtNombreCliente.Text = "";
                dgvData.Rows.Clear();
                calcularTotal();
                txtPagacon.Text = "";
                txtCambio.Text = "";
            }
            else
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            if (cboTipodocumento.Text == "")
            {
                MessageBox.Show("No se encontraron resultados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                {

                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    using (StringReader sr = new StringReader(Texto_Html))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                    stream.Close();
                    MessageBox.Show("Documento Generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

       
    }

}
