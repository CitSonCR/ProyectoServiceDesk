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
using ProyectoServiceDesk_Controller;
using ProyectoServiceDesk.Controlador;
using ProyectoServiceDesk_Controller.LogicaNegocio;

namespace ProyectoServiceDesk_View.Forms
{
    public partial class TareaNueva : Form
    {

        LogicaSolicitud logicaSolicitud = new LogicaSolicitud();
        LogicaTarea logicaTarea = new LogicaTarea();
        LogicaUsuario logicaUsuario = new LogicaUsuario();
        public string UserName { get; set; }
        public TareaNueva()
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
            Inicio inicio = new Inicio();
            this.Hide();
            inicio.UserNameTxt = UserName;
            inicio.ShowDialog();            
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
        //Solo letras y backspace
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || 8.Equals(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtHoras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || 8.Equals(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtDificultad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || 8.Equals(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usuario = logicaUsuario.ObtenerInfoUsuario(txtUsuarioA.Text);
                Solicitud solicitud = logicaSolicitud.ObtenerInfoCompletaSolicitud(Convert.ToInt16(cmbSolicitud.SelectedValue.ToString()));
                Tarea tarea = new Tarea(0, txtNombre.Text, Convert.ToInt32(txtHoras.Text), Convert.ToInt32(txtDificultad.Text), cmbEstadoTarea.Text.Substring(0, 1), usuario, Convert.ToDateTime(dateFechaAtencion.Text), solicitud);
                tarea.UsuarioAtiende = usuario;
                tarea.Solicitud = solicitud;
                if (!logicaTarea.ValidarCamposRequeridos(tarea))
                {
                    MessageBox.Show("Existe información pendiente de ser llenada", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (logicaTarea.IngresarTarea(tarea.NumeroPrioridad, tarea.Nombre, tarea.TiempoHoras, tarea.Dificultad, tarea.EstadoProceso, tarea.UsuarioAtiende, tarea.FechaAtencion, tarea.Solicitud))
                {
                    MessageBox.Show("Informacion guardada con exito!!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrio un error inesperado!! " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
