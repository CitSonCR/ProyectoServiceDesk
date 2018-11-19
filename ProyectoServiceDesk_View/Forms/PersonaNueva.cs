using ProyectoServiceDesk_Controller;
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
                if (persona.IngresarPersona(persona.NumeroIdentificacion, persona.Nombre, persona.PrimerApellido, persona.SegundoApellido, persona.Edad, persona.Direccion, persona.Telefono, persona.CorreoElectronico, persona.Genero, persona.FechaNacimiento))
                {
                    MessageBox.Show("informacion guardada con exito!!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UsuarioNuevo usuario = new UsuarioNuevo();
                    usuario.persona = persona;
                    usuario.ShowDialog();
                    
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
    }
}
