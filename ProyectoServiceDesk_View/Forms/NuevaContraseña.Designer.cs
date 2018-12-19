namespace ProyectoServiceDesk_View.Forms
{
    partial class NuevaContraseña
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevaContraseña));
            this.label1 = new System.Windows.Forms.Label();
            this.txtConfirmarNueva = new System.Windows.Forms.TextBox();
            this.lblConfirmar = new System.Windows.Forms.Label();
            this.txtNueva = new System.Windows.Forms.TextBox();
            this.lblNueva = new System.Windows.Forms.Label();
            this.txtAnterior = new System.Windows.Forms.TextBox();
            this.lblAnterior = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 26);
            this.label1.TabIndex = 34;
            this.label1.Text = "Cambiar Contraseña";
            // 
            // txtConfirmarNueva
            // 
            this.txtConfirmarNueva.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmarNueva.Location = new System.Drawing.Point(11, 232);
            this.txtConfirmarNueva.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtConfirmarNueva.MaxLength = 15;
            this.txtConfirmarNueva.Name = "txtConfirmarNueva";
            this.txtConfirmarNueva.Size = new System.Drawing.Size(246, 24);
            this.txtConfirmarNueva.TabIndex = 31;
            this.txtConfirmarNueva.TextChanged += new System.EventHandler(this.txtConfirmarNueva_TextChanged);
            // 
            // lblConfirmar
            // 
            this.lblConfirmar.AutoSize = true;
            this.lblConfirmar.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmar.Location = new System.Drawing.Point(8, 211);
            this.lblConfirmar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConfirmar.Name = "lblConfirmar";
            this.lblConfirmar.Size = new System.Drawing.Size(153, 17);
            this.lblConfirmar.TabIndex = 33;
            this.lblConfirmar.Text = "Confirmar Contraseña";
            // 
            // txtNueva
            // 
            this.txtNueva.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNueva.Location = new System.Drawing.Point(11, 168);
            this.txtNueva.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtNueva.MaxLength = 15;
            this.txtNueva.Name = "txtNueva";
            this.txtNueva.Size = new System.Drawing.Size(246, 24);
            this.txtNueva.TabIndex = 29;
            this.txtNueva.TextChanged += new System.EventHandler(this.txtNueva_TextChanged);
            // 
            // lblNueva
            // 
            this.lblNueva.AutoSize = true;
            this.lblNueva.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNueva.Location = new System.Drawing.Point(8, 148);
            this.lblNueva.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNueva.Name = "lblNueva";
            this.lblNueva.Size = new System.Drawing.Size(129, 17);
            this.lblNueva.TabIndex = 32;
            this.lblNueva.Text = "Nueva Contraseña";
            // 
            // txtAnterior
            // 
            this.txtAnterior.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnterior.Location = new System.Drawing.Point(11, 106);
            this.txtAnterior.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtAnterior.MaxLength = 10;
            this.txtAnterior.Name = "txtAnterior";
            this.txtAnterior.Size = new System.Drawing.Size(246, 24);
            this.txtAnterior.TabIndex = 28;
            this.txtAnterior.TextChanged += new System.EventHandler(this.txtAnterior_TextChanged);
            // 
            // lblAnterior
            // 
            this.lblAnterior.AutoSize = true;
            this.lblAnterior.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnterior.Location = new System.Drawing.Point(8, 84);
            this.lblAnterior.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAnterior.Name = "lblAnterior";
            this.lblAnterior.Size = new System.Drawing.Size(135, 17);
            this.lblAnterior.TabIndex = 30;
            this.lblAnterior.Text = "Contraseña Antigua";
            // 
            // btnGuardar
            // 
            this.btnGuardar.AccessibleDescription = "Guardar";
            this.btnGuardar.AccessibleName = "Guardar";
            this.btnGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuardar.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(324, 258);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(49, 38);
            this.btnGuardar.TabIndex = 35;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // NuevaContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(410, 307);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtConfirmarNueva);
            this.Controls.Add(this.lblConfirmar);
            this.Controls.Add(this.txtNueva);
            this.Controls.Add(this.lblNueva);
            this.Controls.Add(this.txtAnterior);
            this.Controls.Add(this.lblAnterior);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "NuevaContraseña";
            this.Text = "NuevaContraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConfirmarNueva;
        private System.Windows.Forms.Label lblConfirmar;
        private System.Windows.Forms.TextBox txtNueva;
        private System.Windows.Forms.Label lblNueva;
        private System.Windows.Forms.TextBox txtAnterior;
        private System.Windows.Forms.Label lblAnterior;
        private System.Windows.Forms.Button btnGuardar;
    }
}