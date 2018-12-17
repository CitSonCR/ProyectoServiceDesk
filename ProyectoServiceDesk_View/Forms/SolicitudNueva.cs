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
    public partial class SolicitudNueva : Form
    {
        public string UserName { get; set; }
        
        public SolicitudNueva()
        {
            InitializeComponent();
            CargarCombos();
            cmbEstado.Enabled = false;
        }

        private void CargarCombos()
        {
            cmbPrioridad.Items.Add("BAJA");
            cmbPrioridad.Items.Add("MEDIA");
            cmbPrioridad.Items.Add("ALTA");

            cmbEstado.Items.Add("SOLICITUD");
            cmbEstado.Items.Add("PROCESO");
            cmbEstado.Items.Add("FINALIZADO");
            cmbEstado.SelectedIndex = 0;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {

                MessageBox.Show("Ha ocurrido un error inesperado !! "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Solicitud_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = UserName;
            txtUsuario.Enabled = false;
            txtSolucion.Enabled = false;
            listViewTareas.Enabled = false;
        }
    }
}
