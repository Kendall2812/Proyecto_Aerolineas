using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Data_Base;
using System.Collections;
using Aero_Negocio;
using System.Drawing;

namespace Pagina_Principal
{
    public partial class Seccion_vuelos : Form
    {
        public string[] destino;
        List<object> hoteles = new List<object>();
        List<object> vehiculos = new List<object>();
        ArrayList pais = new ArrayList();
        public ArrayList escalas = new ArrayList();
        ArrayList precios = new ArrayList();
        ArrayList duracion = new ArrayList();
        DateTime hoy = DateTime.Now;
        bool busVehi;
        bool busHotel;
        int cntPersonas, cntHabi, cntAdultos, cntMenores;
        int cedula1 = 0;
        string nombre1 = "";
        bool accion = false;
        string nombreh, lugarh, paish;
        string nombrev, lugarv, paisv, codigov, escalasvue, paisOri, paisDes, duracionvuelo;
        int codigoh, precioh, preciovue;
        int preciov, cantidaHabitaciones, cantidadDias;
        public Seccion_vuelos()
        {
            InitializeComponent();
            panelPersonas.Visible = true;
            this.CenterToScreen();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgHotel.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgVehi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        //comentar

        public Seccion_vuelos(int cedula, string nombre)
        {
            InitializeComponent();
            panelPersonas.Visible = true;
            cedula1 = cedula;
            nombre1 = nombre;
            this.CenterToScreen();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgHotel.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgVehi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void seccion_vuelos_Load(object sender, EventArgs e)
        {
            DB_Vuelos vu = new DB_Vuelos();
            vu.Autocompletar(textBox1, textBox2);
        }

        private void spinnerAdultos_ValueChanged(object sender, EventArgs e)
        {

            cntPersonas = 0;
            cntAdultos = 0;
            cntAdultos = Convert.ToInt32(spinnerAdultos.Value.ToString());
            cntPersonas = cntMenores + cntAdultos;
            if (cntPersonas <= cntHabi)
            {
                spinnerAdultos.Enabled = true;

            }
            else
            {
                spinnerAdultos.Value = cntAdultos - 1;

            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            label5.Text = "";
            DateTime llegada = DateTime.Parse(dtLlegada.Text);
            DateTime salida = DateTime.Parse(dtSalida.Text);
            TimeSpan dias = llegada - salida;
            cantidadDias = dias.Days;
            label5.Text += "Total Dias " + cantidadDias.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (cntPersonas > 0)
            {
                if (!busVehi)
                {
                    MessageBox.Show("Carga Tabla");
                    cargarVehi();
                    busVehi = true;

                    this.button2.BackColor = Color.Red;

                }
                else
                {
                    MessageBox.Show("Borra Tabla");
                    busVehi = false;
                    this.button2.BackColor = Color.DarkGray;
                    dtgVehi.Rows.Clear();
                }
            }
            else
            {
                MessageBox.Show("Debe selecionar la cantidad de personas que desea");
                dtgVehi.Rows.Clear();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dtgHotel.Rows.Clear();
            string[] lugar = textBox2.Text.Split(',');
            if (!lugar[0].Equals(String.Empty) && !spinnerHab.Text.Equals(0))
            {
                if (!busHotel)
                {
                    MessageBox.Show("Carga Tabla");
                    cargarHotel();
                    busHotel = true;

                    this.button1.BackColor = Color.Red;

                }
                else
                {
                    MessageBox.Show("Borra Tabla");
                    busHotel = false;
                    this.button1.BackColor = Color.DarkGray;
                    dtgHotel.Rows.Clear();
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar el destino y cantidad de habitaciones", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dtgHotel.Rows.Clear();
            }
        }

        private void button2_MouseClick_1(object sender, MouseEventArgs e)
        {

        }

        private void spinnerHab_ValueChanged(object sender, EventArgs e)
        {

            cntHabi = Convert.ToInt32(spinnerHab.Value.ToString()) * 4;
            if (cntPersonas <= cntHabi)
            {
                if (!busVehi)
                {
                    cargarVehi();
                }
                else if (!busHotel)
                {
                    cargarHotel();
                }

            }
            else
            {
                spinerMenores.Value = 0;
                spinnerAdultos.Value = 0;
                dtgVehi.Rows.Clear();
                busVehi = false;
                this.button2.BackColor = Color.DarkGray;
                dtgHotel.Rows.Clear();
                busHotel = false;
                this.button1.BackColor = Color.DarkGray;

            }
        }

        public void cargarHotel()
        {
            dtgHotel.Rows.Clear();
            string[] lugar = textBox2.Text.Split(',');
            if (!lugar[0].Equals(String.Empty) && !spinnerHab.Text.Equals(0))
            {
                DB_Vuelos vu = new DB_Vuelos();
                hoteles = vu.datosHoteles(lugar[1], Convert.ToInt32(spinnerHab.Text), lugar[0], dtgHotel);

            }
            else
            {
                MessageBox.Show("Debe ingresar el destino y cantidad de habitaciones", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dtgHotel.Rows.Clear();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 numero = dataGridView1.GetCellCount(DataGridViewElementStates.Selected);
            if (numero == 11)
            {
                paisOri = dataGridView1.SelectedRows[0].Cells["Column1"].Value.ToString();
                paisDes = dataGridView1.SelectedRows[0].Cells["Column2"].Value.ToString();
                escalasvue = dataGridView1.SelectedRows[0].Cells["Column3"].Value.ToString();
                preciovue = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Column7"].Value.ToString());
                duracionvuelo = dataGridView1.SelectedRows[0].Cells["Column8"].Value.ToString();
                cantidaHabitaciones= Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Column11"].Value.ToString());
                if (duracionvuelo.Equals("0"))
                {
                    duracionvuelo = dataGridView1.SelectedRows[0].Cells["Column9"].Value.ToString();
                }
            }
            else
            {
                MessageBox.Show("Debe estar la fila selecciona para poder Reservar el Vuelo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CargarVuelo();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_User ver = new Menu_User(cedula1, nombre1);
            ver.Show();
        }

        private void dtgVehi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 numero = dtgVehi.GetCellCount(DataGridViewElementStates.Selected);
            if (numero == 6)
            {
                codigov = dtgVehi.SelectedRows[0].Cells["id_vehiculo"].Value.ToString();
                preciov = Convert.ToInt32(dtgVehi.SelectedRows[0].Cells["precio_ve"].Value.ToString());

            }
            else
            {
                MessageBox.Show("Debe estar la fila selecciona para poder Reservar el Vehiculo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnReserva_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un vuelo!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                reservar();

                //Close();
            }
        }

        private void dtgHotel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 numero = dtgHotel.GetCellCount(DataGridViewElementStates.Selected);
            if (numero == 7)
            {
                codigoh = Convert.ToInt32(dtgHotel.SelectedRows[0].Cells["id"].Value.ToString());
                nombreh = dtgHotel.SelectedRows[0].Cells["nombrehotl"].Value.ToString();
                lugarh = dtgHotel.SelectedRows[0].Cells["lugar"].Value.ToString();
                paish = dtgHotel.SelectedRows[0].Cells["nombre_pais"].Value.ToString();
                precioh = Convert.ToInt32(dtgHotel.SelectedRows[0].Cells["precio_h"].Value.ToString());

                alojamiento alo = new alojamiento();
                try
                {
                    string foto = alo.TraerInfo("SELECT foto FROM hoteles WHERE codigo = '" + dtgHotel.CurrentRow.Cells[0].Value + "'");
                    Bitmap foto2 = new Bitmap(foto);
                    pictureBox1.Image = (Image)foto2;

                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message);
                }
            }
            else
            {
                MessageBox.Show("Debe estar la fila selecciona para poder Reservar el Hotel.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void spinerMenores_ValueChanged(object sender, EventArgs e)
        {
            cntPersonas = 0;
            cntMenores = 0;
            cntMenores = Convert.ToInt32(spinerMenores.Value.ToString());
            cntPersonas = cntMenores + cntAdultos;
            if (cntPersonas <= cntHabi)
            {
                spinerMenores.Enabled = true;

            }
            else
            {

                spinerMenores.Value = cntMenores - 1;

            }
        }

        public void CargarVuelo()
        {
            dataGridView1.Rows.Clear();
            string ho = hoy.ToString("dd/MM/yyyy");
            string[] pais1 = textBox1.Text.Split(',');
            string[] pais2 = textBox2.Text.Split(',');
            try
            {
                if (pais1[0] == pais2[0])
                {
                    MessageBox.Show("Los paises deben ser diferentes", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (dtSalida.Value.ToString() == dtLlegada.Value.ToString())
                {
                    MessageBox.Show("Debe seleecionar una Fecha", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (Convert.ToDateTime(dtSalida.Value.ToShortDateString()) < Convert.ToDateTime(ho) || Convert.ToDateTime(dtLlegada.Value.ToShortDateString()) < Convert.ToDateTime(ho))
                {
                    MessageBox.Show("Debe ingresar la fecha actual o una fecha posterior", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (cntPersonas == 0)
                {
                    MessageBox.Show("Debe ingresar la cantidad de personas", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    alojamiento a = new alojamiento();
                    DB_Vuelos v = new DB_Vuelos();
                    Vuelos vue = new Vuelos();
                    string paiso = a.TraerInfo("SELECT pais_origen FROM rutas WHERE pais_origen = '" + pais1[0] + "'");
                    string paisd = a.TraerInfo("SELECT pais_destino FROM rutas WHERE pais_destino = '" + pais2[0] + "'");
                    string direccionEscala = v.escala_vuelo_Directo(paiso, paisd);
                    pais = v.Escala_en_paises(paiso, paisd);
                    escalas = v.escalas_vuelo(paisd);
                    precios = vue.precioEscala(paisd);
                    duracion = vue.duracionEscala(paisd);
                    dataGridView1.Rows.Clear();
                    vue.mostrarInfo(dataGridView1, paiso, paisd, direccionEscala, pais, escalas, precios, duracion, cntAdultos + cntMenores, Convert.ToInt32(spinnerHab.Value.ToString()));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Debe seleccionar el pais de origen " + e.Message, "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void cargarVehi()
        {
            dtgVehi.Rows.Clear();
            if (cntPersonas != 0)
            {
                DB_Vuelos vue = new DB_Vuelos();
                vehiculos = vue.CargarVehi(cntPersonas, dtgVehi);
            }
            else
            {
                dtgVehi.Rows.Clear();
            }
        }
        public void reservar()
        {
            alojamiento alo = new alojamiento();
            int preciovehi = (preciov * 13) / 100;
            int totalvehi = preciovehi + preciov;

            int precioho = (precioh * 13) / 100;
            int totalhotel =(precioho + precioh);

            int preciovu = (preciovue * 13) / 100;
            int totalpreciovue = preciovue + preciovu;

            int totalcompra = totalvehi + totalhotel + totalpreciovue;

            //string sql = "INSERT INTO reservas(ini_pais_origen, fin_pais_destino, escalas, vehiculo, total_vuelo ," +
            //    " total_vehículo, total_hotel, total_compra, nombre, cedula, niños, adultos, id_hotel, fecha_inicio, fecha_final, " +
            //    "nombre_hotel, tipo_accion,duracion_vuelo) VALUES('" + paisOri + "', '" + paisDes + "', '" + escalasvue + "', '" + codigov + "', '" + totalpreciovue + "', '" + totalvehi + "', '" + totalhotel + "', '" + totalcompra + "', '" + nombre1 + "', '" + cedula1 + "','" + Convert.ToInt32(spinerMenores.Value.ToString()) + "','" + Convert.ToInt32(spinnerAdultos.Value.ToString())
            //    + "' , '" + codigoh + "', '" + Convert.ToDateTime(dateTimePicker1.Value.ToShortDateString()) + "', '" + Convert.ToDateTime(dateTimePicker2.Value.ToShortDateString()) + "', '" + nombreh + "', '" + accion + "', '" + duracionvuelo + "'); ";

            string sql2= "INSERT INTO reservas(ini_pais_origen, fin_pais_destino, escalas, vehiculo, total_vuelo , total_vehículo , total_hotel, total_compra, nombre, cedula, niños, adultos, id_hotel, fecha_inicio, fecha_final, nombre_hotel, tipo_accion,duracion_vuelo, canti_habitaciones)" +
                "VALUES('" + paisOri + "', '" + paisDes + "', '" + escalasvue + "', '" + codigov + "', '" + totalpreciovue + "', '" + totalvehi + "', '" + totalhotel + "',  '" + totalcompra + "', '" + nombre1 + "', '" + cedula1 + "', '" + Convert.ToInt32(spinerMenores.Value.ToString()) + "', '" + Convert.ToInt32(spinnerAdultos.Value.ToString())+ "' , '" + codigoh + "',  '" + Convert.ToDateTime(dtLlegada.Value.ToShortDateString()) + "', '" + Convert.ToDateTime(dtLlegada.Value.ToShortDateString()) + "', '" + nombreh + "', '" + accion + "', '" + duracionvuelo + "', '" + cantidaHabitaciones + "'); ";
            alo.InsertarReserva(sql2);
        }

    }
}
