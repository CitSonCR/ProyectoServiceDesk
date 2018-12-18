using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoServiceDesk.Controlador;
using ProyectoServiceDesk_Controller.LogicaNegocio;
using ProyectoServiceDesk_Logic;

namespace ProyectoServiceDesk_View.Forms
{
    public partial class SolicitudNueva : Form
    {
        public string UserName { get; set; }


        LogicaTarea logicatarea = new LogicaTarea();
        LogicaUsuario logicaUsuario = new LogicaUsuario();
        LogicaSolicitud logicaSolicitud = new LogicaSolicitud();


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
                    Usuario usuario = logicaUsuario.ObtenerInfoUsuario(txtUsuario.Text);
                List<Tarea> tareas = null;
                    Solicitud solicitud = new Solicitud(0,0,txttitulo.Text,txtTipo.Text,richTextBox1.Text,cmbEstado.Text,Convert.ToInt16(cmbPrioridad.Text),txtSolucion.Text,usuario,Convert.ToDateTime(dateFechaAtencion.Text),tareas);
                
                if (!logicaSolicitud.ValidarCamposRequeridos(solicitud))
                    {
                        MessageBox.Show("Existe información pendiente de ser llenada", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    if (logicaSolicitud.IngresarSolicitud(solicitud.Id,solicitud.NumeroIdentificador,solicitud.Titulo,solicitud.Tipo,solicitud.Detalle,solicitud.Estado,solicitud.Prioridad,solicitud.Solucion,usuario,solicitud.FechaIngreso,tareas))
                    {
                        MessageBox.Show("Informacion guardada con exito!!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrio un error inesperado!! " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
