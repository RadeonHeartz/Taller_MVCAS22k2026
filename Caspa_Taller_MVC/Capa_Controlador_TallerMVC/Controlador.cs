using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Modelo_TallerMVC;

namespace Capa_Controlador_TallerMVC
{
    public class Controlador
    {
        Sentencias sentencias = new Sentencias();
        public DataTable llenardgv(string NombreTabla)
        {
            OdbcDataAdapter daControlador = sentencias.LlenarTabla(NombreTabla);
            DataTable dtControlador = new DataTable();
            daControlador.Fill(dtControlador);
            return dtControlador;
        }
    }
}
