using System;
using System.Drawing;
using System.Windows.Forms;

namespace Pagina_Principal
{
    public partial class Window_Admin : Form
    {
        public Window_Admin()
        {
            InitializeComponent();
            panelLed2.Visible = false;
            panelLed3.Visible = false;
        }

        private void button9_MouseHover(object sender, EventArgs e)
        {
            button9.ForeColor = Color.Blue;
        }

        private void button9_MouseLeave(object sender, EventArgs e)
        {
            button9.ForeColor = Color.Black;
        }

        private void button9_MouseDown(object sender, MouseEventArgs e)
        {
            string message = "Desea cerrar Sesión.";
            string captura = "Advertencia";
            MessageBoxButtons boton = MessageBoxButtons.YesNo;
            MessageBoxIcon boton2 = MessageBoxIcon.Warning;
            DialogResult result;

            result = MessageBox.Show(message, captura, boton, boton2);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Hide();
                Form1 principal = new Form1();
                principal.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            crud_pais pais = new crud_pais();
            pais.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            crud_Tarifas_Hoteles tarifas = new crud_Tarifas_Hoteles();
            tarifas.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            crud_Tarifas_Vuelos tarifasVuelos = new crud_Tarifas_Vuelos();
            tarifasVuelos.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            crud_lugares lugar = new crud_lugares();
            lugar.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            crud_Hoteles hotel = new crud_Hoteles();
            hotel.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            crud_Vehiculos carro = new crud_Vehiculos();
            carro.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            crud_Rutas aeropuertos = new crud_Rutas();
            aeropuertos.Show();
        }

        private void btnPais_MouseHover(object sender, EventArgs e)
        {
            panelLed2.Visible = false;
            panelLed3.Visible = false;
            panelLed.Visible = true;
            panelLed.Width = btnPais.Width;
            panelLed.Top = btnPais.Top;
        }

        private void btnPais_MouseLeave(object sender, EventArgs e)
        {
            panelLed.Visible = true;
        }

        private void btnLugar_MouseHover(object sender, EventArgs e)
        {
            panelLed.Visible = false;
            panelLed3.Visible = false;
            panelLed2.Visible = true;
            panelLed2.Width = btnLugar.Width;
            panelLed2.Top = btnLugar.Top;
        }

        private void btnLugar_MouseLeave(object sender, EventArgs e)
        {
            panelLed2.Visible = true;
        }

        private void btnAeropuerto_MouseHover(object sender, EventArgs e)
        {
            panelLed.Visible = false;
            panelLed2.Visible = false;
            panelLed3.Visible = true;
            panelLed3.Width = btnAeropuerto.Width;
            panelLed3.Top = btnAeropuerto.Top;
        }

        private void btnAeropuerto_MouseLeave(object sender, EventArgs e)
        {
            panelLed3.Visible = true;
        }

        private void btnTarijas_Hotel_MouseHover(object sender, EventArgs e)
        {
            panelLed2.Visible = false;
            panelLed3.Visible = false;
            panelLed.Visible = true;
            panelLed.Width = btnTarijas_Hotel.Width;
            panelLed.Top = btnTarijas_Hotel.Top;
        }

        private void btnTarijas_Hotel_MouseLeave(object sender, EventArgs e)
        {
            panelLed.Visible = true;
        }

        private void btnHoteles_MouseHover(object sender, EventArgs e)
        {
            panelLed.Visible = false;
            panelLed3.Visible = false;
            panelLed2.Visible = true;
            panelLed2.Width = btnHoteles.Width;
            panelLed2.Top = btnHoteles.Top;
        }

        private void btnHoteles_MouseLeave(object sender, EventArgs e)
        {
            panelLed2.Visible = true;
        }

        private void btnRutas_MouseHover(object sender, EventArgs e)
        {
            panelLed.Visible = false;
            panelLed2.Visible = false;
            panelLed3.Visible = true;
            panelLed3.Width = btnRutas.Width;
            panelLed3.Top = btnRutas.Top;
        }

        private void btnRutas_MouseLeave(object sender, EventArgs e)
        {
            panelLed3.Visible = true;
        }

        private void btnTarijas_Vuelo_MouseHover(object sender, EventArgs e)
        {
            panelLed2.Visible = false;
            panelLed3.Visible = false;
            panelLed.Visible = true;
            panelLed.Width = btnTarijas_Vuelo.Width;
            panelLed.Top = btnTarijas_Vuelo.Top;
        }

        private void btnTarijas_Vuelo_MouseLeave(object sender, EventArgs e)
        {
            panelLed.Visible = true;
        }

        private void btnVehiculos_MouseHover(object sender, EventArgs e)
        {
            panelLed.Visible = false;
            panelLed3.Visible = false;
            panelLed2.Visible = true;
            panelLed2.Width = btnVehiculos.Width;
            panelLed2.Top = btnVehiculos.Top;
        }

        private void btnVehiculos_MouseLeave(object sender, EventArgs e)
        {
            panelLed2.Visible = true;
        }
    }
}
