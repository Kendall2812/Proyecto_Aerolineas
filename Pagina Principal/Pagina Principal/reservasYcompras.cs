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
using Data_Base;

namespace Pagina_Principal
{
    public partial class reservasYcompras : Form
    {
        //int codigoHotel = 0;
        //string name;
        //public reservasYcompras(int cedula, string nombre)
        int idUsusario = 0;
        string nombre1 = "";
        Reservas_Compras informacion = new Reservas_Compras();
        List<object> datos = new List<object>();
        DataSet datosReservas = new DataSet();
        DataSet datosRVuelos = new DataSet();
        DataSet datosVehi = new DataSet();
        DataSet datosHotel = new DataSet();
        //Ventana_Calificacion calificar = new Ventana_Calificacion();

        public reservasYcompras(int cedula, string nombre)
        {
            InitializeComponent();
            idUsusario = cedula;
            nombre1 = nombre;
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

            dataGridView1.Columns[0].HeaderCell.Value = "Codigo Reserva";
            dataGridView1.Columns[1].HeaderCell.Value = "Hotel";
            dataGridView1.Columns[2].HeaderCell.Value = "Cantidad Adultos";
            dataGridView1.Columns[3].HeaderCell.Value = "Cantidad Niños";
            dataGridView1.Columns[4].HeaderCell.Value = "Fecha Inicio";
            dataGridView1.Columns[5].HeaderCell.Value = "Fecha Final";
            dataGridView1.Columns[6].HeaderCell.Value = "Cantidad Habitaciones";
            dataGridView1.Columns[7].HeaderCell.Value = "Costo Total";
        }
        public void buscarVuelos()
        {
            dtgVehi.DataSource = null;
            dtgHotel.DataSource = null;
            datosRVuelos = informacion.cargarDatosVuelos(idUsusario);

            dataGridView1.DataSource = datosRVuelos.Tables[0];
            dataGridView1.Columns[0].Width = 140;
            dataGridView1.Columns[1].Width = 140;
            dataGridView1.Columns[2].Width = 140;
            dataGridView1.Columns[3].Width = 140;
            dataGridView1.Columns[4].Width = 140;
            dataGridView1.Columns[5].Width = 140;
            dataGridView1.Columns[6].Width = 140;

            dataGridView1.Columns[0].HeaderCell.Value = "Id Reserva";
            dataGridView1.Columns[1].HeaderCell.Value = "Pais origen";
            dataGridView1.Columns[2].HeaderCell.Value = "Pais destino";
            dataGridView1.Columns[3].HeaderCell.Value = "Escalas";
            dataGridView1.Columns[4].HeaderCell.Value = "Id vehiculo";
            dataGridView1.Columns[5].HeaderCell.Value = "Total vuelo";
            dataGridView1.Columns[6].HeaderCell.Value = "Total vehiculo";
            dataGridView1.Columns[7].HeaderCell.Value = "Total hotel";
            dataGridView1.Columns[8].HeaderCell.Value = "Total compra";
            dataGridView1.Columns[9].HeaderCell.Value = "Niños";
            dataGridView1.Columns[10].HeaderCell.Value = "Adultos";
            dataGridView1.Columns[11].HeaderCell.Value = "Id hotel";
            dataGridView1.Columns[12].HeaderCell.Value = "Fecha inicio";
            dataGridView1.Columns[13].HeaderCell.Value = "Fecha final";
            dataGridView1.Columns[14].HeaderCell.Value = "Nombre hotel";
            dataGridView1.Columns[15].HeaderCell.Value = "Duracion vuelo";
            dataGridView1.Columns[16].HeaderCell.Value = "Habitaciones";
           
        }
        public void buscarVehiculos()
        {
        
            dtgVehi.DataSource = datosVehi.Tables[0];
            dtgVehi.Columns[0].Width = 140;
            dtgVehi.Columns[1].Width = 140;
            dtgVehi.Columns[2].Width = 140;
            dtgVehi.Columns[3].Width = 140;
            dtgVehi.Columns[4].Width = 140;
            dtgVehi.Columns[5].Width = 140;

            dtgVehi.Columns[0].HeaderCell.Value = "Codigo";
            dtgVehi.Columns[1].HeaderCell.Value = "Marca";
            dtgVehi.Columns[2].HeaderCell.Value = "Modelo";
            dtgVehi.Columns[3].HeaderCell.Value = "Precio";
            dtgVehi.Columns[4].HeaderCell.Value = "Cantidad";
            dtgVehi.Columns[5].HeaderCell.Value = "Capacidad";
           

        }
        public void buscarHotel()
        {

            dtgHotel.DataSource = datosHotel.Tables[0];
            dtgHotel.Columns[0].Width = 120;
            dtgHotel.Columns[1].Width = 120;
            dtgHotel.Columns[2].Width = 120;
            dtgHotel.Columns[3].Width = 120;
            dtgHotel.Columns[4].Width = 120;
            dtgHotel.Columns[5].Width = 120;

            dtgHotel.Columns[0].HeaderCell.Value = "Codigo";
            dtgHotel.Columns[1].HeaderCell.Value = "Nombre";
            dtgHotel.Columns[2].HeaderCell.Value = "Lugar";
            dtgHotel.Columns[3].HeaderCell.Value = "Pais";
            dtgHotel.Columns[4].HeaderCell.Value = "Precio";
            dtgHotel.Columns[5].HeaderCell.Value = "Habitaciones";


        }
    

