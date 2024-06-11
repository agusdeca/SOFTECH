using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Negocio
    {
        public Negocio ObtenerDatos()
        {

            Negocio obj = new Negocio();

            try
            {

                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();

                    string query = "select IdNegocio, Nombre, Direccion, CUIT from NEGOCIO where IdNegocio = 1";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.CommandType = CommandType.Text;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            obj = new Negocio()
                            {
                                IdNegocio = int.Parse(dr["IdNegocio"].ToString()),
                                Nombre = dr["Nombre"].ToString(),
                                Direccion = dr["Direccion"].ToString(),
                                CUIT = dr["CUIT"].ToString(),
                            };
                        }
                    }

                }


            }
            catch
            {
                obj = new Negocio();
            }



            return obj;
        }

        public bool GuardarDatos(Negocio objeto, out string mensaje)
        {

            mensaje = string.Empty;
            bool respuesta = true;

            try
            {

                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();


                    StringBuilder query = new StringBuilder();
                    query.AppendLine("update NEGOCIO set Nombre = @Nombre,");
                    query.AppendLine("Direccion = @Direccion,");
                    query.AppendLine("CUIT = @CUIT");
                    query.AppendLine("where IdNegocio = 1;");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@Nombre", objeto.Nombre);
                    cmd.Parameters.AddWithValue("@Direccion", objeto.Direccion);
                    cmd.Parameters.AddWithValue("@CUIT", objeto.CUIT);
                    cmd.CommandType = CommandType.Text;

                    if (cmd.ExecuteNonQuery() < 1)
                    {
                        mensaje = "No se pudo guardar los datos";
                        respuesta = false;
                    }

                }
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
                respuesta = false;
            }

            return respuesta;

        }

    }
}
