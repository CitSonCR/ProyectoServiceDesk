﻿namespace ProyectoServiceDesk_View.Forms
{
    partial class Inicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEquipo = new System.Windows.Forms.Button();
            this.btnDepartamento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEquipo
            // 
            this.btnEquipo.Location = new System.Drawing.Point(352, 223);
            this.btnEquipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEquipo.Name = "btnEquipo";
            this.btnEquipo.Size = new System.Drawing.Size(182, 42);
            this.btnEquipo.TabIndex = 2;
            this.btnEquipo.Text = "Nuevo Equipo";
            this.btnEquipo.UseVisualStyleBackColor = true;
            this.btnEquipo.Click += new System.EventHandler(this.btnEquipo_Click);
            // 
            // btnDepartamento
            // 
            this.btnDepartamento.Location = new System.Drawing.Point(352, 79);
            this.btnDepartamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDepartamento.Name = "btnDepartamento";
            this.btnDepartamento.Size = new System.Drawing.Size(182, 42);
            this.btnDepartamento.TabIndex = 3;
            this.btnDepartamento.Text = "Nuevo Departamento";
            this.btnDepartamento.UseVisualStyleBackColor = true;
            this.btnDepartamento.Click += new System.EventHandler(this.btnDepartamento_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 486);
            this.Controls.Add(this.btnDepartamento);
            this.Controls.Add(this.btnEquipo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnEquipo;
        private System.Windows.Forms.Button btnDepartamento;
    }
}