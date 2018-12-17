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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.btnAdmDepartamento = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnAdmiEquipo = new System.Windows.Forms.Button();
            this.btnTarea = new System.Windows.Forms.Button();
            this.btnManejoTarea = new System.Windows.Forms.Button();
            this.btnSolicitud = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdmDepartamento
            // 
            this.btnAdmDepartamento.Font = new System.Drawing.Font("Arial", 10.8F);
            this.btnAdmDepartamento.Location = new System.Drawing.Point(313, 198);
            this.btnAdmDepartamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdmDepartamento.Name = "btnAdmDepartamento";
            this.btnAdmDepartamento.Size = new System.Drawing.Size(418, 71);
            this.btnAdmDepartamento.TabIndex = 3;
            this.btnAdmDepartamento.Text = "Administrar Departamentos";
            this.btnAdmDepartamento.UseVisualStyleBackColor = true;
            this.btnAdmDepartamento.Click += new System.EventHandler(this.btnDepartamento_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegresar.Image")));
            this.btnRegresar.Location = new System.Drawing.Point(12, 546);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(50, 49);
            this.btnRegresar.TabIndex = 37;
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnAdmiEquipo
            // 
            this.btnAdmiEquipo.Font = new System.Drawing.Font("Arial", 10.8F);
            this.btnAdmiEquipo.Location = new System.Drawing.Point(313, 111);
            this.btnAdmiEquipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdmiEquipo.Name = "btnAdmiEquipo";
            this.btnAdmiEquipo.Size = new System.Drawing.Size(418, 68);
            this.btnAdmiEquipo.TabIndex = 38;
            this.btnAdmiEquipo.Text = "Administrar Equipo";
            this.btnAdmiEquipo.UseVisualStyleBackColor = true;
            this.btnAdmiEquipo.Click += new System.EventHandler(this.btnAdmiEquipo_Click);
            // 
            // btnTarea
            // 
            this.btnTarea.Font = new System.Drawing.Font("Arial", 10.8F);
            this.btnTarea.Location = new System.Drawing.Point(313, 378);
            this.btnTarea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTarea.Name = "btnTarea";
            this.btnTarea.Size = new System.Drawing.Size(418, 71);
            this.btnTarea.TabIndex = 39;
            this.btnTarea.Text = "Ingresar Tareas";
            this.btnTarea.UseVisualStyleBackColor = true;
            this.btnTarea.Click += new System.EventHandler(this.btnTarea_Click);
            // 
            // btnManejoTarea
            // 
            this.btnManejoTarea.Font = new System.Drawing.Font("Arial", 10.8F);
            this.btnManejoTarea.Location = new System.Drawing.Point(313, 475);
            this.btnManejoTarea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnManejoTarea.Name = "btnManejoTarea";
            this.btnManejoTarea.Size = new System.Drawing.Size(418, 70);
            this.btnManejoTarea.TabIndex = 40;
            this.btnManejoTarea.Text = "Manejo de tareas";
            this.btnManejoTarea.UseVisualStyleBackColor = true;
            this.btnManejoTarea.Click += new System.EventHandler(this.btnManejoTarea_Click);
            // 
            // btnSolicitud
            // 
            this.btnSolicitud.Font = new System.Drawing.Font("Arial", 10.8F);
            this.btnSolicitud.Location = new System.Drawing.Point(313, 289);
            this.btnSolicitud.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSolicitud.Name = "btnSolicitud";
            this.btnSolicitud.Size = new System.Drawing.Size(418, 71);
            this.btnSolicitud.TabIndex = 41;
            this.btnSolicitud.Text = "Ingresar Solicitud";
            this.btnSolicitud.UseVisualStyleBackColor = true;
            this.btnSolicitud.Click += new System.EventHandler(this.btnSolicitud_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(14, 59);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(152, 33);
            this.lblUserName.TabIndex = 42;
            this.lblUserName.Text = "userName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 33);
            this.label1.TabIndex = 43;
            this.label1.Text = "Bienvenido:";
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.Font = new System.Drawing.Font("Arial", 10.8F);
            this.btnRegistrarse.Location = new System.Drawing.Point(313, 22);
            this.btnRegistrarse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(418, 70);
            this.btnRegistrarse.TabIndex = 44;
            this.btnRegistrarse.Text = "Registrarse";
            this.btnRegistrarse.UseVisualStyleBackColor = true;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click_1);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1008, 608);
            this.Controls.Add(this.btnRegistrarse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.btnSolicitud);
            this.Controls.Add(this.btnManejoTarea);
            this.Controls.Add(this.btnTarea);
            this.Controls.Add(this.btnAdmiEquipo);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnAdmDepartamento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAdmDepartamento;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnAdmiEquipo;
        private System.Windows.Forms.Button btnTarea;
        private System.Windows.Forms.Button btnManejoTarea;
        private System.Windows.Forms.Button btnSolicitud;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistrarse;
    }
}