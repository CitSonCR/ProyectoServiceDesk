namespace ProyectoServiceDesk_View.Forms
{
    partial class Nuevo_Equipo
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
            this.cboxDepartamento = new System.Windows.Forms.ComboBox();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboxDepartamento
            // 
            this.cboxDepartamento.FormattingEnabled = true;
            this.cboxDepartamento.Items.AddRange(new object[] {
            "Hombre",
            "Mujer",
            "Otro",
            "Ambos"});
            this.cboxDepartamento.Location = new System.Drawing.Point(101, 257);
            this.cboxDepartamento.Name = "cboxDepartamento";
            this.cboxDepartamento.Size = new System.Drawing.Size(131, 28);
            this.cboxDepartamento.TabIndex = 27;
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Location = new System.Drawing.Point(97, 218);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(112, 20);
            this.lblDepartamento.TabIndex = 26;
            this.lblDepartamento.Text = "Departamento";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(283, 129);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(325, 26);
            this.textBox2.TabIndex = 33;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(279, 97);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(92, 20);
            this.lblDescripcion.TabIndex = 32;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(645, 129);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(208, 26);
            this.txtTipo.TabIndex = 31;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(641, 97);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(135, 20);
            this.lblCodigo.TabIndex = 30;
            this.lblCodigo.Text = "Codigo de Equipo";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(101, 129);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(131, 26);
            this.txtNombre.TabIndex = 29;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(97, 97);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(65, 20);
            this.lblNombre.TabIndex = 28;
            this.lblNombre.Text = "Nombre";
            // 
            // Nuevo_Equipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 624);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.cboxDepartamento);
            this.Controls.Add(this.lblDepartamento);
            this.Name = "Nuevo_Equipo";
            this.Text = "Nuevo_Equipo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxDepartamento;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
    }
}