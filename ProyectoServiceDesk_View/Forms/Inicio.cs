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
        public Inicio()
        {
            InitializeComponent();
        }


       
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
        }

        private void btnDepartamento_Click(object sender, EventArgs e)
        {
            AdministrarDepartamento dep = new AdministrarDepartamento();
            dep.Show();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            PersonaNueva person = new PersonaNueva();
            person.Show();
        }

        private void btnEquipo_Click(object sender, EventArgs e)
        {
            AdministrarEquipo equipo = new AdministrarEquipo();
            equipo.Show();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnManejoTarea_Click(object sender, EventArgs e)
        {
            ManejoTarea mt = new ManejoTarea();
            mt.Show();
        }

        private void btnTarea_Click(object sender, EventArgs e)
        {
            Tarea tarea = new Tarea();
            tarea.Show();
        }

        private void btnSolicitud_Click(object sender, EventArgs e)
        {
            Solicitud soli = new Solicitud();
            soli.Show();
        }

        private void btnAdmiEquipo_Click(object sender, EventArgs e)
        {
            AdministrarEquipo equipo = new AdministrarEquipo();
            equipo.Show();
        }
    }
}
