namespace ProyectoServiceDesk_View
{
    partial class AdministrarDepartamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministrarDepartamento));
            this.btnAddDepartamento = new System.Windows.Forms.Button();
            this.btnEliminarDep = new System.Windows.Forms.Button();
            this.btnModificarDep = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddDepartamento
            // 
            this.btnAddDepartamento.Font = new System.Drawing.Font("Arial", 10.8F);
            this.btnAddDepartamento.Location = new System.Drawing.Point(396, 82);
            this.btnAddDepartamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddDepartamento.Name = "btnAddDepartamento";
            this.btnAddDepartamento.Size = new System.Drawing.Size(205, 85);
            this.btnAddDepartamento.TabIndex = 4;
            this.btnAddDepartamento.Text = "Agregar Departamentos";
            this.btnAddDepartamento.UseVisualStyleBackColor = true;
            this.btnAddDepartamento.Click += new System.EventHandler(this.btnAddDepartamento_Click);
            // 
            // btnEliminarDep
            // 
            this.btnEliminarDep.Font = new System.Drawing.Font("Arial", 10.8F);
            this.btnEliminarDep.Location = new System.Drawing.Point(396, 343);
            this.btnEliminarDep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarDep.Name = "btnEliminarDep";
            this.btnEliminarDep.Size = new System.Drawing.Size(205, 85);
            this.btnEliminarDep.TabIndex = 5;
            this.btnEliminarDep.Text = "Eliminar Departamentos";
            this.btnEliminarDep.UseVisualStyleBackColor = true;
            this.btnEliminarDep.Visible = false;
            // 
            // btnModificarDep
            // 
            this.btnModificarDep.Font = new System.Drawing.Font("Arial", 10.8F);
            this.btnModificarDep.Location = new System.Drawing.Point(396, 214);
            this.btnModificarDep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificarDep.Name = "btnModificarDep";
            this.btnModificarDep.Size = new System.Drawing.Size(205, 85);
            this.btnModificarDep.TabIndex = 6;
            this.btnModificarDep.Text = "Modificar Departamentos";
            this.btnModificarDep.UseVisualStyleBackColor = true;
            this.btnModificarDep.Visible = false;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegresar.Image")));
            this.btnRegresar.Location = new System.Drawing.Point(12, 560);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(49, 49);
            this.btnRegresar.TabIndex = 37;
            this.btnRegresar.UseVisualStyleBackColor = true;
            // 
            // AdministrarDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1025, 622);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnModificarDep);
            this.Controls.Add(this.btnEliminarDep);
            this.Controls.Add(this.btnAddDepartamento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdministrarDepartamento";
            this.Text = "AdministrarDepartamento";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddDepartamento;
        private System.Windows.Forms.Button btnEliminarDep;
        private System.Windows.Forms.Button btnModificarDep;
        private System.Windows.Forms.Button btnRegresar;
    }
}