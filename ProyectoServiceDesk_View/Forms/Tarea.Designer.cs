namespace ProyectoServiceDesk_View.Forms
{
    partial class Tarea
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tarea));
            //this.dataSet1 = new ProyectoServiceDesk_View.DataSet1();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtSolicutud = new System.Windows.Forms.RichTextBox();
            this.lblSolicitud = new System.Windows.Forms.Label();
            this.txtdificultat = new System.Windows.Forms.TextBox();
            this.lblApellido1 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.lblApellido2 = new System.Windows.Forms.Label();
            this.txtHoras = new System.Windows.Forms.TextBox();
            this.lbltipo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtUsuarioA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.dateFechaAtencion = new System.Windows.Forms.DateTimePicker();
            //((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            //this.dataSet1.DataSetName = "DataSet1";
//            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1BindingSource
            // 
//            this.dataSet1BindingSource.DataSource = this.dataSet1;
  //          this.dataSet1BindingSource.Position = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(397, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 38);
            this.label1.TabIndex = 65;
            this.label1.Text = "Registro de Tarea";
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegresar.Image")));
            this.btnRegresar.Location = new System.Drawing.Point(48, 547);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(49, 49);
            this.btnRegresar.TabIndex = 64;
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
            this.btnGuardar.Location = new System.Drawing.Point(557, 547);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(73, 59);
            this.btnGuardar.TabIndex = 63;
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // txtSolicutud
            // 
            this.txtSolicutud.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSolicutud.Location = new System.Drawing.Point(693, 105);
            this.txtSolicutud.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSolicutud.Name = "txtSolicutud";
            this.txtSolicutud.Size = new System.Drawing.Size(357, 322);
            this.txtSolicutud.TabIndex = 62;
            this.txtSolicutud.Text = "";
            // 
            // lblSolicitud
            // 
            this.lblSolicitud.AutoSize = true;
            this.lblSolicitud.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolicitud.Location = new System.Drawing.Point(688, 72);
            this.lblSolicitud.Name = "lblSolicitud";
            this.lblSolicitud.Size = new System.Drawing.Size(94, 25);
            this.lblSolicitud.TabIndex = 61;
            this.lblSolicitud.Text = "Solicitud";
            // 
            // txtdificultat
            // 
            this.txtdificultat.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdificultat.Location = new System.Drawing.Point(117, 303);
            this.txtdificultat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdificultat.Name = "txtdificultat";
            this.txtdificultat.Size = new System.Drawing.Size(102, 32);
            this.txtdificultat.TabIndex = 58;
            // 
            // lblApellido1
            // 
            this.lblApellido1.AutoSize = true;
            this.lblApellido1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido1.Location = new System.Drawing.Point(112, 267);
            this.lblApellido1.Name = "lblApellido1";
            this.lblApellido1.Size = new System.Drawing.Size(101, 25);
            this.lblApellido1.TabIndex = 57;
            this.lblApellido1.Text = "Dificultad";
            // 
            // txtEstado
            // 
            this.txtEstado.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.Location = new System.Drawing.Point(117, 395);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(367, 32);
            this.txtEstado.TabIndex = 56;
            // 
            // lblApellido2
            // 
            this.lblApellido2.AutoSize = true;
            this.lblApellido2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido2.Location = new System.Drawing.Point(112, 356);
            this.lblApellido2.Name = "lblApellido2";
            this.lblApellido2.Size = new System.Drawing.Size(196, 25);
            this.lblApellido2.TabIndex = 55;
            this.lblApellido2.Text = "Proceso de estado";
            // 
            // txtHoras
            // 
            this.txtHoras.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoras.Location = new System.Drawing.Point(117, 201);
            this.txtHoras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.Size = new System.Drawing.Size(367, 32);
            this.txtHoras.TabIndex = 54;
            // 
            // lbltipo
            // 
            this.lbltipo.AutoSize = true;
            this.lbltipo.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltipo.Location = new System.Drawing.Point(112, 169);
            this.lbltipo.Name = "lbltipo";
            this.lbltipo.Size = new System.Drawing.Size(174, 25);
            this.lbltipo.TabIndex = 53;
            this.lbltipo.Text = "Tiempo en horas";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(117, 105);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(367, 32);
            this.txtNombre.TabIndex = 52;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(112, 72);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(90, 25);
            this.lblNombre.TabIndex = 51;
            this.lblNombre.Text = "Nombre";
            // 
            // txtUsuarioA
            // 
            this.txtUsuarioA.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioA.Location = new System.Drawing.Point(117, 497);
            this.txtUsuarioA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsuarioA.Name = "txtUsuarioA";
            this.txtUsuarioA.Size = new System.Drawing.Size(367, 32);
            this.txtUsuarioA.TabIndex = 67;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(112, 458);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 25);
            this.label2.TabIndex = 66;
            this.label2.Text = "Usuario que atiende";
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.Location = new System.Drawing.Point(288, 267);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(190, 25);
            this.lblfecha.TabIndex = 69;
            this.lblfecha.Text = "Fecha de Atencion";
            // 
            // dateFechaAtencion
            // 
            this.dateFechaAtencion.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFechaAtencion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFechaAtencion.Location = new System.Drawing.Point(293, 303);
            this.dateFechaAtencion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateFechaAtencion.Name = "dateFechaAtencion";
            this.dateFechaAtencion.Size = new System.Drawing.Size(176, 32);
            this.dateFechaAtencion.TabIndex = 68;
            // 
            // Tarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1099, 626);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.dateFechaAtencion);
            this.Controls.Add(this.txtUsuarioA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtSolicutud);
            this.Controls.Add(this.lblSolicitud);
            this.Controls.Add(this.txtdificultat);
            this.Controls.Add(this.lblApellido1);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.lblApellido2);
            this.Controls.Add(this.txtHoras);
            this.Controls.Add(this.lbltipo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tarea";
            this.Text = "Tarea";
            ////((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        //private DataSet1 dataSet1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.RichTextBox txtSolicutud;
        private System.Windows.Forms.Label lblSolicitud;
        private System.Windows.Forms.TextBox txtdificultat;
        private System.Windows.Forms.Label lblApellido1;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label lblApellido2;
        private System.Windows.Forms.TextBox txtHoras;
        private System.Windows.Forms.Label lbltipo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtUsuarioA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.DateTimePicker dateFechaAtencion;
    }
}