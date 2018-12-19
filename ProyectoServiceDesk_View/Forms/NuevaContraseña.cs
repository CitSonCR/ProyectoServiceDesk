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
                LogicaUsuario logicausuario = new LogicaUsuario();
                Usuario usuario = null;
                if (txtAnterior.Text.Equals(usuario.Password) && txtNueva.Text.Equals(txtConfirmarNueva))
                {
                    if (!logicausuario.EditarContrasena(txtAnterior.Text, txtNueva.Text))
                    {
                        MessageBox.Show("Cambio de contraseña sin ser exitoso, vuelva a intentar!!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                    else
                    {
                        if (logicausuario.EditarContrasena(txtAnterior.Text, txtNueva.Text))
                        {
                            MessageBox.Show("Cambio de contraseña exitoso!!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

            }
            catch(Exception)
            {
                MessageBox.Show("Ha ocurrio un error inesperado!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


