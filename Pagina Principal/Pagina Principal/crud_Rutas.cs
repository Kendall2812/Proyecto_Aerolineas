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
    public partial class crud_Rutas : Form
    {
        List<object> paises = new List<object>();
        List<object> paises2 = new List<object>();
        paises cargarPais = new paises();
        Rutas rutas = new Rutas();
        DataSet cargar = new DataSet();

        public crud_Rutas()
        {
            InitializeComponent();
            cargarCombox();
        }

        private void crud_aeropuertos_Load(object sender, EventArgs e)
        {
            
        }

        public void cargarCombox()
        {
            comboPaisOrigen.Items.Clear();
            paises = cargarPais.listaPaises();
            comboPaisOrigen.Items.Add("Seleccionar");
            comboPaisOrigen.SelectedItem = "Seleccionar";
            comboPaisDestino.Items.Add("Seleccionar");
            comboPaisDestino.SelectedItem = "Seleccionar";

            for (int i = 0; i < paises.Count; i++)
            {
                comboPaisOrigen.Items.Add(paises[i]);
                comboPaisDestino.Items.Add(paises[i]);
            }
            paises.Clear();
        }

        public void registarRuta()
        {
            try
            {
                Int32 codigo = Convert.ToInt32(txtCodigoR.Text);
                string paisOrigen = comboPaisOrigen.Text;
                string paisDestino = comboPaisDestino.Text;
                string duracion = Horas.Value.ToString("hh:mm");
                if (paisOrigen.Equals(paisDestino))
                {
                    MessageBox.Show("El país de Destino debe ser digente del de Origen.", "Adventencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Rutas guardarRuta = new Rutas();
                    guardarRuta.insertarRuta(codigo, paisOrigen, paisDestino, duracion);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("El codigo de la ruta debe ser numerico y no debe quedar en espacios blancos.", "Adventencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Window_Admin regresar = new Window_Admin();
            regresar.Show();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            registarRuta();
        }

        private void txtCodigoR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        public void cargarDataGridView()
        {
            cargar = rutas.cargarGriedView();

            dataGridView1Datos.DataSource = cargar.Tables[0];
            dataGridView1Datos.Columns[0].Width = 149;
            dataGridView1Datos.Columns[1].Width = 149;
            dataGridView1Datos.Columns[2].Width = 149;
            dataGridView1Datos.Columns[3].Width = 149;

            dataGridView1Datos.Columns[0].HeaderCell.Value = "Codigo";
            dataGridView1Datos.Columns[1].HeaderCell.Value = "País de Origen   ";
            dataGridView1Datos.Columns[2].HeaderCell.Value = "País de Destino  ";
            dataGridView1Datos.Columns[3].HeaderCell.Value = "Duración";
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                cargarDataGridView();
                paises2.Clear();
                cargarCombox2();
                codigo2.Text = "";
                Hora2.Value = DateTime.Now;
                comboPaisOrigen2.SelectedItem = "Seleccionar";
                comboPaisDestino2.SelectedItem = "Seleccionar";
            }
        }

        private void codigo2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        public void cargarCombox2()
        {
            paises2.Clear();
            comboPaisOrigen2.Items.Clear();
            comboPaisDestino2.Items.Clear();

            paises2 = cargarPais.listaPaises();
            comboPaisOrigen2.Items.Add("Seleccionar");
            comboPaisOrigen2.SelectedItem = "Seleccionar";
            comboPaisDestino2.Items.Add("Seleccionar");
            comboPaisDestino2.SelectedItem = "Seleccionar";

            for (int i = 0; i < paises2.Count; i++)
            {
                comboPaisOrigen2.Items.Add(paises2[i]);
                comboPaisDestino2.Items.Add(paises2[i]);
            }
            paises2.Clear();
        }

        public void mostrarDataGried()
        {
            Int32 numero = dataGridView1Datos.GetCellCount(DataGridViewElementStates.Selected);
            if (numero == 4)
            {
                codigo2.Text = Convert.ToString(Convert.ToInt32(this.dataGridView1Datos.CurrentRow.Cells[0].Value));

                string pais1 = Convert.ToString(this.dataGridView1Datos.CurrentRow.Cells[1].Value);
                comboPaisOrigen2.SelectedItem = pais1;

                string pais2 = Convert.ToString(this.dataGridView1Datos.CurrentRow.Cells[2].Value);
                comboPaisDestino2.SelectedItem = pais2;

                String duracion = Convert.ToString(this.dataGridView1Datos.CurrentRow.Cells[3].Value);
                Hora2.Value = Convert.ToDateTime(this.dataGridView1Datos.CurrentRow.Cells[3].Value);

            }
            else
            {
                MessageBox.Show("Debe estar toda la fila selecciona para poder modificar.");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            mostrarDataGried();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Int32 filas = dataGridView1Datos.GetCellCount(DataGridViewElementStates.Selected);
            if (filas == 4)
            {
                Int32 codigoPais = Convert.ToInt32(this.dataGridView1Datos.CurrentRow.Cells[0].Value);
                rutas.eliminarRuta(codigoPais);
                cargar.Clear();
                cargarDataGridView();
            }
            else
            {
                MessageBox.Show("Debe estar toda la fila selecciona para poder modificar.");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Int32 codigo3 = Convert.ToInt32(codigo2.Text);
                string paisOrigen2 = comboPaisOrigen2.Text;
                string paisDestino2 = comboPaisDestino2.Text;
                string duracion2 = Hora2.Value.ToString("hh:mm");
                if (paisOrigen2.Equals(paisDestino2))
                {
                    MessageBox.Show("El país de Destino debe ser digente del de Origen.", "Adventencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Rutas guardarRuta = new Rutas();
                    guardarRuta.modificarRuta(codigo3, paisOrigen2, paisDestino2, duracion2);
                    cargar.Clear();
                    cargarDataGridView();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("El codigo no debe quedar el espacio en blanco.", "Adventencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
