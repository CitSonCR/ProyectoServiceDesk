using ProyectoServiceDesk_Controller.LogicaNegocio;
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
    public partial class Inicio : Form
    {
        public string UserNameTxt { get; set; }
        LogicaUsuario logicaUsuario = new LogicaUsuario();
        public Inicio()
        {
            InitializeComponent();
            MostrarBotones();
        }

        private void MostrarBotones()
        {
            btnAdmDepartamento.Visible = true;
            btnAdmiEquipo.Visible = true;
            btnManejoTarea.Visible = true;
            btnSolicitud.Visible = true;
            btnTarea.Visible = true;
        }
       
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
        }

        private void btnDepartamento_Click(object sender, EventArgs e)
        {
            NuevoDepartamento dep = new NuevoDepartamento();
            this.Hide();
            dep.UserName = lblUserName.Text;
            dep.ShowDialog();
            this.Close();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            PersonaNueva person = new PersonaNueva();
            person.Show();
        }

        private void btnEquipo_Click(object sender, EventArgs e)
        {
            Nuevo_Equipo equipo = new Nuevo_Equipo();
            this.Hide();
            equipo.UserName = lblUserName.Text;
            equipo.ShowDialog();
            this.Close();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnManejoTarea_Click(object sender, EventArgs e)
        {
            ManejoTarea mt = new ManejoTarea();
            this.Hide();
            mt.UserName = lblUserName.Text;
            mt.ShowDialog();            
            this.Close();
        }

        private void btnTarea_Click(object sender, EventArgs e)
        {         
            TareaNueva tarea = new TareaNueva();
            this.Hide();
            tarea.UserName = lblUserName.Text;
            tarea.ShowDialog();
            this.Close();
        }

        private void btnSolicitud_Click(object sender, EventArgs e)
        {
            SolicitudNueva soli = new SolicitudNueva();
            this.Hide();
            soli.UserName = lblUserName.Text;
            soli.ShowDialog();
            this.Close();
        }

        private void btnAdmiEquipo_Click(object sender, EventArgs e)
        {
            Nuevo_Equipo equipo = new Nuevo_Equipo();
            this.Hide();
            equipo.UserName = lblUserName.Text;
            equipo.ShowDialog();
            this.Close();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            lblUserName.Text = UserNameTxt;
            string tipoUsuario = logicaUsuario.ObtenerTipoUsuario(UserNameTxt);
            /*Se valida por el tipo de usuario para mostrarle las opciones del menu*/
            if (tipoUsuario.Equals("A"))
            {
                
            }
            if (tipoUsuario.Equals("D"))            
            {
                btnAdmDepartamento.Visible = false;
                btnAdmiEquipo.Visible = false;
                btnRegistrarse.Visible = false;
            }
            if (tipoUsuario.Equals("G"))
            {
                btnAdmDepartamento.Visible = false;
                btnAdmiEquipo.Visible = false;
                btnManejoTarea.Visible = false;
                btnTarea.Visible = false;
                btnRegistrarse.Visible = false;
            }
        }

        private void btnRegistrarse_Click_1(object sender, EventArgs e)
        {
            PersonaNueva person = new PersonaNueva();
            this.Hide();
            person.UserName = lblUserName.Text;
            person.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VisualizarEstadoSolicitud visualizar = new VisualizarEstadoSolicitud();
            this.Hide();
            visualizar.UserName = lblUserName.Text;
            visualizar.ShowDialog();
            this.Close();
        }
    }
}
