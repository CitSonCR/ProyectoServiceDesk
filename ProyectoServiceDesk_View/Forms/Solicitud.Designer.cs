namespace ProyectoServiceDesk_View.Forms
{
    partial class Solicitud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Solicitud));
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtSolucion = new System.Windows.Forms.RichTextBox();
            this.lblSolucion = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblApellido1 = new System.Windows.Forms.Label();
            this.lblApellido2 = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.lbltipo = new System.Windows.Forms.Label();
            this.txttitulo = new System.Windows.Forms.TextBox();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.dateFechaAtencion = new System.Windows.Forms.DateTimePicker();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listViewTareas = new System.Windows.Forms.ListView();
            this.lbllista = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.cmbPrioridad = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegresar.Image")));
            this.btnRegresar.Location = new System.Drawing.Point(28, 524);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(44, 39);
            this.btnRegresar.TabIndex = 10;
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.AccessibleDescription = "Guardar";
            this.btnGuardar.AccessibleName = "Guardar";
            this.btnGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuardar.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(502, 516);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(65, 47);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtSolucion
            // 
            this.txtSolucion.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSolucion.Location = new System.Drawing.Point(615, 84);
            this.txtSolucion.Name = "txtSolucion";
            this.txtSolucion.Size = new System.Drawing.Size(327, 123);
            this.txtSolucion.TabIndex = 6;
            this.txtSolucion.Text = "";
            // 
            // lblSolucion
            // 
            this.lblSolucion.AutoSize = true;
            this.lblSolucion.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolucion.Location = new System.Drawing.Point(611, 58);
            this.lblSolucion.Name = "lblSolucion";
            this.lblSolucion.Size = new System.Drawing.Size(83, 22);
            this.lblSolucion.TabIndex = 41;
            this.lblSolucion.Text = "Solucion";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(99, 205);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(86, 22);
            this.lblCorreo.TabIndex = 39;
            this.lblCorreo.Text = "Prioridad";
            // 
            // lblApellido1
            // 
            this.lblApellido1.AutoSize = true;
            this.lblApellido1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido1.Location = new System.Drawing.Point(99, 363);
            this.lblApellido1.Name = "lblApellido1";
            this.lblApellido1.Size = new System.Drawing.Size(69, 22);
            this.lblApellido1.TabIndex = 34;
            this.lblApellido1.Text = "Detalle";
            // 
            // lblApellido2
            // 
            this.lblApellido2.AutoSize = true;
            this.lblApellido2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido2.Location = new System.Drawing.Point(99, 285);
            this.lblApellido2.Name = "lblApellido2";
            this.lblApellido2.Size = new System.Drawing.Size(70, 22);
            this.lblApellido2.TabIndex = 32;
            this.lblApellido2.Text = "Estado";
            // 
            // txtTipo
            // 
            this.txtTipo.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipo.Location = new System.Drawing.Point(103, 161);
            this.txtTipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTipo.MaxLength = 10;
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(327, 28);
            this.txtTipo.TabIndex = 1;
            // 
            // lbltipo
            // 
            this.lbltipo.AutoSize = true;
            this.lbltipo.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltipo.Location = new System.Drawing.Point(99, 135);
            this.lbltipo.Name = "lbltipo";
            this.lbltipo.Size = new System.Drawing.Size(47, 22);
            this.lbltipo.TabIndex = 30;
            this.lbltipo.Text = "Tipo";
            // 
            // txttitulo
            // 
            this.txttitulo.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttitulo.Location = new System.Drawing.Point(103, 84);
            this.txttitulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttitulo.MaxLength = 10;
            this.txttitulo.Name = "txttitulo";
            this.txttitulo.Size = new System.Drawing.Size(327, 28);
            this.txttitulo.TabIndex = 0;
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(99, 58);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(55, 22);
            this.lbltitulo.TabIndex = 28;
            this.lbltitulo.Text = "Titulo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(380, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 33);
            this.label1.TabIndex = 50;
            this.label1.Text = "Registro de Solicitud";
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.Location = new System.Drawing.Point(218, 205);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(158, 22);
            this.lblfecha.TabIndex = 71;
            this.lblfecha.Text = "Fecha de ingreso";
            // 
            // dateFechaAtencion
            // 
            this.dateFechaAtencion.CustomFormat = "dd/mm/yyyy";
            this.dateFechaAtencion.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFechaAtencion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFechaAtencion.Location = new System.Drawing.Point(223, 242);
            this.dateFechaAtencion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateFechaAtencion.Name = "dateFechaAtencion";
            this.dateFechaAtencion.Size = new System.Drawing.Size(157, 28);
            this.dateFechaAtencion.TabIndex = 3;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(615, 260);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(327, 28);
            this.txtUsuario.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(611, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 22);
            this.label2.TabIndex = 72;
            this.label2.Text = "Usuario";
            // 
            // listViewTareas
            // 
            this.listViewTareas.Location = new System.Drawing.Point(615, 388);
            this.listViewTareas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewTareas.Name = "listViewTareas";
            this.listViewTareas.Size = new System.Drawing.Size(327, 175);
            this.listViewTareas.TabIndex = 8;
            this.listViewTareas.UseCompatibleStateImageBehavior = false;
            // 
            // lbllista
            // 
            this.lbllista.AutoSize = true;
            this.lbllista.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllista.Location = new System.Drawing.Point(611, 348);
            this.lbllista.Name = "lbllista";
            this.lbllista.Size = new System.Drawing.Size(139, 22);
            this.lbllista.TabIndex = 75;
            this.lbllista.Text = "Lista de Tareas";
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(104, 319);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(326, 24);
            this.cmbEstado.TabIndex = 4;
            // 
            // cmbPrioridad
            // 
            this.cmbPrioridad.FormattingEnabled = true;
            this.cmbPrioridad.Location = new System.Drawing.Point(104, 242);
            this.cmbPrioridad.Name = "cmbPrioridad";
            this.cmbPrioridad.Size = new System.Drawing.Size(102, 24);
            this.cmbPrioridad.TabIndex = 2;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(104, 388);
            this.richTextBox1.MaxLength = 100;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(326, 175);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // Solicitud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1058, 594);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.cmbPrioridad);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.lbllista);
            this.Controls.Add(this.listViewTareas);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.dateFechaAtencion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtSolucion);
            this.Controls.Add(this.lblSolucion);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblApellido1);
            this.Controls.Add(this.lblApellido2);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.lbltipo);
            this.Controls.Add(this.txttitulo);
            this.Controls.Add(this.lbltitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Solicitud";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solicitud";
            this.Load += new System.EventHandler(this.Solicitud_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.RichTextBox txtSolucion;
        private System.Windows.Forms.Label lblSolucion;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblApellido1;
        private System.Windows.Forms.Label lblApellido2;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label lbltipo;
        private System.Windows.Forms.TextBox txttitulo;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.DateTimePicker dateFechaAtencion;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listViewTareas;
        private System.Windows.Forms.Label lbllista;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.ComboBox cmbPrioridad;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}