using ProyectoServiceDesk_Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoServiceDesk_View.Forms
{
    public partial class VisualizarEstadoSolicitud : Form
    {
        public string UserName { get; set; }
        LogicaSolicitud logicaSolicitud = new LogicaSolicitud();
        public VisualizarEstadoSolicitud()
        {
            InitializeComponent();
            dtgReporte.DataSource = logicaSolicitud.ObtenerReporteSolicitudes();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            this.Hide();
            inicio.UserNameTxt = UserName;
            inicio.ShowDialog();
            this.Close();
        }
    }
}
