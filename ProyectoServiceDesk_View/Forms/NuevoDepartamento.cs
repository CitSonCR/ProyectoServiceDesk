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
    public partial class NuevoDepartamento : Form
    {
        public NuevoDepartamento()
        {
            InitializeComponent();
        }

         private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Departamento departamento = new Departamento(txtNombre.Text,txtTipo.Text,lblDescripcion.Text, Convert.ToInt32(txtId.Text));
                if (departamento.IngresarDepartamento(departamento.Nombre,departamento.Tipo,departamento.Descripcion,departamento.Id))
                {
                    MessageBox.Show("informacion guardada con exito!!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UsuarioNuevo usuario = new UsuarioNuevo();
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
