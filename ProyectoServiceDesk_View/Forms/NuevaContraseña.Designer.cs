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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 38);
            this.label1.TabIndex = 34;
            this.label1.Text = "Cambiar Contraseña";
            // 
            // txtConfirmarNueva
            // 
            this.txtConfirmarNueva.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmarNueva.Location = new System.Drawing.Point(17, 357);
            this.txtConfirmarNueva.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtConfirmarNueva.MaxLength = 15;
            this.txtConfirmarNueva.Name = "txtConfirmarNueva";
            this.txtConfirmarNueva.Size = new System.Drawing.Size(367, 32);
            this.txtConfirmarNueva.TabIndex = 31;
            // 
            // lblConfirmar
            // 
            this.lblConfirmar.AutoSize = true;
            this.lblConfirmar.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmar.Location = new System.Drawing.Point(12, 325);
            this.lblConfirmar.Name = "lblConfirmar";
            this.lblConfirmar.Size = new System.Drawing.Size(226, 25);
            this.lblConfirmar.TabIndex = 33;
            this.lblConfirmar.Text = "Confirmar Contraseña";
            // 
            // txtNueva
            // 
            this.txtNueva.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNueva.Location = new System.Drawing.Point(17, 259);
            this.txtNueva.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNueva.MaxLength = 15;
            this.txtNueva.Name = "txtNueva";
            this.txtNueva.Size = new System.Drawing.Size(367, 32);
            this.txtNueva.TabIndex = 29;
            // 
            // lblNueva
            // 
            this.lblNueva.AutoSize = true;
            this.lblNueva.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNueva.Location = new System.Drawing.Point(12, 227);
            this.lblNueva.Name = "lblNueva";
            this.lblNueva.Size = new System.Drawing.Size(192, 25);
            this.lblNueva.TabIndex = 32;
            this.lblNueva.Text = "Nueva Contraseña";
            // 
            // txtAnterior
            // 
            this.txtAnterior.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnterior.Location = new System.Drawing.Point(17, 163);
            this.txtAnterior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAnterior.MaxLength = 10;
            this.txtAnterior.Name = "txtAnterior";
            this.txtAnterior.Size = new System.Drawing.Size(367, 32);
            this.txtAnterior.TabIndex = 28;
            // 
            // lblAnterior
            // 
            this.lblAnterior.AutoSize = true;
            this.lblAnterior.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnterior.Location = new System.Drawing.Point(12, 130);
            this.lblAnterior.Name = "lblAnterior";
            this.lblAnterior.Size = new System.Drawing.Size(201, 25);
            this.lblAnterior.TabIndex = 30;
            this.lblAnterior.Text = "Contraseña Antigua";
            // 
            // NuevaContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(642, 472);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtConfirmarNueva);
            this.Controls.Add(this.lblConfirmar);
            this.Controls.Add(this.txtNueva);
            this.Controls.Add(this.lblNueva);
            this.Controls.Add(this.txtAnterior);
            this.Controls.Add(this.lblAnterior);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
    }
}