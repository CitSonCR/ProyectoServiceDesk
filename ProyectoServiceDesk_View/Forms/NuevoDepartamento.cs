﻿using ProyectoServiceDesk.Controlador;
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
            this.Close();
        }

        private void txtNombre_TextChanged(object sender, KeyPressEventArgs e)
        {
            //llamamos al metodo "ValidarNombre" que valida que no hayan valores diferentes de letras en el textbox
            logicaDepartamento.ValidarNombre(e);
        }
    }
    }

