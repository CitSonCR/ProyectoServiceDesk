﻿namespace ProyectoServiceDesk_View.Forms
{
    partial class AdministrarEquipo
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
            this.btnModificarEquipo = new System.Windows.Forms.Button();
            this.btnEliminarEquipo = new System.Windows.Forms.Button();
            this.btnAddEquipo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnModificarEquipo
            // 
            this.btnModificarEquipo.Font = new System.Drawing.Font("Arial", 10.8F);
            this.btnModificarEquipo.Location = new System.Drawing.Point(389, 218);
            this.btnModificarEquipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificarEquipo.Name = "btnModificarEquipo";
            this.btnModificarEquipo.Size = new System.Drawing.Size(205, 85);
            this.btnModificarEquipo.TabIndex = 9;
            this.btnModificarEquipo.Text = "Modificar Equipo";
            this.btnModificarEquipo.UseVisualStyleBackColor = true;
            // 
            // btnEliminarEquipo
            // 
            this.btnEliminarEquipo.Font = new System.Drawing.Font("Arial", 10.8F);
            this.btnEliminarEquipo.Location = new System.Drawing.Point(389, 347);
            this.btnEliminarEquipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarEquipo.Name = "btnEliminarEquipo";
            this.btnEliminarEquipo.Size = new System.Drawing.Size(205, 85);
            this.btnEliminarEquipo.TabIndex = 8;
            this.btnEliminarEquipo.Text = "Eliminar Equipo";
            this.btnEliminarEquipo.UseVisualStyleBackColor = true;
            // 
            // btnAddEquipo
            // 
            this.btnAddEquipo.Font = new System.Drawing.Font("Arial", 10.8F);
            this.btnAddEquipo.Location = new System.Drawing.Point(389, 86);
            this.btnAddEquipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddEquipo.Name = "btnAddEquipo";
            this.btnAddEquipo.Size = new System.Drawing.Size(205, 85);
            this.btnAddEquipo.TabIndex = 7;
            this.btnAddEquipo.Text = "Agregar Equipo";
            this.btnAddEquipo.UseVisualStyleBackColor = true;
            this.btnAddEquipo.Click += new System.EventHandler(this.btnAddEquipo_Click);
            // 
            // AdministrarEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 623);
            this.Controls.Add(this.btnModificarEquipo);
            this.Controls.Add(this.btnEliminarEquipo);
            this.Controls.Add(this.btnAddEquipo);
            this.Name = "AdministrarEquipo";
            this.Text = "AdministrarEquipo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnModificarEquipo;
        private System.Windows.Forms.Button btnEliminarEquipo;
        private System.Windows.Forms.Button btnAddEquipo;
    }
}