using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_TallerMVC;

namespace Capa_Vista_TallerMVC
{
    public partial class frmPrincipal : Form
    {
        string nombreTabla = "tbl_pelicula";
        Controlador Controlador = new Controlador();
        public frmPrincipal()
        {
            InitializeComponent();
        }
        public void actualizarDgv()
        {
            DataTable dtVista = Controlador.llenardgv(nombreTabla);
            DgvConsultaTabla.DataSource = dtVista;
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            actualizarDgv();
        }
    }
}
