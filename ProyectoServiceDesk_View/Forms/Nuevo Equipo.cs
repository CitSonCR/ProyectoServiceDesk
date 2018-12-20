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
        public string UserName { get; set; }
        LogicaEquipo logicaEquipo = new LogicaEquipo();
        //Hacemos instancia de la clase LogicaDepartamento para utilizarla en el main del nuevo equipo para obtener los datos del departamento en el combobox del departamento en la vista de equipo 
        LogicaDepartamento logicaDepartamento = new LogicaDepartamento();
        public Nuevo_Equipo()
        {
            
            InitializeComponent();
            //Un valor del combo box es ID del departamento 
            cboxDepartamento.ValueMember = "PSD_DEPARTAMENTO_ID";
            //Lo que mostramos es el nombre en el display a la hora que se ve en el combo box 
            cboxDepartamento.DisplayMember = "NOMBRE";
            //con el data source obtenemos la info que está contenida en el departamento 
            cboxDepartamento.DataSource = logicaDepartamento.ObtenerInfoDepartamentos();
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
            Inicio inicio = new Inicio();
            this.Hide();
            inicio.UserNameTxt = UserName;
            inicio.ShowDialog();
            this.Close();
        }


        //Esta funcion en el txt del nombre del equipo valida que el usuario solo digite letras en este campo, con la propiedad IsLetter alojada en un char 
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

        //Esta funcion en el txt del nombre del equipo valida que el usuario solo digite letras en este campo, con la propiedad IsLetter alojada en un char 
        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
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

    }
}
