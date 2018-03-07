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
        List<string> nombresHoteles = new List<string>();
        List<int> puntos = new List<int>();

        public Reportes_Admin()
        {
            InitializeComponent();
        }

        public void reporte1()
        {
            //nombresHoteles =  
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

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                reporte1();
            }
        }
    }
}
