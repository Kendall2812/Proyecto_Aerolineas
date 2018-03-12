using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aero_Negocio;

namespace Pagina_Principal
{
    public partial class crud_Vehiculos : Form
    {
        Vehiculo carro = new Vehiculo();
        DataSet infoCarros = new DataSet();

        public crud_Vehiculos()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Metodo Para Registrar la del Vehiculo Informacion 
        /// </summary>
        public void guardarVehiculo()
        {
            carro.InsertarCarro(txtPlaca.Text, txtMarca.Text, txtModelo.Text, txtEstilo.Text, txtPrecio.Text, numericCantidadVehiclo.Value.ToString());
        }
        /// <summary>
        /// Metodos para la edicion de la informacion de los vehiculos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        public void cargarInfoVehicuDataG()
        {
            infoCarros.Clear();
            infoCarros = carro.cargarDataGriedView();
            dataGridView1.DataSource = infoCarros.Tables[0];
            dataGridView1.Columns[0].Width = 115;
            dataGridView1.Columns[1].Width = 115;
            dataGridView1.Columns[2].Width = 115;
            dataGridView1.Columns[3].Width = 115;
            dataGridView1.Columns[4].Width = 115;
            dataGridView1.Columns[5].Width = 115;

            dataGridView1.Columns[0].HeaderCell.Value = "Placa";
            dataGridView1.Columns[1].HeaderCell.Value = "Marca";
            dataGridView1.Columns[2].HeaderCell.Value = "Modelo";
            dataGridView1.Columns[3].HeaderCell.Value = "Capacidad";
            dataGridView1.Columns[4].HeaderCell.Value = "Precio";
            dataGridView1.Columns[5].HeaderCell.Value = "Cantidad";
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                cargarInfoVehicuDataG();
            }
        }

        public void mostrarInfo()
        {
            Int32 numero = dataGridView1.GetCellCount(DataGridViewElementStates.Selected);
            if (numero == 6)
            {
                txtPlaca2.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells[0].Value);
                txtMarca2.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells[1].Value);
                txtModelo2.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells[2].Value);
                txtEstilo2.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells[3].Value);
                txtPrecio2.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells[4].Value);
                numericCantidad2.Value = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[5].Value); 
            }
            else
            {
                MessageBox.Show("Debe seleccionar toda la fila para editar la informacion. ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void guardarInfoEditada()
        {
            carro.ModificarCarro(txtPlaca2.Text, txtMarca2.Text, txtModelo2.Text, txtEstilo2.Text, txtPrecio2.Text, numericCantidad2.Value.ToString());
            txtPlaca2.Visible = false;
            txtMarca2.Visible = false;
            txtModelo2.Visible = false;
            txtEstilo2.Visible = false;
            txtPrecio2.Visible = false;
            numericCantidad2.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            btnModificar.Enabled = true;
            btnGuardar2.Enabled = false;
            btnLimpiar.Enabled = false;
            btnEliminar.Enabled = true;
            cargarInfoVehicuDataG();
        }

        /// <summary>
        /// Metodo para eliminar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        public void eliminarVehiculo()
        {
            Int32 numero = dataGridView1.GetCellCount(DataGridViewElementStates.Selected);
            if (numero == 6)
            {
                string placa3 = Convert.ToString(this.dataGridView1.CurrentRow.Cells[0].Value);
                carro.EliminarCarrro(placa3);
                cargarInfoVehicuDataG();
            }
            else
            {
                MessageBox.Show("Debe seleccionar toda la fila para eliminar el vehiculo. ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /// <summary>
        /// Eventos de los Label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void EventoSoloNumeros(KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void txtPlaca_KeyPress(object sender, KeyPressEventArgs e)
        {
            EventoSoloNumeros(e);
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            EventoSoloNumeros(e);
        }

        /// <summary>
        /// Funciones de los Botones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Window_Admin regresar = new Window_Admin();
            regresar.Show();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            guardarVehiculo();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Int32 numero = dataGridView1.GetCellCount(DataGridViewElementStates.Selected);
            if (numero == 6)
            {
                txtPlaca2.Visible = true;
                txtMarca2.Visible = true;
                txtModelo2.Visible = true;
                txtEstilo2.Visible = true;
                txtPrecio2.Visible = true;
                numericCantidad2.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
                label11.Visible = true;
                label12.Visible = true;
                btnModificar.Enabled = false;
                btnGuardar2.Enabled = true;
                btnLimpiar.Enabled = true;
                btnEliminar.Enabled = false;
                mostrarInfo();
            }
            else
            {
                MessageBox.Show("Debe seleccionar toda la fila para editar la informacion. ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnGuardar2_Click(object sender, EventArgs e)
        {
            guardarInfoEditada();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminarVehiculo();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPlaca2.Visible = false;
            txtMarca2.Visible = false;
            txtModelo2.Visible = false;
            txtEstilo2.Visible = false;
            txtPrecio2.Visible = false;
            numericCantidad2.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            btnModificar.Enabled = true;
            btnGuardar2.Enabled = false;
            btnLimpiar.Enabled = false;
            btnEliminar.Enabled = true;
        }
    }
}
