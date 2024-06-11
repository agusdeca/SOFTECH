using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using ClosedXML.Excel;
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
    public partial class frmGanancias : Form
    {
        public frmGanancias()
        {
            InitializeComponent();
        }

        private void backGanancias_Click(object sender, EventArgs e)
        {
            Inicio nuevaVentana = new Inicio(Inicio.usuarioActual);
            nuevaVentana.Show();
            this.Hide();
        }

        private void frmGanancias_Load(object sender, EventArgs e)
        {
            
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            List<ReporteVenta> lista = new List<ReporteVenta>();

            string fechaInicio = txtFechaInicio.Value.ToString("MM/dd/yyyy"); // Formatear la fecha de inicio como 'MM/dd/yyyy'
            string fechaFin = txtfechafin.Value.ToString("MM/dd/yyyy"); // Formatear la fecha de fin como 'MM/dd/yyyy'

            DateTime fechaInicioParsed = DateTime.ParseExact(fechaInicio, "MM/dd/yyyy", null); // Parsear la fecha de inicio
            DateTime fechaFinParsed = DateTime.ParseExact(fechaFin, "MM/dd/yyyy", null); // Parsear la fecha de fin

            lista = new CN_Reporte().Venta(fechaInicioParsed.ToString("dd/MM/yyyy"), fechaFinParsed.ToString("dd/MM/yyyy"));

            dgvData.Rows.Clear();

            foreach (ReporteVenta rv in lista)
            {
                dgvData.Rows.Add(new object[] {
            rv.FechaRegistro,
            rv.TipoDocumento,
            rv.NumeroDocumento,
            rv.MontoTotal,
            rv.UsuarioRegistro,
            rv.DocumentoCliente,
            rv.NombreCliente,
            rv.CodigoProducto,
            rv.NombreProducto,
            rv.Categoria,
            rv.PrecioVenta,
            rv.Cantidad,
            rv.SubTotal

             });
            }
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
