using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Modelo_TallerMVC
{
    public class Conexion
    {
        public OdbcConnection Conectar()
        {
            OdbcConnection con = new OdbcConnection("Dsn=Taquilla_Cine");
            try
            {
                con.Open();
            }
            catch (OdbcException)
            {
                Console.WriteLine("No se pudo conectar a la base de datos");
            }
            return con;
        }
        public void Desconectar(OdbcConnection con)
        {
            try
            {
                con.Close();
            }
            catch (OdbcException)
            {
                Console.WriteLine("No se pudo desconectar de la base de datos");
            }
        }
    }
}
