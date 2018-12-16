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
            this.button1 = new System.Windows.Forms.Button();
            this.btnTarea = new System.Windows.Forms.Button();
            this.btnManejoTarea = new System.Windows.Forms.Button();
            this.btnSolicitud = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdmDepartamento
            // 
            this.btnAdmDepartamento.Font = new System.Drawing.Font("Arial", 10.8F);
            this.btnAdmDepartamento.Location = new System.Drawing.Point(197, 173);
            this.btnAdmDepartamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdmDepartamento.Name = "btnAdmDepartamento";
            this.btnAdmDepartamento.Size = new System.Drawing.Size(205, 85);
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
            this.btnRegresar.Size = new System.Drawing.Size(49, 49);
            this.btnRegresar.TabIndex = 37;
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 10.8F);
            this.button1.Location = new System.Drawing.Point(197, 62);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 85);
            this.button1.TabIndex = 38;
            this.button1.Text = "Administrar Departamentos";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnTarea
            // 
            this.btnTarea.Font = new System.Drawing.Font("Arial", 10.8F);
            this.btnTarea.Location = new System.Drawing.Point(576, 173);
            this.btnTarea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTarea.Name = "btnTarea";
            this.btnTarea.Size = new System.Drawing.Size(205, 85);
            this.btnTarea.TabIndex = 39;
            this.btnTarea.Text = "Ingresar Tareas";
            this.btnTarea.UseVisualStyleBackColor = true;
            this.btnTarea.Click += new System.EventHandler(this.btnTarea_Click);
            // 
            // btnManejoTarea
            // 
            this.btnManejoTarea.Font = new System.Drawing.Font("Arial", 10.8F);
            this.btnManejoTarea.Location = new System.Drawing.Point(199, 293);
            this.btnManejoTarea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnManejoTarea.Name = "btnManejoTarea";
            this.btnManejoTarea.Size = new System.Drawing.Size(205, 85);
            this.btnManejoTarea.TabIndex = 40;
            this.btnManejoTarea.Text = "Manejo de tareas";
            this.btnManejoTarea.UseVisualStyleBackColor = true;
            this.btnManejoTarea.Click += new System.EventHandler(this.btnManejoTarea_Click);
            // 
            // btnSolicitud
            // 
            this.btnSolicitud.Font = new System.Drawing.Font("Arial", 10.8F);
            this.btnSolicitud.Location = new System.Drawing.Point(576, 62);
            this.btnSolicitud.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSolicitud.Name = "btnSolicitud";
            this.btnSolicitud.Size = new System.Drawing.Size(205, 85);
            this.btnSolicitud.TabIndex = 41;
            this.btnSolicitud.Text = "Ingresar Solicitud";
            this.btnSolicitud.UseVisualStyleBackColor = true;
            this.btnSolicitud.Click += new System.EventHandler(this.btnSolicitud_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1008, 608);
            this.Controls.Add(this.btnSolicitud);
            this.Controls.Add(this.btnManejoTarea);
            this.Controls.Add(this.btnTarea);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnAdmDepartamento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAdmDepartamento;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnTarea;
        private System.Windows.Forms.Button btnManejoTarea;
        private System.Windows.Forms.Button btnSolicitud;
    }
}