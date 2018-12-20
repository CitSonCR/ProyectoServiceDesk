namespace ProyectoServiceDesk_View.Forms
{
    partial class ManejoTarea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManejoTarea));
            this.dtgToDo = new System.Windows.Forms.DataGridView();
            this.dtgDoing = new System.Windows.Forms.DataGridView();
            this.dtgDone = new System.Windows.Forms.DataGridView();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSolicitud = new System.Windows.Forms.ComboBox();
            this.btnMostrarTareas = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.EnProcesoASolicitud = new System.Windows.Forms.Button();
            this.EnProcesoAFinalizado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgToDo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDoing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDone)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgToDo
            // 
            this.dtgToDo.AllowUserToAddRows = false;
            this.dtgToDo.AllowUserToDeleteRows = false;
            this.dtgToDo.AllowUserToResizeColumns = false;
            this.dtgToDo.AllowUserToResizeRows = false;
            this.dtgToDo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgToDo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgToDo.Location = new System.Drawing.Point(12, 161);
            this.dtgToDo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgToDo.Name = "dtgToDo";
            this.dtgToDo.ReadOnly = true;
            this.dtgToDo.RowTemplate.Height = 28;
            this.dtgToDo.Size = new System.Drawing.Size(279, 330);
            this.dtgToDo.TabIndex = 1;
            this.dtgToDo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgToDo_CellContentClick);
            // 
            // dtgDoing
            // 
            this.dtgDoing.AllowUserToAddRows = false;
            this.dtgDoing.AllowUserToDeleteRows = false;
            this.dtgDoing.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgDoing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDoing.Location = new System.Drawing.Point(374, 161);
            this.dtgDoing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgDoing.Name = "dtgDoing";
            this.dtgDoing.ReadOnly = true;
            this.dtgDoing.RowTemplate.Height = 28;
            this.dtgDoing.Size = new System.Drawing.Size(279, 330);
            this.dtgDoing.TabIndex = 2;
            // 
            // dtgDone
            // 
            this.dtgDone.AllowUserToAddRows = false;
            this.dtgDone.AllowUserToDeleteRows = false;
            this.dtgDone.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgDone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDone.Location = new System.Drawing.Point(732, 161);
            this.dtgDone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgDone.Name = "dtgDone";
            this.dtgDone.ReadOnly = true;
            this.dtgDone.RowTemplate.Height = 28;
            this.dtgDone.Size = new System.Drawing.Size(288, 330);
            this.dtgDone.TabIndex = 3;
            this.dtgDone.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDone_CellContentClick);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Font = new System.Drawing.Font("Arial", 10.8F);
            this.btnFinalizar.Location = new System.Drawing.Point(782, 513);
            this.btnFinalizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(225, 50);
            this.btnFinalizar.TabIndex = 66;
            this.btnFinalizar.Text = "Finalizar Solicitud";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(407, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 33);
            this.label1.TabIndex = 67;
            this.label1.Text = "Manejo de tareas";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 580);
            this.splitter1.TabIndex = 69;
            this.splitter1.TabStop = false;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegresar.Image")));
            this.btnRegresar.Location = new System.Drawing.Point(22, 524);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(44, 39);
            this.btnRegresar.TabIndex = 65;
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 74;
            this.label2.Text = "Solicitud";
            // 
            // cmbSolicitud
            // 
            this.cmbSolicitud.FormattingEnabled = true;
            this.cmbSolicitud.Location = new System.Drawing.Point(124, 72);
            this.cmbSolicitud.Name = "cmbSolicitud";
            this.cmbSolicitud.Size = new System.Drawing.Size(167, 24);
            this.cmbSolicitud.TabIndex = 75;
            // 
            // btnMostrarTareas
            // 
            this.btnMostrarTareas.Location = new System.Drawing.Point(314, 67);
            this.btnMostrarTareas.Name = "btnMostrarTareas";
            this.btnMostrarTareas.Size = new System.Drawing.Size(131, 31);
            this.btnMostrarTareas.TabIndex = 76;
            this.btnMostrarTareas.Text = "Mostrar tareas";
            this.btnMostrarTareas.UseVisualStyleBackColor = true;
            this.btnMostrarTareas.Click += new System.EventHandler(this.btnMostrarTareas_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.AccessibleDescription = "Guardar";
            this.btnGuardar.AccessibleName = "Guardar";
            this.btnGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuardar.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(689, 515);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(65, 47);
            this.btnGuardar.TabIndex = 77;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(89, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 29);
            this.label3.TabIndex = 78;
            this.label3.Text = "En Solicitud";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(797, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 29);
            this.label4.TabIndex = 79;
            this.label4.Text = "Finalizado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(437, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 29);
            this.label5.TabIndex = 80;
            this.label5.Text = "En Proceso";
            // 
            // EnProcesoASolicitud
            // 
            this.EnProcesoASolicitud.Image = ((System.Drawing.Image)(resources.GetObject("EnProcesoASolicitud.Image")));
            this.EnProcesoASolicitud.Location = new System.Drawing.Point(293, 265);
            this.EnProcesoASolicitud.Name = "EnProcesoASolicitud";
            this.EnProcesoASolicitud.Size = new System.Drawing.Size(75, 35);
            this.EnProcesoASolicitud.TabIndex = 81;
            this.EnProcesoASolicitud.UseVisualStyleBackColor = true;
            this.EnProcesoASolicitud.Click += new System.EventHandler(this.EnProcesoASolicitud_Click);
            // 
            // EnProcesoAFinalizado
            // 
            this.EnProcesoAFinalizado.Image = ((System.Drawing.Image)(resources.GetObject("EnProcesoAFinalizado.Image")));
            this.EnProcesoAFinalizado.Location = new System.Drawing.Point(655, 265);
            this.EnProcesoAFinalizado.Name = "EnProcesoAFinalizado";
            this.EnProcesoAFinalizado.Size = new System.Drawing.Size(75, 35);
            this.EnProcesoAFinalizado.TabIndex = 82;
            this.EnProcesoAFinalizado.UseVisualStyleBackColor = true;
            this.EnProcesoAFinalizado.Click += new System.EventHandler(this.EnProcesoAFinalizado_Click);
            // 
            // ManejoTarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1032, 580);
            this.Controls.Add(this.EnProcesoAFinalizado);
            this.Controls.Add(this.EnProcesoASolicitud);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnMostrarTareas);
            this.Controls.Add(this.cmbSolicitud);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.dtgDone);
            this.Controls.Add(this.dtgDoing);
            this.Controls.Add(this.dtgToDo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ManejoTarea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManejoTarea";
            ((System.ComponentModel.ISupportInitialize)(this.dtgToDo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDoing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgToDo;
        private System.Windows.Forms.DataGridView dtgDoing;
        private System.Windows.Forms.DataGridView dtgDone;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSolicitud;
        private System.Windows.Forms.Button btnMostrarTareas;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button EnProcesoASolicitud;
        private System.Windows.Forms.Button EnProcesoAFinalizado;
    }
}