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
        public string UserName { get; set; }

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
            dtToDo.Columns.Add("LLAVE", typeof(int));

            dtDoing.Columns.Add("NOMBRE", typeof(string));
            dtDoing.Columns.Add("DIFICULTAD", typeof(int));
            dtDoing.Columns.Add("LLAVE", typeof(int));

            dtDone.Columns.Add("NOMBRE", typeof(string));
            dtDone.Columns.Add("DIFICULTAD", typeof(int));
            dtDone.Columns.Add("LLAVE", typeof(int));
        }
        private void IngresarFila(DataTable dt, string nombre, int dificultad, int llave)
        {
            DataRow dr = dt.NewRow();
            dr["NOMBRE"] = nombre; 
            dr["DIFICULTAD"] = dificultad;
            dr["LLAVE"] = llave;
            dt.Rows.Add(dr);
        }
        private void EliminarFila(DataTable dt, int index)
        {
            dt.Rows.RemoveAt(index);
        }
        private void LimpiarGrid()
        {
            dtgToDo.DataSource = null;
            dtgDoing.DataSource = null;
            dtgDone.DataSource = null;
            dtgToDo.Rows.Clear();
            dtgDoing.Rows.Clear();
            dtgDone.Rows.Clear();
        }
        private void AsignarTareasAGrid()
        {
            dtToDo.Clear();
            dtDoing.Clear();
            dtDone.Clear();
            DataTable dtTareas = logicaTarea.ObtenerInfoTareas(Convert.ToInt32(cmbSolicitud.SelectedValue.ToString()));
            foreach (DataRow row in dtTareas.Rows)
            {
                if (row[2].ToString().Equals("S"))
                {
                    IngresarFila(dtToDo, row[0].ToString(), Convert.ToInt32(row[1].ToString()), Convert.ToInt32(row[3].ToString()));
                }
                if (row[2].ToString().Equals("P"))
                {
                    IngresarFila(dtDoing, row[0].ToString(), Convert.ToInt32(row[1].ToString()), Convert.ToInt32(row[3].ToString()));
                }
                if (row[2].ToString().Equals("F"))
                {
                    IngresarFila(dtDone, row[0].ToString(), Convert.ToInt32(row[1].ToString()), Convert.ToInt32(row[3].ToString()));
                }
            }
            dtgToDo.DataSource = dtToDo;
            dtgDoing.DataSource = dtDoing;
            dtgDone.DataSource = dtDone;
        }
        private void btnMostrarTareas_Click(object sender, EventArgs e)
        {

            LimpiarGrid();
            if (string.IsNullOrEmpty(cmbSolicitud.Text))
            {
                MessageBox.Show("Debe escoger una solicitud para ver la informacion", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            AsignarTareasAGrid();
            dtgToDo.Columns[2].Visible = false;
            dtgDoing.Columns[2].Visible = false;
            dtgDone.Columns[2].Visible = false;
        }
        private void dtgToDo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dtAux = new DataTable();
            dtAux = dtDoing;            
            IngresarFila(dtAux, dtgToDo.Rows[e.RowIndex].Cells[0].Value.ToString(), Convert.ToInt32(dtgToDo.Rows[e.RowIndex].Cells[1].Value.ToString()), Convert.ToInt32(dtgToDo.Rows[e.RowIndex].Cells[2].Value.ToString()));
            dtDoing = dtAux;
            dtgDoing.DataSource = null;
            dtgDoing.Rows.Clear();
            dtgDoing.DataSource = dtDoing;
            dtgDoing.Columns[2].Visible = false;

            dtAux = dtToDo;
            EliminarFila(dtAux, e.RowIndex);
            dtToDo = dtAux;
            dtgToDo.DataSource = null;
            dtgToDo.Rows.Clear();
            dtgToDo.DataSource = dtToDo;
            dtgToDo.Columns[2].Visible = false;
        }
        private void dtgDone_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dtAux = new DataTable();
            dtAux = dtDoing;
            IngresarFila(dtAux, dtgDone.Rows[e.RowIndex].Cells[0].Value.ToString(), Convert.ToInt32(dtgDone.Rows[e.RowIndex].Cells[1].Value.ToString()), Convert.ToInt32(dtgDone.Rows[e.RowIndex].Cells[2].Value.ToString()));
            dtDoing = dtAux;
            dtgDoing.DataSource = null;
            dtgDoing.Rows.Clear();
            dtgDoing.DataSource = dtDoing;
            dtgDoing.Columns[2].Visible = false;

            dtAux = dtDone;
            EliminarFila(dtAux, e.RowIndex);
            dtDone = dtAux;
            dtgDone.DataSource = null;
            dtgDone.Rows.Clear();
            dtgDone.DataSource = dtDone;
            dtgDone.Columns[2].Visible = false;
        }
        private void EnProcesoASolicitud_Click(object sender, EventArgs e)
        {
            if (dtgDoing.RowCount > 0 )
            {
                int RowIndex = dtgDoing.CurrentCell.RowIndex;
                DataTable dtAux = new DataTable();
                dtAux = dtToDo;
                IngresarFila(dtAux, dtgDoing.Rows[RowIndex].Cells[0].Value.ToString(), Convert.ToInt32(dtgDoing.Rows[RowIndex].Cells[1].Value.ToString()), Convert.ToInt32(dtgDoing.Rows[RowIndex].Cells[2].Value.ToString()));
                dtToDo = dtAux;
                dtgToDo.DataSource = null;
                dtgToDo.Rows.Clear();
                dtgToDo.DataSource = dtToDo;
                dtgToDo.Columns[2].Visible = false;

                dtAux = dtDoing;
                EliminarFila(dtAux, RowIndex);
                dtDoing = dtAux;
                dtgDoing.DataSource = null;
                dtgDoing.Rows.Clear();
                dtgDoing.DataSource = dtDoing;
                dtgDoing.Columns[2].Visible = false;
            }
            else
                MessageBox.Show("No hay un registro para mover!!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void EnProcesoAFinalizado_Click(object sender, EventArgs e)
        {
            if (dtgDoing.RowCount > 0)
            {
                int RowIndex = dtgDoing.CurrentCell.RowIndex;
                DataTable dtAux = new DataTable();
                dtAux = dtDone;
                IngresarFila(dtAux, dtgDoing.Rows[RowIndex].Cells[0].Value.ToString(), Convert.ToInt32(dtgDoing.Rows[RowIndex].Cells[1].Value.ToString()), Convert.ToInt32(dtgDoing.Rows[RowIndex].Cells[2].Value.ToString()));
                dtDone = dtAux;
                dtgDone.DataSource = null;
                dtgDone.Rows.Clear();
                dtgDone.DataSource = dtDone;
                dtgDone.Columns[2].Visible = false;

                dtAux = dtDoing;
                EliminarFila(dtAux, RowIndex);
                dtDoing = dtAux;
                dtgDoing.DataSource = null;
                dtgDoing.Rows.Clear();
                dtgDoing.DataSource = dtDoing;
                dtgDoing.Columns[2].Visible = false;
            }
            else
                MessageBox.Show("No hay un registro para mover!!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataRow row in dtToDo.Rows)
                    logicaTarea.ActualizarEstadoTarea(Convert.ToInt32(row[2].ToString()), "S");
                foreach (DataRow row in dtDoing.Rows)
                    logicaTarea.ActualizarEstadoTarea(Convert.ToInt32(row[2].ToString()), "P");
                foreach (DataRow row in dtDone.Rows)
                    logicaTarea.ActualizarEstadoTarea(Convert.ToInt32(row[2].ToString()), "F");

                MessageBox.Show("Informacion actualizada de manera correcta!!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error inesperado " + ex.Message, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            this.Hide();
            inicio.UserNameTxt = UserName;
            inicio.ShowDialog();            
            this.Close();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (dtgToDo.RowCount > 0 || dtgDoing.RowCount > 0)
            {
                MessageBox.Show("No se puede finalizar la solicitud ya que existen tareas pendientes.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            foreach (DataRow row in dtDone.Rows)
                logicaTarea.ActualizarEstadoTarea(Convert.ToInt32(row[2].ToString()), "F");
            if (logicaSolicitud.ActualizarEstadoSolicitud(Convert.ToInt32(cmbSolicitud.SelectedValue.ToString()), "F"))
                MessageBox.Show("Solicitud actualizada de manera correcta", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Ha ocurrido un error al actualizar al finalizar la solicitud", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
