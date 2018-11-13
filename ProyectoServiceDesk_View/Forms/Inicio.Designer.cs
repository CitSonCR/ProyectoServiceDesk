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
            this.btnAdmEquipo = new System.Windows.Forms.Button();
            this.btnAdmDepartamento = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdmEquipo
            // 
            this.btnAdmEquipo.Font = new System.Drawing.Font("Arial", 10.8F);
            this.btnAdmEquipo.Location = new System.Drawing.Point(576, 173);
            this.btnAdmEquipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdmEquipo.Name = "btnAdmEquipo";
            this.btnAdmEquipo.Size = new System.Drawing.Size(205, 85);
            this.btnAdmEquipo.TabIndex = 2;
            this.btnAdmEquipo.Text = "Administar Equipo";
            this.btnAdmEquipo.UseVisualStyleBackColor = true;
            this.btnAdmEquipo.Click += new System.EventHandler(this.btnEquipo_Click);
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
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1008, 608);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnAdmDepartamento);
            this.Controls.Add(this.btnAdmEquipo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAdmEquipo;
        private System.Windows.Forms.Button btnAdmDepartamento;
        private System.Windows.Forms.Button btnRegresar;
    }
}