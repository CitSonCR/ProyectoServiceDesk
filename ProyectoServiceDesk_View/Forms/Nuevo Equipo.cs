using ProyectoServiceDesk.Controlador;
using ProyectoServiceDesk_Controller;
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

namespace ProyectoServiceDesk_View.Forms
{
    public partial class Nuevo_Equipo : Form
    {
        Departamento departamento = new Departamento();

        public Nuevo_Equipo()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Equipo equipo = new Equipo();
                
                
                if (equipo.IngresarEquipo(txtNombre.Text,lblDescripcion.Text,departamento))
                {
                    MessageBox.Show("informacion guardada con exito!!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al guardar la informacion!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
