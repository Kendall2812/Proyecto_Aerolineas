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
    public partial class reservasYcompras : Form
    {
        int cedul;
        string name;
        //public reservasYcompras(int cedula, string nombre)
        int idUsusario;
        Reservas_Compras informacion = new Reservas_Compras();
        List<object> datos = new List<object>();
        DataSet datosReservas = new DataSet();

        public reservasYcompras(int cedula, string nombre)
        {
            InitializeComponent();
            idUsusario = cedula;
        }

        public void buscarReservas()
        {
            datosReservas = informacion.datos(idUsusario);

            dataGridView1.DataSource = datosReservas.Tables[0];
            dataGridView1.Columns[0].Width = 140;
            dataGridView1.Columns[1].Width = 140;
            dataGridView1.Columns[2].Width = 140;
            dataGridView1.Columns[3].Width = 140;
            dataGridView1.Columns[4].Width = 140;
            dataGridView1.Columns[5].Width = 140;
            dataGridView1.Columns[6].Width = 140;

            dataGridView1.Columns[0].HeaderCell.Value = "Codigo Hotel";
            dataGridView1.Columns[1].HeaderCell.Value = "Hotel";
            dataGridView1.Columns[2].HeaderCell.Value = "Cantidad Adultos";
            dataGridView1.Columns[3].HeaderCell.Value = "Cantidad Niños";
            dataGridView1.Columns[4].HeaderCell.Value = "Fecha Inicio";
            dataGridView1.Columns[5].HeaderCell.Value = "Fecha Final";
            dataGridView1.Columns[6].HeaderCell.Value = "Costo Total";
        }

        public void buscarReservaHoteles()
        {
            datosReservas 
        }

        private void InfoCarros(object formHija)
        {
            if (this.panel2.Controls.Count > 0)
                this.panel2.Controls.RemoveAt(0); //lo que hace es verificar que el panel tenga info si la tiene entonces la borra para poder mostrar la otra

            Form fr = formHija as Form;
            fr.TopLevel = false; // lo que hace es decir que no es un formulario de nivel superior sino que le dice que es secundario
            fr.Dock = DockStyle.Fill; // lo que hace esque el form se acople a el panel donde se va a mostrar
            this.panel2.Controls.Add(fr);
            this.panel2.Tag = fr;
            fr.Show();
            
        }

        public void guardarHotelCompras()
        {
            Int32 numero = dataGridView1.GetCellCount(DataGridViewElementStates.Selected);
            if (numero == 7)
            {
                int codigo = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);
                informacion.realizarCompra(codigo);
                buscarReservas();
            }
            else
            {
                MessageBox.Show("Debe seleccionar la toda fila para realizar la Compra.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void eliminarReserva()
        {
            Int32 numero = dataGridView1.GetCellCount(DataGridViewElementStates.Selected);
            if (numero == 7)
            {
                int codigo = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);
                informacion.eliminarReserva(codigo);
                buscarReservas();
            }
            else
            {
                MessageBox.Show("Debe seleccionar la toda fila para eliminar la Reserva.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnVehiculo_Click(object sender, EventArgs e)
        {
            InfoCarros(new Informacion_Carros());
        }

        private void Reservas_Hoteles_CheckedChanged(object sender, EventArgs e)
        {
            buscarReservas();
        }

        private void Reservas_Vuelos_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            buscarReservaHoteles();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminarReserva();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            guardarHotelCompras();
            //cedul = cedula;
            //name = nombre;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ver = new Form1();
            ver.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_User ver = new Menu_User(cedul, name);
            ver.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ventana_Calificacion ver = new Ventana_Calificacion();
            ver.Show();
        }
    }
}
