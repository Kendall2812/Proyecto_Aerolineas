using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Data_Base;
using System.Collections;
using Aero_Negocio;

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


        int cntPersonas, cntHabi, cntAdultos, cntMenores;

        public Seccion_vuelos()
        {
            InitializeComponent();
            panelPersonas.Visible = true;
            this.CenterToScreen();
        }

        public Seccion_vuelos(int cedula, string nombre)
        {
            InitializeComponent();
            panelPersonas.Visible = true;
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

        private void button2_Click(object sender, EventArgs e)
        {
            cargarVehi();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cargarHotel();
        }

        private void button2_MouseClick_1(object sender, MouseEventArgs e)
        {

        }

        private void spinnerHab_ValueChanged(object sender, EventArgs e)
        {
            //cargarHotel();
            cntHabi = Convert.ToInt32(spinnerHab.Value.ToString()) * 4;
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
                dtgHotel.Rows.Clear();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CargarVuelo();
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
                else if (dateTimePicker1.Value.ToString() == dateTimePicker2.Value.ToString())
                {
                    MessageBox.Show("Debe seleecionar una Fecha", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (Convert.ToDateTime(dateTimePicker1.Value.ToShortDateString()) < Convert.ToDateTime(ho) || Convert.ToDateTime(dateTimePicker2.Value.ToShortDateString()) < Convert.ToDateTime(ho))
                {
                    MessageBox.Show("Debe ingresar la fecha actual o una fecha posterior", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            if (!spinnerHab.Value.Equals(0) )
            {
                DB_Vuelos vue = new DB_Vuelos();
                vehiculos = vue.CargarVehi(cntPersonas, dtgVehi);
            }
            else
            {
                dtgVehi.Rows.Clear();
            }
        }   

    }
}
