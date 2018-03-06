using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Aero_Negocio;
using Npgsql;
using Data_Base;

namespace Pagina_Principal
{
    public partial class crud_aeropuertos : Form
    {      
        Conexio_BaseDatos bd = new Conexio_BaseDatos();
        DB_Aeropuertos aero = new DB_Aeropuertos();
        aeropuerto neAero = new aeropuerto();
        int row = 0;
        int idViejo;
        string eventoMouse;
        public crud_aeropuertos()
        {
            InitializeComponent();
           
         
            dataGridView1.MouseClick += new MouseEventHandler(dataGridView1_MouseClick);
            //dataGridView1.CellClick += DataGridView1_CellClick1;
            dataGridView1.CellValueChanged -= new DataGridViewCellEventHandler(dataGridView1_CellValueChanged);
            lo.Items.Clear();
            aero.MostrarDatosCombo(lo);     
            
        }

        void dataGridView1_MouseClick(object Sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //MessageBox.Show("LEFT");
                if (dataGridView1.CurrentRow.Cells[0].Value == null)
                {
                   
                    return;
                }
                else
                {              
                    dataGridView1[dataGridView1.CurrentCell.ColumnIndex, dataGridView1.CurrentCell.RowIndex].ReadOnly = false;
                    
    
                }
            }
            else
            {
                ContextMenuStrip menu = new System.Windows.Forms.ContextMenuStrip();
                int posicionMouse = dataGridView1.HitTest(e.X, e.Y).RowIndex;

                // MessageBox.Show("RIGHT");

                if (posicionMouse >= 0)
                {
                    menu.Items.Add("AGREGAR").Name = "AGREGAR";
                    menu.Items.Add("MODIFICAR").Name = "MODIFICAR";
                    menu.Items.Add("ELIMINAR").Name = "ELIMINAR";
                }
                menu.Show(dataGridView1, new Point(e.X, e.Y));

                //event menu click

                menu.ItemClicked += new ToolStripItemClickedEventHandler(menu_Item_Clicked);

            }

        }


