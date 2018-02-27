using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Data_Base;
using Npgsql;

namespace Pagina_Principal
{
    public partial class Form2 : Form
    {
        int cntPersonas, cntHabi, cntAdultos,cntMenores;
        SqlDataAdapter adapta = new SqlDataAdapter();
        SqlConnection cn = new SqlConnection();
        SqlCommand sqlseleccion = new SqlCommand();
        DataSet datos = new DataSet();

        static NpgsqlConnection connection;
       
        Conexio_BaseDatos conexion1 = new Conexio_BaseDatos();
        AutoCompleteStringCollection source = new AutoCompleteStringCollection();
        public Form2()
        {
            InitializeComponent();
            this.CenterToScreen();
            panelPersonas.Visible = true;
        }

        private void numericUpDown1_Click(object sender, EventArgs e)
        {
            //contextMenuStrip1.Show(numericUpDown1, 1, numericUpDown1.Height);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Alojamientos c = new Alojamientos();
            c.autoCompletar(textBox1);
        
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            lblDias.Text="";
            DateTime llegada = DateTime.Parse(dataTLlegada.Text);
            DateTime salida = DateTime.Parse(dateTPSalida.Text);
            TimeSpan dias = llegada - salida;
            int cantidadDias = dias.Days;
            lblDias.Text += "Total Dias "+ cantidadDias.ToString();
        }
        
        private void btnReservar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Has reservado un hotel con " + spinnerHab.Value.ToString());
           
        }

        

        private void spinnerHab_ValueChanged(object sender, EventArgs e)
        {
            cntHabi = Convert.ToInt32(spinnerHab.Value.ToString()) * 4;
            MessageBox.Show("Habi "+cntHabi);
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
       

        
    }
}
