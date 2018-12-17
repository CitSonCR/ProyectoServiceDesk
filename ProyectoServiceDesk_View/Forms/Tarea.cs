using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoServiceDesk_Logic;

namespace ProyectoServiceDesk_View.Forms
{
    public partial class Tarea : Form
    {

        LogicaSolicitud logicaSolicitud = new LogicaSolicitud();
        public string UserName { get; set; }
        public Tarea()
        {
            InitializeComponent();
            cmbSolicitud.ValueMember = "PSD_SOLICITUD_ID";
            cmbSolicitud.DisplayMember = "TITULO";
            cmbSolicitud.DataSource = logicaSolicitud.ObtenerInfoSolicitud();
            ManejoDeCampos(false);
            txtUsuarioA.Enabled = false;
            cmbEstadoTarea.Enabled = false;
            CargarCombos();
        }
        private void ManejoDeCampos(bool habilitar)
        {
            txtNombre.Enabled = habilitar;
            txtHoras.Enabled = habilitar;
            txtDificultad.Enabled = habilitar;
        }
        private void CargarCombos()
        {

            cmbEstadoTarea.Items.Add("SOLICITUD");
            cmbEstadoTarea.Items.Add("PROCESO");
            cmbEstadoTarea.Items.Add("FINALIZADO");
            cmbEstadoTarea.SelectedIndex = 0;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Tarea_Load(object sender, EventArgs e)
        {
            txtUsuarioA.Text = UserName;
            txtUsuarioA.Enabled = false;
        }

        private void btnAtender_Click(object sender, EventArgs e)
        {
            ManejoDeCampos(true);
            cmbSolicitud.Enabled = false;
            txtNombre.Focus();
        }
    }
}
