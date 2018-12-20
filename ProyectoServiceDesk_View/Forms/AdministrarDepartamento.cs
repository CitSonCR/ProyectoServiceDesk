using ProyectoServiceDesk_View.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoServiceDesk_View
{
    public partial class AdministrarDepartamento : Form
    {
        public AdministrarDepartamento()
        {
            InitializeComponent();
        }

        private void btnAddDepartamento_Click(object sender, EventArgs e)
        {
            NuevoDepartamento dep = new NuevoDepartamento();
            dep.ShowDialog();
        }

        private void btnEliminarDep_Click(object sender, EventArgs e)
        {

        }
    }
}
