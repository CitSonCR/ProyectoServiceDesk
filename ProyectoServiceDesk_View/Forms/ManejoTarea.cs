using ProyectoServiceDesk_Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoServiceDesk_View.Forms
{
    public partial class ManejoTarea : Form
    {
        LogicaSolicitud logicaSolicitud = new LogicaSolicitud();
        LogicaTarea logicaTarea = new LogicaTarea();
        DataTable dtToDo = new DataTable();
        DataTable dtDoing = new DataTable();
        DataTable dtDone = new DataTable();

        public ManejoTarea()
        {
            InitializeComponent();
            cmbSolicitud.ValueMember = "PSD_SOLICITUD_ID";
            cmbSolicitud.DisplayMember = "TITULO";
            cmbSolicitud.DataSource = logicaSolicitud.ObtenerInfoSolicitud();
            CrearDataTable();
        }
        private void CrearDataTable()
        {
            dtToDo.Columns.Add("NOMBRE",typeof(string));
            dtToDo.Columns.Add("DIFICULTAD", typeof(int));

            dtDoing.Columns.Add("NOMBRE", typeof(string));
            dtDoing.Columns.Add("DIFICULTAD", typeof(int));

            dtDone.Columns.Add("NOMBRE", typeof(string));
            dtDone.Columns.Add("DIFICULTAD", typeof(int));
        }
        private void IngresarFila(DataTable dt, string nombre, int dificultad)
        {
            DataRow dr = dt.NewRow();
            dr["NOMBRE"] = nombre; 
            dr["DIFICULTAD"] = dificultad; 
            dt.Rows.Add(dr);
        }
        private void AsignarTareasAGrid()
        {

            DataTable dtTareas = logicaTarea.ObtenerInfoTareas(Convert.ToInt32(cmbSolicitud.SelectedValue.ToString()));
            foreach (DataRow row in dtTareas.Rows)
            {
                if (row[2].ToString().Equals("S"))
                {
                    IngresarFila(dtToDo, row[0].ToString(), Convert.ToInt32(row[1].ToString()));
                }
                if (row[2].ToString().Equals("P"))
                {
                    IngresarFila(dtDoing, row[0].ToString(), Convert.ToInt32(row[1].ToString()));
                }
                if (row[2].ToString().Equals("F"))
                {
                    IngresarFila(dtDone, row[0].ToString(), Convert.ToInt32(row[1].ToString()));
                }
            }
            dtgToDo.DataSource = dtToDo;
            dtgDoing.DataSource = dtDoing;
            dtgDone.DataSource = dtDone;
        }
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgDoing_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnMostrarTareas_Click(object sender, EventArgs e)
        {
            dtgToDo.Rows.Clear();
            dtgToDo.DataSource = null;
            dtgDoing.Rows.Clear();
            dtgDoing.DataSource = null;
            dtgDone.Rows.Clear();
            dtgDone.DataSource = null;
            if (string.IsNullOrEmpty(cmbSolicitud.Text))
            {
                MessageBox.Show("Debe escoger una solicitud para ver la informacion", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            AsignarTareasAGrid();
        }
    }
}
