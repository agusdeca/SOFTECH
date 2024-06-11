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


namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            List<Usuario> TEST = new CN_Usuario().Listar();

            Usuario ousuario= new CN_Usuario().Listar().Where(u=> u.Documento == txtusuario.Text && u.Clave == txtclave.Text).FirstOrDefault();

            if (ousuario != null)
            {
                Inicio form = new Inicio(ousuario);

                form.Show();
                this.Hide();


            }
            else
            {
                MessageBox.Show("Usuario no encontrado","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
