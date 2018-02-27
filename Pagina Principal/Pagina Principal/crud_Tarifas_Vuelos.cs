using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Aero_Negocio;

namespace Pagina_Principal
{
    public partial class crud_Tarifas_Vuelos : Form
    {
        Tarifa_Vuelos vuelo = new Tarifa_Vuelos();
        Rutas nombreRuta = new Rutas();
        DataSet cargarDatosRutas = new DataSet();
        DataSet DatosTarifasVuelos = new DataSet();
        List<object> nombreRutas = new List<object>();
        bool valor = false;

        public crud_Tarifas_Vuelos()
        {
            InitializeComponent();
            cargarNombreRutas(valor);
        }

        private void crud_Tarifas_Vuelos_Load(object sender, EventArgs e)
        {
            btnGuardar2.Enabled = false;
        }
        /// <summary>
        /// Esta la parte de agregar la informacion 
        /// </summary>
        public void agregarTarifaVuelo()
        {
            Int32 numero = dataGridView1.GetCellCount(DataGridViewElementStates.Selected);
            if (numero == 4)
            {
                string codigoTariVuelo = txtCodigoTarifa.Text;
                string codigoruta = Convert.ToString(this.dataGridView1.CurrentRow.Cells[0].Value);
                string precioTarifa = txtPrecioTarifa.Text;
                vuelo.insertarTarifaVuelo(codigoTariVuelo, codigoruta, precioTarifa);

                txtCodigoTarifa.Text = "";
                txtPrecioTarifa.Text = "";
            }
            else
            {
                MessageBox.Show("Debe estar toda la fila selecciona para poder modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void cargarNombreRutas(bool valor1)
        {
            cargarDatosRutas = nombreRuta.cargarGriedView();
            if (valor1 == false)
            {
                dataGridView1.DataSource = cargarDatosRutas.Tables[0];
                dataGridView1.Columns[0].Width = 149;
                dataGridView1.Columns[1].Width = 149;
                dataGridView1.Columns[2].Width = 149;
                dataGridView1.Columns[3].Width = 149;

                dataGridView1.Columns[0].HeaderCell.Value = "Codigo";
                dataGridView1.Columns[1].HeaderCell.Value = "País de Origen   ";
                dataGridView1.Columns[2].HeaderCell.Value = "País de Destino  ";
                dataGridView1.Columns[3].HeaderCell.Value = "Duración";
            }
            else if(valor1 == true)
            {
                dataGridView2.DataSource = cargarDatosRutas.Tables[0];
                dataGridView2.Columns[0].Width = 149;
                dataGridView2.Columns[1].Width = 149;
                dataGridView2.Columns[2].Width = 149;
                dataGridView2.Columns[3].Width = 149;

                dataGridView2.Columns[0].HeaderCell.Value = "Codigo";
                dataGridView2.Columns[1].HeaderCell.Value = "País de Origen   ";
                dataGridView2.Columns[2].HeaderCell.Value = "País de Destino  ";
                dataGridView2.Columns[3].HeaderCell.Value = "Duración";
            }
        }
        /// <summary>
        /// Esta es la parte de editar la informacion
        /// </summary>
        public void cargarInfoTarifVuelo()
        {
            DatosTarifasVuelos = vuelo.cargarDatosTarifas();

            dataGridView3.DataSource = DatosTarifasVuelos.Tables[0];
            dataGridView3.Columns[0].Width = 149;
            dataGridView3.Columns[1].Width = 149;
            dataGridView3.Columns[2].Width = 149;
            dataGridView3.Columns[3].Width = 149;
            dataGridView3.Columns[4].Width = 149;
            dataGridView3.Columns[5].Width = 149;

            dataGridView3.Columns[0].HeaderCell.Value = "Codigo Tarifa Vuelo";
            dataGridView3.Columns[1].HeaderCell.Value = "Precio Ruta";
            dataGridView3.Columns[2].HeaderCell.Value = "Codigo Ruta";
            dataGridView3.Columns[3].HeaderCell.Value = "País de Origen ";
            dataGridView3.Columns[4].HeaderCell.Value = "País de Destino";
            dataGridView3.Columns[5].HeaderCell.Value = "Duración";
        }

        public void guardarInfoEditada()
        {
            string codigoRuta3 = "";
            Int32 codigoEditado = 0;
            bool verificar;
            try
            {
                Int32 codigoTarifa3 = Convert.ToInt32(this.dataGridView3.CurrentRow.Cells[0].Value);
                Int32 precioModificado = Convert.ToInt32(txtPrecioTarifa2.Text);
                

                Int32 numero = dataGridView2.GetCellCount(DataGridViewElementStates.Selected);
                if (numero == 4)
                {
                    if (numero == 4)
                    {
                        codigoRuta3 = Convert.ToString(this.dataGridView2.CurrentRow.Cells[0].Value);
                        codigoEditado = Convert.ToInt32(codigoRuta3);
                        //////
                        verificar = vuelo.prueba(codigoTarifa3, codigoEditado);
                        /////
                        if (verificar == true)
                        {
                            MessageBox.Show("Esta ruta se encuentra registrada con un precio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            vuelo.modificarTarifaVuelo(codigoTarifa3, codigoEditado, precioModificado);
                            cargarInfoTarifVuelo();
                            desactivarFunciones();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe estar toda la fila selecciona para poder cambiar de ruta.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else if(numero < 4)
                {
                    codigoRuta3 = Convert.ToString(this.dataGridView3.CurrentRow.Cells[2].Value);
                    codigoEditado = Convert.ToInt32(codigoRuta3);
                    vuelo.modificarTarifaVuelo(codigoTarifa3, codigoEditado, precioModificado);
                    cargarInfoTarifVuelo();
                    desactivarFunciones();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(""+e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void desactivarFunciones()
        {
            txtPrecioTarifa2.Visible = false;
            txtSignoDolar.Visible = false;
            label6.Visible = false;
            label4.Visible = false;
            label7.Visible = false;
            dataGridView2.Visible = false;
            btnEliminar.Enabled = true;
            btnGuardar2.Enabled = false;
        }
        /// <summary>
        /// Esta es la parte de la funcion de los botones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Window_Admin regresar = new Window_Admin();
            regresar.Show();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            agregarTarifaVuelo();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                cargarInfoTarifVuelo();
                desactivarFunciones();
            }
            else if (tabControl1.SelectedIndex == 0)
            {
                cargarNombreRutas(valor);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Int32 numero = dataGridView3.GetCellCount(DataGridViewElementStates.Selected);
            if (numero == 6)
            {
                valor = true;
                cargarNombreRutas(valor);
                txtPrecioTarifa2.Visible = true;
                txtSignoDolar.Visible = true;
                label6.Visible = true;
                txtPrecioTarifa2.Text = Convert.ToString(Convert.ToInt32(this.dataGridView3.CurrentRow.Cells[1].Value));
                label4.Visible = true;
                label7.Visible = true;
                dataGridView2.Visible = true;
                btnEliminar.Enabled = false;
                btnGuardar2.Enabled = true;
            }
            else
            {
                MessageBox.Show("Debe estar toda la fila selecciona para poder modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtPrecioTarifa2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnGuardar2_Click_1(object sender, EventArgs e)
        {
            guardarInfoEditada();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Int32 numero = dataGridView3.GetCellCount(DataGridViewElementStates.Selected);
            if (numero == 6)
            {
                Int32 codigoTarifa4 = Convert.ToInt32(this.dataGridView3.CurrentRow.Cells[0].Value);
                vuelo.eliminarTarifaVuelo(codigoTarifa4);
                cargarInfoTarifVuelo();
            }
            else
            {
                MessageBox.Show("Debe estar toda la fila selecciona para poder eliminarla.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            desactivarFunciones();
        }
    }
}
