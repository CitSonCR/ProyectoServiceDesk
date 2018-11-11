namespace ProyectoServiceDesk_View.Forms
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
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.btnEquipo = new System.Windows.Forms.Button();
            this.btnDepartamento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(419, 180);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(146, 52);
            this.btnIniciar.TabIndex = 0;
            this.btnIniciar.Text = "Iniciar Sesion";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.Location = new System.Drawing.Point(419, 290);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(146, 52);
            this.btnRegistrarse.TabIndex = 1;
            this.btnRegistrarse.Text = "Registrarse";
            this.btnRegistrarse.UseVisualStyleBackColor = true;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click);
            // 
            // btnEquipo
            // 
            this.btnEquipo.Location = new System.Drawing.Point(625, 238);
            this.btnEquipo.Name = "btnEquipo";
            this.btnEquipo.Size = new System.Drawing.Size(146, 52);
            this.btnEquipo.TabIndex = 2;
            this.btnEquipo.Text = "Nuevo Equipo";
            this.btnEquipo.UseVisualStyleBackColor = true;
            this.btnEquipo.Click += new System.EventHandler(this.btnEquipo_Click);
            // 
            // btnDepartamento
            // 
            this.btnDepartamento.Location = new System.Drawing.Point(197, 238);
            this.btnDepartamento.Name = "btnDepartamento";
            this.btnDepartamento.Size = new System.Drawing.Size(146, 52);
            this.btnDepartamento.TabIndex = 3;
            this.btnDepartamento.Text = "Nuevo Departamento";
            this.btnDepartamento.UseVisualStyleBackColor = true;
            this.btnDepartamento.Click += new System.EventHandler(this.btnDepartamento_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 607);
            this.Controls.Add(this.btnDepartamento);
            this.Controls.Add(this.btnEquipo);
            this.Controls.Add(this.btnRegistrarse);
            this.Controls.Add(this.btnIniciar);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnRegistrarse;
        private System.Windows.Forms.Button btnEquipo;
        private System.Windows.Forms.Button btnDepartamento;
    }
}