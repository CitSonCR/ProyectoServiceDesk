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
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgDoing = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgDone = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnAvanzarTareaDone = new System.Windows.Forms.Button();
            this.btnRetrocederTareaDoing = new System.Windows.Forms.Button();
            this.btnRetrocederTareaToDo = new System.Windows.Forms.Button();
            this.btnAvanzarTareaDoing = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgToDo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDoing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDone)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgToDo
            // 
            this.dtgToDo.AllowUserToAddRows = false;
            this.dtgToDo.AllowUserToDeleteRows = false;
            this.dtgToDo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgToDo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dtgToDo.Location = new System.Drawing.Point(15, 50);
            this.dtgToDo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgToDo.Name = "dtgToDo";
            this.dtgToDo.ReadOnly = true;
            this.dtgToDo.RowTemplate.Height = 28;
            this.dtgToDo.Size = new System.Drawing.Size(268, 358);
            this.dtgToDo.TabIndex = 1;
            this.dtgToDo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 260;
            // 
            // dtgDoing
            // 
            this.dtgDoing.AllowUserToAddRows = false;
            this.dtgDoing.AllowUserToDeleteRows = false;
            this.dtgDoing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDoing.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dtgDoing.Location = new System.Drawing.Point(375, 50);
            this.dtgDoing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgDoing.Name = "dtgDoing";
            this.dtgDoing.ReadOnly = true;
            this.dtgDoing.RowTemplate.Height = 28;
            this.dtgDoing.Size = new System.Drawing.Size(267, 358);
            this.dtgDoing.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 260;
            // 
            // dtgDone
            // 
            this.dtgDone.AllowUserToAddRows = false;
            this.dtgDone.AllowUserToDeleteRows = false;
            this.dtgDone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDone.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            this.dtgDone.Location = new System.Drawing.Point(724, 50);
            this.dtgDone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgDone.Name = "dtgDone";
            this.dtgDone.ReadOnly = true;
            this.dtgDone.RowTemplate.Height = 28;
            this.dtgDone.Size = new System.Drawing.Size(267, 358);
            this.dtgDone.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 260;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Font = new System.Drawing.Font("Arial", 10.8F);
            this.btnFinalizar.Location = new System.Drawing.Point(740, 439);
            this.btnFinalizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(225, 50);
            this.btnFinalizar.TabIndex = 66;
            this.btnFinalizar.Text = "Finalizar Solicitud";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(371, 7);
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
            this.splitter1.Size = new System.Drawing.Size(3, 499);
            this.splitter1.TabIndex = 69;
            this.splitter1.TabStop = false;
            // 
            // btnAvanzarTareaDone
            // 
            this.btnAvanzarTareaDone.Image = global::ProyectoServiceDesk_View.Properties.Resources.right_arrow_1_;
            this.btnAvanzarTareaDone.Location = new System.Drawing.Point(646, 172);
            this.btnAvanzarTareaDone.Name = "btnAvanzarTareaDone";
            this.btnAvanzarTareaDone.Size = new System.Drawing.Size(75, 53);
            this.btnAvanzarTareaDone.TabIndex = 71;
            this.btnAvanzarTareaDone.UseVisualStyleBackColor = true;
            // 
            // btnRetrocederTareaDoing
            // 
            this.btnRetrocederTareaDoing.Image = global::ProyectoServiceDesk_View.Properties.Resources.left_arrow_1_;
            this.btnRetrocederTareaDoing.Location = new System.Drawing.Point(646, 231);
            this.btnRetrocederTareaDoing.Name = "btnRetrocederTareaDoing";
            this.btnRetrocederTareaDoing.Size = new System.Drawing.Size(75, 53);
            this.btnRetrocederTareaDoing.TabIndex = 72;
            this.btnRetrocederTareaDoing.UseVisualStyleBackColor = true;
            // 
            // btnRetrocederTareaToDo
            // 
            this.btnRetrocederTareaToDo.Image = global::ProyectoServiceDesk_View.Properties.Resources.left_arrow_1_;
            this.btnRetrocederTareaToDo.Location = new System.Drawing.Point(294, 231);
            this.btnRetrocederTareaToDo.Name = "btnRetrocederTareaToDo";
            this.btnRetrocederTareaToDo.Size = new System.Drawing.Size(75, 53);
            this.btnRetrocederTareaToDo.TabIndex = 73;
            this.btnRetrocederTareaToDo.UseVisualStyleBackColor = true;
            // 
            // btnAvanzarTareaDoing
            // 
            this.btnAvanzarTareaDoing.Image = global::ProyectoServiceDesk_View.Properties.Resources.right_arrow_1_;
            this.btnAvanzarTareaDoing.Location = new System.Drawing.Point(292, 172);
            this.btnAvanzarTareaDoing.Name = "btnAvanzarTareaDoing";
            this.btnAvanzarTareaDoing.Size = new System.Drawing.Size(75, 53);
            this.btnAvanzarTareaDoing.TabIndex = 70;
            this.btnAvanzarTareaDoing.UseVisualStyleBackColor = true;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegresar.Image")));
            this.btnRegresar.Location = new System.Drawing.Point(22, 450);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(44, 39);
            this.btnRegresar.TabIndex = 65;
            this.btnRegresar.UseVisualStyleBackColor = true;
            // 
            // ManejoTarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1004, 499);
            this.Controls.Add(this.btnRetrocederTareaToDo);
            this.Controls.Add(this.btnRetrocederTareaDoing);
            this.Controls.Add(this.btnAvanzarTareaDone);
            this.Controls.Add(this.btnAvanzarTareaDoing);
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
            this.Text = "ManejoTarea";
            ((System.ComponentModel.ISupportInitialize)(this.dtgToDo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDoing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgToDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView dtgDoing;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dtgDone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button btnAvanzarTareaDoing;
        private System.Windows.Forms.Button btnAvanzarTareaDone;
        private System.Windows.Forms.Button btnRetrocederTareaDoing;
        private System.Windows.Forms.Button btnRetrocederTareaToDo;
    }
}