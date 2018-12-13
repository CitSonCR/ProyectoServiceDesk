using ProyectoServiceDesk.Controlador;
using ProyectoServiceDesk_Controller;
using ProyectoServiceDesk_Logic;
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
        
        LogicaEquipo logicaEquipo = new LogicaEquipo();
        public Nuevo_Equipo()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void cboxDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Equipo equipo = new Equipo();
           
        }

        private void btnRegresar_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                Departamento departamento = null;

                Equipo equipo = new Equipo(txtNombre.Text, txtDescripcion.Text, departamento);


                if (logicaEquipo.IngresarEquipo(equipo.Nombre, equipo.Descripcion, departamento))
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombre_TextChanged(object sender,KeyPressEventArgs e)
        {
            //llamamos al metodo "ValidarNombre" que valida que no hayan valores diferentes de letras en el textbox
            logicaEquipo.ValidarNombre(e);
        }
    }
}
