﻿using ProyectoServiceDesk.Controlador;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            PersonaNueva person = new PersonaNueva();
            person.ShowDialog();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            LogicaUsuario logicaUsuario = new LogicaUsuario();
            if (logicaUsuario.ValidarUsuario(txtUsuario.Text, txtContraseña.Text))
            {
                Inicio inicio = new Inicio();                
                this.Hide();
                inicio.UserNameTxt = txtUsuario.Text;
                inicio.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrecto!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDepartamento_Click(object sender, EventArgs e)
        {
            NuevoDepartamento dep = new NuevoDepartamento();
            dep.ShowDialog();
        
        }

        private void btnNuevoEquipo_Click(object sender, EventArgs e)
        {
            Nuevo_Equipo equipo = new Nuevo_Equipo();
            equipo.ShowDialog();
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCambioPassword_Click(object sender, EventArgs e)
        {
            NuevaContraseña contra = new NuevaContraseña();
            contra.Show();
        }
    }
}
