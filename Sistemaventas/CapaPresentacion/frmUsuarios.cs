using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidad;
using CapaPresentacion.Utilidades;

namespace CapaPresentacion
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            cboEstado.Items.Add(new opcionCombo() { Valor=1, Texto="Activo"});
            cboEstado.Items.Add(new opcionCombo() { Valor = 2, Texto = "No activo" });
            cboEstado.DisplayMember = "Texto";
            cboEstado.ValueMember = "Valor";
            cboEstado.SelectedIndex = 0;

            List<Rol> listaRol = new CN_Rol().Listar();
            foreach (Rol item in listaRol)
            {
                cboRol.Items.Add(new opcionCombo() { Valor = item.IdRol, Texto = item.Descripcion });
            }
            cboRol.DisplayMember = "Texto";
            cboRol.ValueMember = "Valor";
            cboRol.SelectedIndex = 0;

            foreach(DataGridViewColumn columna in dgvData.Columns)
            {
                if (columna.Visible == true && columna.Name!= "btnseleccionar")
                {
                    cboBusqueda.Items.Add(new opcionCombo() {Valor=columna.Name,Texto=columna.HeaderText});
                }
                //cboBusqueda.DisplayMember = "Texto";
                //cboBusqueda.ValueMember = "Valor";
                //cboBusqueda.SelectedIndex = 0;
            }

            //Mostrar usuarios
            List<Usuario> listaUsuario = new CN_Usuario().Listar();
            foreach (Usuario item in listaUsuario)
            {
                dgvData.Rows.Add(new object[] { "", item.IdUsuario, item.Documento, item.Nombre, item.Apellido, item.Correo, item.Clave, 
                    item.oROL.IdRol, 
                    item.oROL.Descripcion, 
                    item.Estado==true ? 1 :0, 
                    item.Estado==true ? "Activo" :"No activo"
                });


            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje=string.Empty;

            Usuario objusuario = new Usuario()
            {
                IdUsuario=Convert.ToInt32(txtId.Text),
                Documento=txtDocumento.Text,
                Nombre=txtNombre.Text,
                Apellido=txtApellido.Text,
                Correo=txtCorreo.Text,
                Clave=txtContra.Text,
                oROL=new Rol() { IdRol=Convert.ToInt32(((opcionCombo)cboRol.SelectedItem).Valor)},
                Estado= Convert.ToInt32(((opcionCombo)cboEstado.SelectedItem).Valor)==1? true : false,
            };

            if (objusuario.IdUsuario == 0)
            {
                int idusuariogenerado = new CN_Usuario().Registrar(objusuario, out mensaje);

                if (idusuariogenerado != 0)
                {
                    dgvData.Rows.Add(new object[] { "", idusuariogenerado, txtDocumento.Text, txtNombre.Text, txtApellido.Text, txtCorreo.Text, txtContra.Text, 
                        ((opcionCombo)cboRol.SelectedItem).Valor.ToString(), 
                        ((opcionCombo)cboRol.SelectedItem).Texto.ToString(), 
                        ((opcionCombo)cboEstado.SelectedItem).Valor.ToString(), 
                        ((opcionCombo)cboEstado.SelectedItem).Texto.ToString() });
                    limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
            else
            {
                bool resultado= new CN_Usuario().Editar(objusuario, out mensaje);
                if (resultado)
                {
                    DataGridViewRow row = dgvData.Rows[Convert.ToInt32(txtIndice.Text)];
                    row.Cells["Id"].Value=txtId.Text;
                    row.Cells["DNI"].Value=txtDocumento.Text;
                    row.Cells["Nombre"].Value = txtNombre.Text;
                    row.Cells["Apellido"].Value = txtApellido.Text;
                    row.Cells["Correo"].Value = txtCorreo.Text;
                    row.Cells["Contrasenia"].Value = txtContra.Text;
                    row.Cells["IdRol"].Value = ((opcionCombo)cboRol.SelectedItem).Valor.ToString();
                    row.Cells["Rol"].Value = ((opcionCombo)cboRol.SelectedItem).Texto.ToString();
                    row.Cells["EstadoValor"].Value = ((opcionCombo)cboEstado.SelectedItem).Valor.ToString();
                    row.Cells["Estado"].Value = ((opcionCombo)cboEstado.SelectedItem).Texto.ToString();
                    limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
            
            
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        void limpiar()
        {
            txtIndice.Text = "-1";
            txtId.Text = "0";
            txtDocumento.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtCorreo.Text = "";
            txtContra.Text = "";
            txtConfirmarContra.Text = "";
            cboRol.SelectedIndex = 0;
            cboEstado.SelectedIndex = 0;

            txtDocumento.Select();
        }

        private void backUsuario_Click_1(object sender, EventArgs e)
        {
            Inicio nuevaVentana = new Inicio(Inicio.usuarioActual);
            nuevaVentana.Show();
            this.Hide();
        }

        private void dgvData_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if(e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = Properties.Resources.check20.Width;
                var h= Properties.Resources.check20.Height;
                var x= e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;
                e.Graphics.DrawImage(Properties.Resources.check20, new Rectangle(x,y,w,h));
                e.Handled = true;

            }
            
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvData.Columns[e.ColumnIndex].Name == "btnseleccionar")
            {
                int indice = e.RowIndex;
                if(indice >= 0)
                {
                    txtIndice.Text = indice.ToString();
                    txtId.Text = dgvData.Rows[indice].Cells["Id"].Value.ToString();
                    txtDocumento.Text = dgvData.Rows[indice].Cells["DNI"].Value.ToString();
                    txtNombre.Text = dgvData.Rows[indice].Cells["Nombre"].Value.ToString();
                    txtApellido.Text = dgvData.Rows[indice].Cells["Apellido"].Value.ToString();
                    txtCorreo.Text = dgvData.Rows[indice].Cells["Correo"].Value.ToString();
                    txtContra.Text = dgvData.Rows[indice].Cells["Contrasenia"].Value.ToString();
                    txtConfirmarContra.Text= dgvData.Rows[indice].Cells["Contrasenia"].Value.ToString();

                    foreach (opcionCombo oc in cboRol.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvData.Rows[indice].Cells["IdRol"].Value)){
                            int indice_combo=cboRol.Items.IndexOf(oc);
                            cboRol.SelectedIndex = indice_combo;
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
                if(MessageBox.Show("Desea eliminar el usuario?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = String.Empty;
                    Usuario objusuario = new Usuario()
                    {
                        IdUsuario = Convert.ToInt32(txtId.Text)
                    };
                    bool respuesta = new CN_Usuario().Eliminar(objusuario, out mensaje);
                    if (respuesta)
                    {
                         dgvData.Rows.RemoveAt(Convert.ToInt32(txtIndice.Text));

                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro= ((opcionCombo)cboBusqueda.SelectedItem).Valor.ToString();
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

        private void btnLimpiarbuscador_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            foreach (DataGridViewRow row in dgvData.Rows)
            {
                row.Visible = true;
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtDocumento_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtIndice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}