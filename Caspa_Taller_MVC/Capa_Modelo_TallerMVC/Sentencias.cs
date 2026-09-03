using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Modelo_TallerMVC
{
    internal class Sentencias
    {
        Conexion con = new Conexion();
        public OdbcDataAdapter LlenarTabla(string NombreTabla)
        {
            string sql = "SELECT * FROM " + NombreTabla + ";";
            OdbcDataAdapter daTabla = new OdbcDataAdapter(sql, con.Conectar());
            return daTabla;
        }
    }
}
