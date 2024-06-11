using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmProducto : Form
    {
        public frmProducto()
        {
            InitializeComponent();
        }

        private void backProducto_Click(object sender, EventArgs e)
        {
            Inicio nuevaVentana = new Inicio(Inicio.usuarioActual);
            nuevaVentana.Show();
            this.Hide();
        }
    

        private void frmProducto_Load(object sender, EventArgs e)
        {
            cboEstado.Items.Add(new opcionCombo() { Valor = 1, Texto = "Activo" });
            cboEstado.Items.Add(new opcionCombo() { Valor = 0, Texto = "No Activo" });
            cboEstado.DisplayMember = "Texto";
            cboEstado.ValueMember = "Valor";
            cboEstado.SelectedIndex = 0;


            List<Categoria> listacategoria = new CN_Categoria().Listar();

            foreach (Categoria item in listacategoria)
            {
                cboCategoria.Items.Add(new opcionCombo() { Valor = item.IdCategoria, Texto = item.Descripcion });
            }
            cboCategoria.DisplayMember = "Texto";
            cboCategoria.ValueMember = "Valor";
            cboCategoria.SelectedIndex = 0;


            foreach (DataGridViewColumn columna in dgvData.Columns)
            {

                if (columna.Visible == true && columna.Name != "btnseleccionar")
                {
                    cboBusqueda.Items.Add(new opcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            cboBusqueda.DisplayMember = "Texto";
            cboBusqueda.ValueMember = "Valor";
            cboBusqueda.SelectedIndex = 0;



            
            List<Producto> lista = new CN_Producto().Listar();

            foreach (Producto item in lista)
            {

                dgvData.Rows.Add(new object[] {
                    "",
                    item.IdProducto,
                    item.Codigo,
                    item.Nombre,
                    item.Descripcion,
                    item.oCategoria.IdCategoria,
                    item.oCategoria.Descripcion,
                    item.Stock,
                    item.PrecioCompra,
                    item.PrecioVenta,
                    item.Estado == true ? 1 : 0 ,
                    item.Estado == true ? "Activo" : "No Activo"
                });
            }

        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {

            string mensaje = string.Empty;

            Producto obj = new Producto()
            {
                IdProducto = Convert.ToInt32(txtId.Text),
                Codigo = txtCodigo.Text,
                Nombre = txtNombre.Text,
                Descripcion = txtDescripcion.Text,
                oCategoria = new Categoria() { IdCategoria = Convert.ToInt32(((opcionCombo)cboCategoria.SelectedItem).Valor) },
                Estado = Convert.ToInt32(((opcionCombo)cboEstado.SelectedItem).Valor) == 1 ? true : false
            };

            if (obj.IdProducto == 0)
            {
                int idgenerado = new CN_Producto().Registrar(obj, out mensaje);

                if (idgenerado != 0)
                {

                    dgvData.Rows.Add(new object[] {
                        "",
                       idgenerado,
                       txtCodigo.Text,
                        txtNombre.Text,
                        txtDescripcion.Text,
                        ((opcionCombo)cboCategoria.SelectedItem).Valor.ToString(),
                       ((opcionCombo)cboCategoria.SelectedItem).Texto.ToString(),
                        "0",
                        "0.00",
                        "0.00",
                       ((opcionCombo)cboEstado.SelectedItem).Valor.ToString(),
                       ((opcionCombo)cboEstado.SelectedItem).Texto.ToString()
                    });

                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }


            }
            else
            {
                bool resultado = new CN_Producto().Editar(obj, out mensaje);

                if (resultado)
                {
                    DataGridViewRow row = dgvData.Rows[Convert.ToInt32(txtIndice.Text)];
                    row.Cells["Id"].Value = txtId.Text;
                    row.Cells["Codigo"].Value = txtCodigo.Text;
                    row.Cells["Nombre"].Value = txtNombre.Text;
                    row.Cells["Descripcion"].Value = txtDescripcion.Text;
                    row.Cells["IdCategoria"].Value = ((opcionCombo)cboCategoria.SelectedItem).Valor.ToString();
                    row.Cells["Categoria"].Value = ((opcionCombo)cboCategoria.SelectedItem).Texto.ToString();
                    row.Cells["EstadoValor"].Value = ((opcionCombo)cboEstado.SelectedItem).Valor.ToString();
                    row.Cells["Estado"].Value = ((opcionCombo)cboEstado.SelectedItem).Texto.ToString();

                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }


        }



        private void Limpiar()
        {

            txtIndice.Text = "-1";
            txtId.Text = "0";
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            cboCategoria.SelectedIndex = 0;
            cboEstado.SelectedIndex = 0;

            txtCodigo.Select();

        }

        private void dgvData_CellPainting_1(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 0)
            {

                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.check20.Width;
                var h = Properties.Resources.check20.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.check20, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void dgvData_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvData.Columns[e.ColumnIndex].Name == "btnseleccionar")
            {

                int indice = e.RowIndex;

                if (indice >= 0)
                {

                    txtIndice.Text = indice.ToString();
                    txtId.Text = dgvData.Rows[indice].Cells["Id"].Value.ToString();

                    txtCodigo.Text = dgvData.Rows[indice].Cells["Codigo"].Value.ToString();
                    txtNombre.Text = dgvData.Rows[indice].Cells["Nombre"].Value.ToString();
                    txtDescripcion.Text = dgvData.Rows[indice].Cells["Descripcion"].Value.ToString();


                    foreach (opcionCombo oc in cboCategoria.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvData.Rows[indice].Cells["IdCategoria"].Value))
                        {
                            int indice_combo = cboCategoria.Items.IndexOf(oc);
                            cboCategoria.SelectedIndex = indice_combo;
                            break;
                        }
                    }


                    foreach (opcionCombo oc in cboEstado.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvData.Rows[indice].Cells["EstadoValor"].Value))
                        {
                            int indice_combo = cboEstado.Items.IndexOf(oc);
                            cboEstado.SelectedIndex = indice_combo;
                            break;
                        }
                    }


                }


            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtId.Text) != 0)
            {
                if (MessageBox.Show("¿Desea eliminar el producto", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    string mensaje = string.Empty;
                    Producto obj = new Producto()
                    {
                        IdProducto = Convert.ToInt32(txtId.Text)
                    };

                    bool respuesta = new CN_Producto().Eliminar(obj, out mensaje);

                    if (respuesta)
                    {
                        dgvData.Rows.RemoveAt(Convert.ToInt32(txtIndice.Text));
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
            }
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            string columnaFiltro = ((opcionCombo)cboBusqueda.SelectedItem).Valor.ToString();

            if (dgvData.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvData.Rows)
                {

                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtBuscar.Text.Trim().ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }

        private void btnLimpiarbuscador_Click_1(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            foreach (DataGridViewRow row in dgvData.Rows)
            {
                row.Visible = true;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        
          

        
    }
}
