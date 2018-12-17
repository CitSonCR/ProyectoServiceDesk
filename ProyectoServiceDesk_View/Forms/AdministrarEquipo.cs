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
    public partial class AdministrarEquipo : Form
    {
        public AdministrarEquipo()
        {
            InitializeComponent();
        }

        private void btnAddEquipo_Click(object sender, EventArgs e)
        {
            Nuevo_Equipo equipo = new Nuevo_Equipo();
            equipo.ShowDialog();
        }

        private void btnEliminarEquipo_Click(object sender, EventArgs e)
        {

        }
    }
}
