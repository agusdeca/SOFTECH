using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Negocio
    {
        private CD_Negocio objcd_negocio = new CD_Negocio();


        public Negocio ObtenerDatos()
        {
            return objcd_negocio.ObtenerDatos();
        }

        public bool GuardarDatos(Negocio obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Nombre == "")
            {
                Mensaje += "Es necesario el nombre\n";
            }

            if (obj.Direccion == "")
            {
                Mensaje += "Es necesario la direccion\n";
            }

            if (obj.CUIT == "")
            {
                Mensaje += "Es necesario el numero de CUIT\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_negocio.GuardarDatos(obj, out Mensaje);
            }


        }

    }
}
