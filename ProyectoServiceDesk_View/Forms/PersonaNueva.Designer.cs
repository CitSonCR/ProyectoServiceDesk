namespace ProyectoServiceDesk_View.Forms
{
    partial class PersonaNueva
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
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.lblCedula = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtApellido2 = new System.Windows.Forms.TextBox();
            this.lblApellido2 = new System.Windows.Forms.Label();
            this.txtApellido1 = new System.Windows.Forms.TextBox();
            this.lblApellido1 = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.cmbEdad = new System.Windows.Forms.NumericUpDown();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.dateNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblNacimiento = new System.Windows.Forms.Label();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.txtDireccion = new System.Windows.Forms.RichTextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEdad)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCedula
            // 
            this.txtCedula.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.Location = new System.Drawing.Point(72, 118);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(327, 28);
            this.txtCedula.TabIndex = 3;
            this.txtCedula.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedula.Location = new System.Drawing.Point(68, 92);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(70, 22);
            this.lblCedula.TabIndex = 2;
            this.lblCedula.Text = "Cedula";
            this.lblCedula.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(72, 195);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(327, 28);
            this.txtNombre.TabIndex = 5;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(68, 170);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(78, 22);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre";
            // 
            // txtApellido2
            // 
            this.txtApellido2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido2.Location = new System.Drawing.Point(72, 350);
            this.txtApellido2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtApellido2.Name = "txtApellido2";
            this.txtApellido2.Size = new System.Drawing.Size(327, 28);
            this.txtApellido2.TabIndex = 7;
            // 
            // lblApellido2
            // 
            this.lblApellido2.AutoSize = true;
            this.lblApellido2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido2.Location = new System.Drawing.Point(68, 319);
            this.lblApellido2.Name = "lblApellido2";
            this.lblApellido2.Size = new System.Drawing.Size(160, 22);
            this.lblApellido2.TabIndex = 6;
            this.lblApellido2.Text = "Segundo Apellido";
            // 
            // txtApellido1
            // 
            this.txtApellido1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido1.Location = new System.Drawing.Point(72, 274);
            this.txtApellido1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtApellido1.Name = "txtApellido1";
            this.txtApellido1.Size = new System.Drawing.Size(327, 28);
            this.txtApellido1.TabIndex = 9;
            // 
            // lblApellido1
            // 
            this.lblApellido1.AutoSize = true;
            this.lblApellido1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido1.Location = new System.Drawing.Point(68, 248);
            this.lblApellido1.Name = "lblApellido1";
            this.lblApellido1.Size = new System.Drawing.Size(139, 22);
            this.lblApellido1.TabIndex = 8;
            this.lblApellido1.Text = "Primer Apellido";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.Location = new System.Drawing.Point(547, 170);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(55, 22);
            this.lblEdad.TabIndex = 10;
            this.lblEdad.Text = "Edad";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(68, 489);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(90, 22);
            this.lblDireccion.TabIndex = 12;
            this.lblDireccion.Text = "Direccion";
            // 
            // cmbEdad
            // 
            this.cmbEdad.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEdad.Location = new System.Drawing.Point(551, 198);
            this.cmbEdad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbEdad.Name = "cmbEdad";
            this.cmbEdad.Size = new System.Drawing.Size(156, 28);
            this.cmbEdad.TabIndex = 14;
            this.cmbEdad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(71, 440);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(439, 28);
            this.txtCorreo.TabIndex = 16;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(69, 402);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(69, 22);
            this.lblCorreo.TabIndex = 15;
            this.lblCorreo.Text = "Correo";
            this.lblCorreo.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(551, 117);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(156, 28);
            this.txtTelefono.TabIndex = 18;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(547, 92);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(84, 22);
            this.lblTelefono.TabIndex = 17;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.Location = new System.Drawing.Point(546, 248);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(74, 22);
            this.lblGenero.TabIndex = 19;
            this.lblGenero.Text = "Genero";
            // 
            // dateNacimiento
            // 
            this.dateNacimiento.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNacimiento.Location = new System.Drawing.Point(550, 350);
            this.dateNacimiento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateNacimiento.Name = "dateNacimiento";
            this.dateNacimiento.Size = new System.Drawing.Size(157, 28);
            this.dateNacimiento.TabIndex = 21;
            // 
            // lblNacimiento
            // 
            this.lblNacimiento.AutoSize = true;
            this.lblNacimiento.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNacimiento.Location = new System.Drawing.Point(546, 319);
            this.lblNacimiento.Name = "lblNacimiento";
            this.lblNacimiento.Size = new System.Drawing.Size(189, 22);
            this.lblNacimiento.TabIndex = 22;
            this.lblNacimiento.Text = "Fecha de Nacimiento";
            // 
            // cmbGenero
            // 
            this.cmbGenero.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Items.AddRange(new object[] {
            "Hombre",
            "Mujer",
            "Otro",
            "Ambos"});
            this.cmbGenero.Location = new System.Drawing.Point(549, 272);
            this.cmbGenero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(158, 29);
            this.cmbGenero.TabIndex = 23;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(71, 523);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(439, 117);
            this.txtDireccion.TabIndex = 24;
            this.txtDireccion.Text = "";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(532, 601);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(117, 39);
            this.btnGuardar.TabIndex = 25;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(703, 601);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(117, 39);
            this.btnRegresar.TabIndex = 26;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 33);
            this.label1.TabIndex = 27;
            this.label1.Text = "Registro Datos Personales";
            // 
            // PersonaNueva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(919, 673);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.cmbGenero);
            this.Controls.Add(this.lblNacimiento);
            this.Controls.Add(this.dateNacimiento);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.cmbEdad);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.txtApellido1);
            this.Controls.Add(this.lblApellido1);
            this.Controls.Add(this.txtApellido2);
            this.Controls.Add(this.lblApellido2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.lblCedula);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PersonaNueva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UsuarioNuevo";
            this.Load += new System.EventHandler(this.UsuarioNuevo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbEdad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtApellido2;
        private System.Windows.Forms.Label lblApellido2;
        private System.Windows.Forms.TextBox txtApellido1;
        private System.Windows.Forms.Label lblApellido1;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.NumericUpDown cmbEdad;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.DateTimePicker dateNacimiento;
        private System.Windows.Forms.Label lblNacimiento;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.RichTextBox txtDireccion;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label label1;
    }
}