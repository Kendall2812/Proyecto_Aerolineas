using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;
using Aero_Negocio;

namespace Pagina_Principal
{
    public partial class Reportes_Admin : Form
    {
        Reportes reports = new Reportes();
        List<object> nombresHoteles = new List<object>();//contiene las veces que se repite el nombre de un hotel
        List<object> hotelRepetido = new List<object>();//contiene las veces que han reservado el hotel
        List<object> Hoteles = new List<object>();//contiene los nombres de los hoteles

        public Reportes_Admin()
        {
            InitializeComponent();
            Reporte1();
        }
        /// <summary>
        /// Forma dos para hacer los reportes
        /// </summary>
        public void Reporte1()
        {
            int contador1 = 0;

            this.Grafico1.Series.Clear();

            this.Grafico1.Titles.Clear();
            this.Grafico1.Titles.Add("Cantidad de veces que se a reservado un Hotel");

            Series series = this.Grafico1.Series.Add("Cantidad de veces que se a reservado un Hotel");
            series.ChartType = SeriesChartType.Pie;  /// cambia la forma del grafico

            nombresHoteles = reports.PrimerReporte();//tiene los nombre de los hoteles 

            for (int x = 0; x < nombresHoteles.Count; x++)
            {
                contador1 = 0;
                for (int y = 0; y < nombresHoteles.Count; y++)
                {
                    if (nombresHoteles[x].Equals(nombresHoteles[y]))
                    {
                        contador1 += 1;
                    }
                }

                hotelRepetido.Add(nombresHoteles[x]);
                hotelRepetido.Add(contador1);
                contador1 = 0;

                string nombre = Convert.ToString(nombresHoteles[x]);

                foreach (string c in nombresHoteles.ToList())//este foreach recorre la lista para eliminar el hotel que ya se conto
                {
                    if (c.Equals(nombre))
                    {
                        nombresHoteles.Remove(nombre);
                    }
                }
            }
            for(int t = 0; t < hotelRepetido.Count; t++)
            {
                series.Points.AddXY(hotelRepetido[t], hotelRepetido[t+1]);
                t += 1;
            }

            Grafico1.Series["Cantidad de veces que se a reservado un Hotel"].IsValueShownAsLabel = true;

            //int num = 1000;
            //string mes = "Marzo";
            //series.Points.AddXY(mes, num);
            //series.Points.AddXY("October", 300);
            //series.Points.AddXY("November", 800);
            //series.Points.AddXY("December", 200);
            //series.Points.AddXY("January", 600);
            //Grafico2.Series["Total Income"].IsValueShownAsLabel = true;
        }

        public void SplineChartExample()
        {
            //ejemplo
            this.Grafico2.Series.Clear();

            this.Grafico2.Titles.Clear();
            this.Grafico2.Titles.Add("Total Income");

            Series series = this.Grafico2.Series.Add("Total Income");
            series.ChartType = SeriesChartType.Pie;  /// cambia la forma del grafico
            int num = 1000;
            string mes = "Marzo";
            series.Points.AddXY(mes, num);
            series.Points.AddXY("October", 300);
            series.Points.AddXY("November", 800);
            series.Points.AddXY("December", 200);
            series.Points.AddXY("January", 600);
            Grafico2.Series["Total Income"].IsValueShownAsLabel = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Window_Admin regresar = new Window_Admin();
            regresar.Show();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                //BarExample(); //Show bar chart
                SplineChartExample();//SplineChartExample();
            }
        }

        //Los vectores con los datos
        //string[] series = { "Eduardo", "Jorge", "Jason", "Andres" };
        //int[] puntos = { 50, 10, 70, 100 };

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
        //}



        //////// Prueba de graficos
        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    BarExample(); //Show bar chart
        //    SplineChartExample();//SplineChartExample();
        //}
        //public void BarExample()
        //{
        //    this.Grafico2.Series.Clear();

        //    // Data arrays
        //    string[] seriesArray = { "Cat", "Dog", "Bird", "Monkey" };
        //    int[] pointsArray = { 2, 1, 7, 5 };

        //    // Set palette
        //    this.Grafico2.Palette = ChartColorPalette.SeaGreen;

        //    // Set title
        //    this.Grafico2.Titles.Add("Animals");

        //    // Add series.
        //    for (int i = 0; i < seriesArray.Length; i++)
        //    {
        //        Series series = this.Grafico2.Series.Add(seriesArray[i]);
        //        series.Points.Add(pointsArray[i]);
        //    }
        //}
        
    }
}