        public void buscarReservaHoteles()
        {
            datosRVuelos = informacion.cargarDatosVuelos(idUsusario);
        }

        //private void InfoCarros(object formHija)
        //{
        //    if (this.panel2.Controls.Count > 0)
        //        this.panel2.Controls.RemoveAt(0); //lo que hace es verificar que el panel tenga info si la tiene entonces la borra para poder mostrar la otra

        //    Form fr = formHija as Form;
        //    fr.TopLevel = false; // lo que hace es decir que no es un formulario de nivel superior sino que le dice que es secundario
        //    fr.Dock = DockStyle.Fill; // lo que hace esque el form se acople a el panel donde se va a mostrar
        //    this.panel2.Controls.Add(fr);
        //    this.panel2.Tag = fr;
        //    fr.Show();

        //}

        public void guardarHotelCompras()
        {
            if (Reservas_Hoteles.Checked) { 
                Int32 numero = dataGridView1.GetCellCount(DataGridViewElementStates.Selected);
                if (numero == 8)
                {
                    int codigo = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);
                    int canti_Habita = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[6].Value);
                    //guardar
                    informacion.realizarCompra(codigo);
                    buscarReservas();
                    //modifica la cantidad de habitaciones en hoteles
                    informacion.restarHabitaciones(codigo, canti_Habita);

                    Ventana_Calificacion calificar = new Ventana_Calificacion(codigo);
                    calificar.Show();
                }
                else
                {
                    MessageBox.Show("Debe seleccionar la toda fila para realizar la Compra.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (Reservas_Vuelos.Checked){
                Int32 numero = dataGridView1.GetCellCount(DataGridViewElementStates.Selected);
                if (numero == 17)
                {
                    string id_vehiculo = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    int id_hotel = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[11].Value);
                    int id_reserva = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);
                    int canti_Habita= Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[16].Value);
                    //guardar
                    informacion.realizarCompra(id_reserva);
                    buscarVuelos();
                    //modifica la cantidad de habitaciones en hoteles
                    if (!id_vehiculo.Equals("0"))
                    {
                        informacion.restarVehiculos(id_reserva);
                        buscarVuelos();
                    }
                    if (!id_hotel.Equals(0))
                    {
                        informacion.restarHabitaciones(id_hotel, canti_Habita);
                        Ventana_Calificacion calificar = new Ventana_Calificacion(id_hotel);
                        calificar.Show();
                        buscarVuelos();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Debe seleccionar la toda fila para realizar la Compra.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public void eliminarReserva()
        {
            Int32 numero = dataGridView1.GetCellCount(DataGridViewElementStates.Selected);
            if (numero == 8)
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

        //private void btnVehiculo_Click(object sender, EventArgs e)
        //{
        //    InfoCarros(new Informacion_Carros());
        //}
        public void eliminarReservaVuelo()
        {
            Int32 numero = dataGridView1.GetCellCount(DataGridViewElementStates.Selected);
            if (numero == 17)
            {
                int codigo = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);
                informacion.eliminarReservaVuelo(codigo);
                buscarVuelos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar la toda fila para eliminar la Reserva.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Reservas_Hoteles_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dtgVehi.DataSource = null;
            dtgHotel.DataSource = null;
            buscarReservas();
        }

        private void Reservas_Vuelos_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            buscarVuelos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
            if (Reservas_Vuelos.Checked)
            {
                eliminarReservaVuelo();
            }
            if (Reservas_Hoteles.Checked)
            {
                eliminarReserva();
            }
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
            Menu_User ver = new Menu_User(idUsusario, nombre1);
            ver.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dtgVehi.DataSource = null;
            dtgHotel.DataSource = null;
            if (Reservas_Vuelos.Checked)
            {
                Int32 numero = dataGridView1.GetCellCount(DataGridViewElementStates.Selected);
                if (numero == 17)
                {
                    dtgVehi.DataSource = null;
                    string id_vehiculo = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    int id_hotel = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[11].Value);
                    DB_Reservas re = new DB_Reservas();
                    if (!id_vehiculo.Equals("0")) {
                        datosVehi = re.cargarvehiculos(id_vehiculo);
                        buscarVehiculos();
                    }if (!id_hotel.Equals(0))
                    {
                        datosHotel= re.cargarhotel(id_hotel);
                        buscarHotel();
                    }
                }
                else
                {
                    MessageBox.Show("Debe estar la fila selecciona para poder comprar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    Ventana_Calificacion ver = new Ventana_Calificacion();
        //    ver.Show();
        //}
    }
}
