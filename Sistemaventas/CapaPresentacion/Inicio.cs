using CapaEntidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaEntidad;
using CapaNegocio;
using FontAwesome.Sharp;

namespace CapaPresentacion
{
    public partial class Inicio : Form
    {
        public static Usuario usuarioActual;


        public Inicio(Usuario objusuario)
        {
            usuarioActual = objusuario;
            InitializeComponent();
        }


        private void Inicio_Load(object sender, EventArgs e)
        {
            List<Permiso> ListaPermisos = new CN_Permiso().Listar(usuarioActual.IdUsuario);

            foreach (IconMenuItem iconmenu in menubotones1.Items) 
            {
                bool encontrado = ListaPermisos.Any(m => m.NombreMenu == iconmenu.Name);
                if (encontrado == false)
                {
                    iconmenu.Visible = false;   
                }
            }
            foreach (IconMenuItem iconmenu2 in menubotones2.Items)
            {
                bool encontrado = ListaPermisos.Any(m => m.NombreMenu == iconmenu2.Name);
                if (encontrado == false)
                {
                    iconmenu2.Visible = false;
                }
               }
            

            lblusuario.Text = usuarioActual.Nombre;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            frmUsuarios nuevaVentana = new frmUsuarios();
            nuevaVentana.Show();
            this.Hide();
        }

        private void btnVenta_Click_1(object sender, EventArgs e)
        {
            frmRealizarVenta nuevaVentana = new frmRealizarVenta(usuarioActual);
            nuevaVentana.Show();
            this.Hide();
        }

        private void btnStock_Click_1(object sender, EventArgs e)
        {
            frmStock nuevaVentana = new frmStock();
            nuevaVentana.Show();
            this.Hide();
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            frmIngresoProductos nuevaVentana = new frmIngresoProductos(usuarioActual);
            nuevaVentana.Show();
            this.Hide();
        }

        private void btnGanancias_Click(object sender, EventArgs e)
        {
            frmGanancias nuevaVentana = new frmGanancias();
            nuevaVentana.Show();
            this.Hide();
        }

        private void btnCategoria_Click_1(object sender, EventArgs e)
        {
            frmCategoria nuevaVentana = new frmCategoria();
            nuevaVentana.Show();
            this.Hide();
        }

        private void btnProducto_Click_1(object sender, EventArgs e)
        {
            frmProducto nuevaVentana = new frmProducto();
            nuevaVentana.Show();
            this.Hide();
        }

        private void btnClientes_Click_1(object sender, EventArgs e)
        {
            frmCliente nuevaVentana = new frmCliente();
            nuevaVentana.Show();
            this.Hide();
        }

        private void btnNegocio_Click_1(object sender, EventArgs e)
        {
            frmNegocio nuevaVentana = new frmNegocio();
            nuevaVentana.Show();
            this.Hide();
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void backGanancias_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
