using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoServiceDesk_Controller;
using ProyectoServiceDesk_Logic;
using System.Windows.Forms;
using ProyectoServiceDesk_Controller.LogicaNegocio;
using ProyectoServiceDesk.Controlador;

namespace ProyectoServiceDesk_View.Forms
{
    public partial class NuevaContraseña : Form
    {
        LogicaUsuario logicausuario = new LogicaUsuario();
        public NuevaContraseña()
        {
            InitializeComponent();
        }

        private void txtAnterior_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNueva_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtConfirmarNueva_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                
                Usuario usuario = logicausuario.ObtenerInfoUsuario(txtUserName.Text);
                if (txtAnterior.Text.Equals(usuario.Password))
                {
                    if(txtNueva.Text.Equals(txtConfirmarNueva.Text))
                    {                    
                        if (logicausuario.EditarContrasena(usuario.Id, txtNueva.Text))
                            MessageBox.Show("Cambio de contraseña exitoso!!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);                                                
                        else
                            MessageBox.Show("Cambio de contraseña sin ser exitoso, vuelva a intentar!!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);                        
                    }
                    else
                        MessageBox.Show("La contraseña nueva no coincide con la contraseña de confirmacion", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("La contraseña actual no coincide con la digitada en el campo de contraseña anterior", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception)
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


