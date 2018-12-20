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
    public partial class NuevoDepartamento : Form
    {
        public string UserName { get; set; }
        LogicaDepartamento logicaDepartamento = new LogicaDepartamento();
        public NuevoDepartamento()
        {

            InitializeComponent();
        }

         private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                Departamento departamento = new Departamento(txtNombre.Text, txtTipo.Text, txtDescripcion.Text);
                if (logicaDepartamento.IngresarDepartamento( departamento.Nombre, departamento.Tipo, departamento.Descripcion))
                {
                    MessageBox.Show("informacion guardada con exito!!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NuevoDepartamento dep = new NuevoDepartamento();
                    dep.ShowDialog();
                    
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al guardar la informacion!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Ha ocurrio un error inesperado!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click_1(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            this.Hide();
            inicio.UserNameTxt = UserName;
            inicio.ShowDialog();
            this.Close();
        }

        //Esta funcion en el txt del nombre del departamento valida que el usuario solo digite letras en este campo, con la propiedad IsLetter alojada en un char 
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

         //Esta funcion en el txt del descripcion del departamento valida que el usuario solo digite letras en este campo, con la propiedad IsLetter alojada en un char 
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
    
    

