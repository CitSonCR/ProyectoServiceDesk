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
            NuevoDepartamento dep = new NuevoDepartamento();
            dep.Show();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            PersonaNueva person = new PersonaNueva();
            person.Show();
        }

        private void btnEquipo_Click(object sender, EventArgs e)
        {
            Nuevo_Equipo equipo = new Nuevo_Equipo();
            equipo.Show();
        }
    }
}
