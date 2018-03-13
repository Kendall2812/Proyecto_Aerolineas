﻿using System;
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

        List<object> segundoReporte = new List<object>();//contiene los nombres de los hoteles
        List<object> grafica2 = new List<object>();//contiene los nombres de los hoteles

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
            nombresHoteles.Clear();

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
                x = 0;
            }
            for(int t = 0; t < hotelRepetido.Count; t++)
            {
                series.Points.AddXY(hotelRepetido[t], hotelRepetido[t+1]);
                t += 1;
            }
            Grafico1.Series["Cantidad de veces que se a reservado un Hotel"].IsValueShownAsLabel = true;

        }

        ///////////////////////////////////////////////////////////////////////////////////////

        public void reporte2()
        {
            nombresHoteles.Clear();
            grafica2.Clear();
            segundoReporte.Clear();
            int numero = 0;
            int contador2 = 0;
            string nombre = "";
            int items = 0;

            segundoReporte = reports.SegundoReporte();//tiene los hoteles con la cantidad de personas

            this.Grafico2.Series.Clear();

            this.Grafico2.Titles.Clear();
            this.Grafico2.Titles.Add("Cantidad de personas que han estado por Hotel");

            Series series = this.Grafico2.Series.Add("Cantidad de personas que han estado por Hotel");
            series.ChartType = SeriesChartType.Pie;  /// cambia la forma del grafico

            for (int r=0; r < segundoReporte.Count; r = r+4)
            {
                nombresHoteles.Add(segundoReporte[r]);
            }

            for (int x = 0; x < nombresHoteles.Count; x++)
            {
                contador2 = 0;
                for (int y = 0; y < segundoReporte.Count; y++)
                {
                    if (nombresHoteles[x].Equals(segundoReporte[y]))
                    {
                        nombre = segundoReporte[y].ToString();
                        items = segundoReporte.IndexOf(nombre);
                        numero = Convert.ToInt32(segundoReporte[items + 1]);
                        contador2 += numero;
                        segundoReporte.RemoveAt(items);//borra el nombre del hotel
                    }
                }
                if (contador2 != 0)
                {
                    grafica2.Add(nombresHoteles[x]);
                    grafica2.Add(contador2);
                }
            }

            for (int t = 0; t < grafica2.Count; t++)
            {
                series.Points.AddXY(grafica2[t], grafica2[t + 1]);
                t += 1;
            }
            Grafico2.Series["Cantidad de personas que han estado por Hotel"].IsValueShownAsLabel = true;
            segundoReporte.Clear();
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
                reporte2();
            }
        }        
    }
}
