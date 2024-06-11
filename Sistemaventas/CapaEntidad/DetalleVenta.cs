using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class DetalleVenta
    {
        public int IdDetalleventa { get; set; }
        public Producto oProducto { get; set; }
        public decimal Cantidad { get; set; }
        public decimal SubtotaL { get; set; }
        public string FechaRegistro { get; set; }
    }
}
