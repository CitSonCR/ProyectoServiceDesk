using ProyectoServiceDesk.Controlador;
using ProyectoServiceDesk_Controller;
using ProyectoServiceDesk_Controller.LogicaNegocio;
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

namespace ProyectoServiceDesk_View
{
    public partial class UsuarioNuevo : Form
    {
        public Persona persona;        
        public LogicaUsuario logicaUsuario = new LogicaUsuario();
        public LogicaEquipo logicaEquipo = new LogicaEquipo();

        public UsuarioNuevo()
        {
           
            InitializeComponent();
            cmbEquipo.ValueMember = "PSD_EQUIPO_ID";
            cmbEquipo.DisplayMember = "NOMBRE";
            cmbEquipo.DataSource = logicaEquipo.ObtenerNombreEquipos();
            CargarComboUsuario();

        }

        public void CargarComboUsuario()
        {
            cmbTipoUsuario.Items.Add("ADMINISTRADOR");
            cmbTipoUsuario.Items.Add("GENERAL");
            cmbTipoUsuario.Items.Add("DESARROLLADOR");
        }
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Departamento departamento = new Departamento("Informatica", "1", "Info");
                Equipo equipo = new Equipo(cmbEquipo.Text, string.Empty, departamento);
                equipo.Id = Convert.ToInt16(cmbEquipo.SelectedValue.ToString());
                Usuario usuario = new Usuario(txtNombreUsuario.Text, txtPassword.Text,DateTime.Now, cmbTipoUsuario.Text.Substring(0,1), equipo, persona);
                //Valida que los campos esten llenos
                if(!logicaUsuario.ValidarCamposRequeridos(usuario))
                {
                    MessageBox.Show("Existe información requerida que no se ha llenado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                //Valida que el password sea igual a la confirmacion
                if (!logicaUsuario.ValidarConfirmacionPassword(txtPassword.Text,txtConfirmPassword.Text))
                {
                    MessageBox.Show("La contraseña no coincide con la confirmacion", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                //Valida que el nombre de usuario no este repetido en la base de datos
                if (!logicaUsuario.ValidarNombreUsuario(usuario.UserName))
                {
                    MessageBox.Show("El nombre de usuario ya existe", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (logicaUsuario.IngresarUsuario(usuario.UserName, usuario.Password, usuario.TipoUsuario, equipo, persona))
                {
                    MessageBox.Show("Informacion guardada con exito!!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al guardar la informacion!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ha ocurrido un error inesperado !! " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
