using System;
using System.Data;
using System.Windows.Forms;
using Aero_Negocio;

namespace Pagina_Principal
{
    public partial class crud_Tarifas_Hoteles : Form
    {
        Tarifas_Hoteles tarifa = new Tarifas_Hoteles();
        DataSet datosTarifas = new DataSet();

        public crud_Tarifas_Hoteles()
        {
            InitializeComponent();
        }

        public void agregarTarifa()
        {
            try
            {
                Int32 codigo = Convert.ToInt32(txtCodigoPrecio.Text);
                Int32 precio = Convert.ToInt32(txtPrecio.Text);
                tarifa.insertarTarifa(codigo, precio);
                txtCodigoPrecio.Text = "";
                txtPrecio.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("No pueden quedar espacios en blanco", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void cargarDataGridView()
        {
            datosTarifas = tarifa.cargarTarifa_GriedView();

            dataGridView1.DataSource = datosTarifas.Tables[0];
            dataGridView1.Columns[0].Width = 200;
            dataGridView1.Columns[1].Width = 200;

            dataGridView1.Columns[0].HeaderCell.Value = "Codigo";
            dataGridView1.Columns[1].HeaderCell.Value = "Precio Habitación";
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                cargarDataGridView();
                txtCodigo2.Text = "";
                txtPrecio2.Text = "";
            }
        }

        public void cargarInformacionTarifas()
        {
            Int32 numero = dataGridView1.GetCellCount(DataGridViewElementStates.Selected);
            if (numero == 2)
            {
                txtCodigo2.Text = Convert.ToString(Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value));

                txtPrecio2.Text = Convert.ToString(Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[1].Value));
            }
            else
            {
                MessageBox.Show("Debe estar toda la fila selecciona para poder modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void infoEditaTarifas()
        {
            try
            {
                Int32 codigo3 = Convert.ToInt32(txtCodigo2.Text);
                Int32 precio3 = Convert.ToInt32(txtPrecio2.Text);
                tarifa.modificarTarifa(codigo3, precio3);
                cargarDataGridView();
                txtCodigo2.Text = "";
                txtPrecio2.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Ningun espacio debe quedar en blaco.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void eliminarTarifa()
        {
            try
            {
                Int32 numero = dataGridView1.GetCellCount(DataGridViewElementStates.Selected);
                if (numero == 2)
                {
                    Int32 codigo4 = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);
                    tarifa.eliminarTarifa(codigo4);
                    cargarDataGridView();
                    txtCodigo2.Text = "";
                    txtPrecio2.Text = "";
                }
                else
                {
                    MessageBox.Show("Debe estar toda la fila selecciona para poder Eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Debe seleccionar primero una tarifa en la tabla para eliminarla.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            agregarTarifa();
        }

        private void btnGuardar2_Click(object sender, EventArgs e)
        {
            infoEditaTarifas();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            cargarInformacionTarifas();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminarTarifa();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Window_Admin regresar = new Window_Admin();
            regresar.Show();
        }

        public void validarSoloNumeros(KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtCodigoPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarSoloNumeros(e);
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarSoloNumeros(e);
        }

        private void txtPrecio2_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarSoloNumeros(e);
        }
    }
}
