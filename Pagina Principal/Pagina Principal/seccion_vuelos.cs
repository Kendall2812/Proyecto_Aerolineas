using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data_Base;
using System.Collections;

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
            dtgVehi.Rows.Clear();
            cntPersonas = 0;
            cntAdultos = 0;
            cntAdultos = Convert.ToInt32(spinnerAdultos.Value.ToString());
            cntPersonas = cntMenores + cntAdultos;
            if (cntPersonas <= cntHabi)
            {
                spinnerAdultos.Enabled = true;
                cargarVehi();
            }
            else
            {
                spinnerAdultos.Value = cntAdultos - 1;
                cargarVehi();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
         
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
                dtgHotel.Columns.Clear();
            }
        }

        private void spinerMenores_ValueChanged(object sender, EventArgs e)
        {
            dtgVehi.Rows.Clear();
            cntPersonas = 0;
            cntMenores = 0;
            cntMenores = Convert.ToInt32(spinerMenores.Value.ToString());
            cntPersonas = cntMenores + cntAdultos;
            if (cntPersonas <= cntHabi)
            {
                spinerMenores.Enabled = true;
                cargarVehi();
            }
            else
            {
                
                spinerMenores.Value = cntMenores - 1;
                cargarVehi();
            }
        }

        public void CargarVuelo()
        {


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
                    MessageBox.Show("Seleccione una Fecha!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (Convert.ToDateTime(dateTimePicker1.Value.ToShortDateString()) < Convert.ToDateTime(ho) || Convert.ToDateTime(dateTimePicker2.Value.ToShortDateString()) < Convert.ToDateTime(ho))
                {
                    MessageBox.Show("Debe ingresar la fecha actual o una fecha posterior", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {

                    //string paiso = pu.paiso(origen.SelectedItem.ToString());
                    //string paisd = pu.paisd(destino.SelectedItem.ToString());
                    //string direcoesca = pu.escala_Directo(paiso, paisd);


                    //pais = pu.paisesEscala(paiso, paisd);

                    //escalas = pu.escala(paisd);

                    //precios = pu.precioEscala(paisd);

                    //duracion = pu.duracionEscala(paisd);
                    //vuelos.Rows.Clear();
                    //pu.mostrarInfo(vuelos, paiso, paisd, direcoesca, pais, escalas, precios, duracion, cntAdultos + cntMenores, spinnerHab.Value.ToString());
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
            DB_Vuelos vue = new DB_Vuelos();
            vehiculos = vue.CargarVehi(cntPersonas, dtgVehi);
        }

    }
}