        void menu_Item_Clicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name.ToString())
            {
                case "AGREGAR":
                    //dataGridView1.
                   
                    dataGridView1.Rows.Clear();
               
                    aero.MostrarDatosCombo(lo);
                    eventoMouse = "Agre";
                    //dataGridView1[dataGridView1.CurrentCell.ColumnIndex, dataGridView1.CurrentCell.RowIndex].ReadOnly = false;
                    dataGridView1.CellValueChanged += new DataGridViewCellEventHandler(dataGridView1_CellValueChanged);             
                    

                    //combo.SelectedItem = "";
                    //ComboBox combo = sender as ComboBox;
                    //aero.MostrarDatosTabla(dataGridView1,combo);
                    break;
                case "MODIFICAR":
                   
                    if (MessageBox.Show("Desea modificar la Información de " + dataGridView1.CurrentRow.Cells[1].Value.ToString(), "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        eventoMouse = "modi";
                        idViejo = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                        dataGridView1.CellValueChanged += new DataGridViewCellEventHandler(dataGridView1_CellValueChanged);
                        dataGridView1[dataGridView1.CurrentCell.ColumnIndex, dataGridView1.CurrentCell.RowIndex].ReadOnly = false;
                        
                        //ComboBox combos = sender as ComboBox;
                        //aero.MostrarDatosTabla(dataGridView1, combos);
                    }

                    break;
                case "ELIMINAR":
                    dataGridView1.CellValueChanged -= new DataGridViewCellEventHandler(dataGridView1_CellValueChanged);
                    eliminarAero();                   
                    break;
            }

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
                row = dataGridView1.Rows.Count - 1;
                string localidad = null;
                DataGridViewComboBoxCell combo = null;
            
            try
                {
                    combo = dataGridView1.CurrentRow.Cells[2] as DataGridViewComboBoxCell;
                    localidad = Convert.ToString(combo.Value);
                    if (dataGridView1.CurrentRow.Cells[0].Value == null || dataGridView1.CurrentRow.Cells[1].Value == null || dataGridView1.CurrentRow.Cells[3].Value == null || localidad == null)
                    {
                        return;
                    }
                    else
                    {
                        int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                        string nombre = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                        string iata = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    if (eventoMouse == "Agre")
                    {
                        aero.agregarAeropuerto(id, nombre, localidad, iata);
                        row++;
                    }else if (eventoMouse == "modi")
                    {
                        modificarAero();
                    }                  
                    }
                }
                catch (Exception er)

                {
                MessageBox.Show("Hubo un error " + er);
            }
            
        }

        public void eliminarAero()
        {
            try
            {

                if (MessageBox.Show("Desea Eliminar la Información de " + dataGridView1.CurrentRow.Cells[1].Value.ToString(), "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    neAero.EliminarAro("DELETE FROM aeropuertos WHERE id = '" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'");
                    MessageBox.Show("Se ha eliminado Correctamente!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.Rows.Clear();
                    //aero.MostrarDatosTabla(dataGridView1, lo);
                }
                else
                {
                    return;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Hubo un error "+ e);

            }
        }
        public void modificarAero()
        {
            string locali = null;
            DataGridViewComboBoxCell combo = null;
            try
            {
                combo = dataGridView1.CurrentRow.Cells[2] as DataGridViewComboBoxCell;
                locali = Convert.ToString(combo.Value);
                int nuevoCodi = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                string nombre = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                string iata = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                aero.ModificarAeropuerto(idViejo, nuevoCodi, nombre, locali, iata);
                dataGridView1.Rows.Clear();

                //cargar tabla falta
            }
            catch (Exception e)
            {
                MessageBox.Show("Hubo un error " + e);
            }
        }

        private void crud_aeropuertos_Load(object sender, EventArgs e)
        {
            //ComboBox combo = sender as ComboBox;
            aero.MostrarDatosTabla(dataGridView1);
            
        }

        //private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        //{
        //    ComboBox combo = e.Control as ComboBox;
        //    combo.SelectedItem = "";
        //}

        public void cargarCombo(object sender)
        {
        
        }


        //void combo_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //   
        //    //dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["lo"].Value.ToString()
        //    locali = combo.SelectedItem.ToString();
        //    MessageBox.Show(codigo + nombre + locali + iata);
        //}

        //private void dataGridView1_EditingControlShowing_1(object sender, DataGridViewEditingControlShowingEventArgs e)
        //{
        //    if (dataGridView1.CurrentCell.ColumnIndex == 3 && e.Control is ComboBox)
        //    {
        //        ComboBox combo = e.Control as ComboBox;
        //        if (combo != null)
        //        {
        //            combo.SelectedIndexChanged -= new EventHandler(combo_SelectedIndexChanged);
        //            combo.SelectedIndexChanged += new EventHandler(combo_SelectedIndexChanged);
        //        }
        //    }
        //}
        
        //private void dataGridView1_Enter(object sender, EventArgs e)
        //{

        //}

        //private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyData == Keys.Enter)
        //    {
        //        //int col = dataGridView1.CurrentCell.ColumnIndex;
        //        //int row = dataGridView1.CurrentCell.RowIndex;
        //        //if (col < dataGridView1.ColumnCount - 1)
        //        //{
        //        //    col++;
        //        //}
        //        //else
        //        //{
        //        //    col = 0;
        //        //    row++;
        //        //}
        //        //if (row == dataGridView1.RowCount)
        //        //{
        //        //    dataGridView1.Rows.Add();
        //        //    dataGridView1.CurrentCell = dataGridView1[col, row];
        //        //    e.Handled = true;
        //        //}


        //    }
        //}
        //public void CargarGrid()
        //{

        //    Conexio_BaseDatos conex = new Conexio_BaseDatos();
        //    conex.Conexion();
        //    DataSet dataSet = new DataSet();
        //    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT id, nombre,localidad,iata FROM aeropuertos",conexion);
        //    adapter.Fill(dataSet, "aeropuertos");
        //    dataGridView1.DataSource = dataSet.Tables[0];
        //    //dtgEstudiantes.Columns[0].HeaderCell.Value = "CÉDULA";
        //    //dtgEstudiantes.Columns[1].HeaderCell.Value = "NOMBRE";
        //    //dtgEstudiantes.Columns[2].HeaderCell.Value = "CÉDULA";
        //    //dtgEstudiantes.Columns[3].HeaderCell.Value = "COMENTARIO";
        //    conexion.Close();

        //}
    }
}

    


