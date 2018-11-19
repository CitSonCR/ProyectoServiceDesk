namespace ProyectoServiceDesk_View.Forms
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.btnEquipo = new System.Windows.Forms.Button();
            this.btnDepartamento = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.departamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEquipo
            // 
            this.btnEquipo.Image = ((System.Drawing.Image)(resources.GetObject("btnEquipo.Image")));
            this.btnEquipo.Location = new System.Drawing.Point(116, 117);
            this.btnEquipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEquipo.Name = "btnEquipo";
            this.btnEquipo.Size = new System.Drawing.Size(182, 159);
            this.btnEquipo.TabIndex = 2;
            this.btnEquipo.Text = "Nuevo Equipo";
            this.btnEquipo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEquipo.UseVisualStyleBackColor = true;
            this.btnEquipo.Click += new System.EventHandler(this.btnEquipo_Click);
            // 
            // btnDepartamento
            // 
            this.btnDepartamento.Location = new System.Drawing.Point(294, 117);
            this.btnDepartamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDepartamento.Name = "btnDepartamento";
            this.btnDepartamento.Size = new System.Drawing.Size(182, 159);
            this.btnDepartamento.TabIndex = 3;
            this.btnDepartamento.Text = "Nuevo Departamento";
            this.btnDepartamento.UseVisualStyleBackColor = true;
            this.btnDepartamento.Click += new System.EventHandler(this.btnDepartamento_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.departamentoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(896, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // departamentoToolStripMenuItem
            // 
            this.departamentoToolStripMenuItem.Name = "departamentoToolStripMenuItem";
            this.departamentoToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.departamentoToolStripMenuItem.Text = "Departamento";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 486);
            this.Controls.Add(this.btnDepartamento);
            this.Controls.Add(this.btnEquipo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEquipo;
        private System.Windows.Forms.Button btnDepartamento;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem departamentoToolStripMenuItem;
    }
}