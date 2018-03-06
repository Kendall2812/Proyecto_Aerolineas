using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;

namespace Pagina_Principal
{
    public partial class Reportes_Admin : Form
    {
        List<string> series = new List<string>();
        List<int> puntos = new List<int>();

        public Reportes_Admin()
        {
            InitializeComponent();
            cargarNombres();
        }

        public void cargarNombres()
        {

        }

        public void lista()
        {

            string nombre = Convert.ToString(textBox1.Text);
            series.Add(nombre);
            int edad = Convert.ToInt32(textBox2.Text);
            puntos.Add(edad);
        }

        public void grafica()
        {
            Grafico1.Palette = ChartColorPalette.SemiTransparent;
            Grafico1.Titles.Add("Edades");
            for (int x = 0; x < series.Count; x++)
            {
                //titulos
                Series serie = Grafico1.Series.Add(series[x]);
                //cantidades
                serie.Label = puntos[x].ToString();

                serie.Points.Add(puntos[x]);
            }
            ////Los vectores con los datos
            //string[] series = { "Eduardo", "Jorge", "Jason", "Andres" };
            //int[] puntos = { 50, 10, 70 , 100};

            ////cambiar de color las barras
            //Grafico1.Palette = ChartColorPalette.SeaGreen;

            //Grafico1.Titles.Add("Edades");

            //for (int x = 0; x < series.Length; x++)
            //{
            //    //titulos
            //    Series serie = Grafico1.Series.Add(series[x]);
            //    //cantidades
            //    serie.Label = puntos[x].ToString();

            //    serie.Points.Add(puntos[x]);
            //}
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Window_Admin regresar = new Window_Admin();
            regresar.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            grafica();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lista();
        }

        private void comboNombreHoteles_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }
    }
}
