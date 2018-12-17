using ProyectoServiceDesk_Controller;
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
    public partial class PersonaNueva : Form
    {
        LogicaPersona logicaPersona = new LogicaPersona();

        public PersonaNueva()
        {
            InitializeComponent();
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void UsuarioNuevo_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                Persona persona = new Persona(Convert.ToInt32(txtCedula.Text), txtNombre.Text, txtApellido1.Text, txtApellido2.Text, Convert.ToInt32(cmbEdad.Value.ToString()), txtDireccion.Text, Convert.ToInt32(txtTelefono.Text), txtCorreo.Text, "H", Convert.ToDateTime(dateNacimiento.Text));
                //Valida que se este ingresando toda la informacion
                if(!logicaPersona.ValidarCamposRequeridos(persona))
                {
                    MessageBox.Show("Existe información pendiente de ser llenada", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                //Valida que el email sea valido
                if (!logicaPersona.ValidarEmail(persona.CorreoElectronico))
                {
                    MessageBox.Show("El correo electrónico no es una dirección válida", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (!logicaPersona.ValidarEdadYFecha(persona))
                {
                    MessageBox.Show("La informacion de la edad y la fecha de nacimiento no coinciden", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }                
                if (logicaPersona.IngresarPersona(persona.NumeroIdentificacion, persona.Nombre, persona.PrimerApellido, persona.SegundoApellido, persona.Edad, persona.Direccion, persona.Telefono, persona.CorreoElectronico, persona.Genero, persona.FechaNacimiento))
                {
                    MessageBox.Show("Informacion guardada con exito!!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UsuarioNuevo usuario = new UsuarioNuevo();
                    this.Hide();
                    usuario.persona = persona;
                    usuario.ShowDialog();
                    this.Close();
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

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Solo numeros y backspace
        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || 8.Equals(e.KeyChar))
            {
                e.Handled = false;
            }            
            else
            {
                e.Handled = true;
            }

        }
        //Solo letras y backspace
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
        //Solo letras y backspace
        private void txtApellido1_KeyPress(object sender, KeyPressEventArgs e)
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
        //Solo letras y backspace
        private void txtApellido2_KeyPress(object sender, KeyPressEventArgs e)
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
        //Solo numeros y backspace
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || 8.Equals(e.KeyChar))
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
