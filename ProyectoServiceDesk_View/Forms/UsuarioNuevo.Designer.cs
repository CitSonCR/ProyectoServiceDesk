namespace ProyectoServiceDesk_View
{
    partial class UsuarioNuevo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.cmbTipoUsuario = new System.Windows.Forms.ComboBox();
            this.cmbEquipo = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro nuevo usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre de usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contraseña:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tipo de usuario:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Equipo del usuario:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(46, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Confirmar contraseña:";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreUsuario.Location = new System.Drawing.Point(246, 91);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(238, 28);
            this.txtNombreUsuario.TabIndex = 6;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(246, 149);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(238, 28);
            this.txtPassword.TabIndex = 7;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.Location = new System.Drawing.Point(246, 203);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(238, 28);
            this.txtConfirmPassword.TabIndex = 8;
            // 
            // cmbTipoUsuario
            // 
            this.cmbTipoUsuario.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoUsuario.FormattingEnabled = true;
            this.cmbTipoUsuario.Items.AddRange(new object[] {
            "T"});
            this.cmbTipoUsuario.Location = new System.Drawing.Point(246, 266);
            this.cmbTipoUsuario.Name = "cmbTipoUsuario";
            this.cmbTipoUsuario.Size = new System.Drawing.Size(238, 29);
            this.cmbTipoUsuario.TabIndex = 9;
            // 
            // cmbEquipo
            // 
            this.cmbEquipo.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEquipo.FormattingEnabled = true;
            this.cmbEquipo.Items.AddRange(new object[] {
            "EQUI_TEST"});
            this.cmbEquipo.Location = new System.Drawing.Point(246, 319);
            this.cmbEquipo.Name = "cmbEquipo";
            this.cmbEquipo.Size = new System.Drawing.Size(238, 29);
            this.cmbEquipo.TabIndex = 10;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(135, 405);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(121, 31);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(320, 405);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(114, 31);
            this.btnRegresar.TabIndex = 12;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // UsuarioNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(609, 461);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cmbEquipo);
            this.Controls.Add(this.cmbTipoUsuario);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UsuarioNuevo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UsuarioNuevo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.ComboBox cmbTipoUsuario;
        private System.Windows.Forms.ComboBox cmbEquipo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnRegresar;
    }
}