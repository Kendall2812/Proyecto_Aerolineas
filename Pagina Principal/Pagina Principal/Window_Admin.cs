using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pagina_Principal
{
    public partial class Window_Admin : Form
    {
        public Window_Admin()
        {
            InitializeComponent();
            panelPais.Controls.Add(crudPaises1);
        }

        private void button9_MouseHover(object sender, EventArgs e)
        {
            button9.ForeColor = Color.Aqua;
        }

        private void button9_MouseLeave(object sender, EventArgs e)
        {
            button9.ForeColor = Color.White;
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
            panelLed.Height = btnPais.Height;
            panelLed.Top = btnPais.Top;
            panelPais.Controls.Add(crudPaises1);
            crudPaises1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelLed.Height = btnLugar.Height;
            panelLed.Top = btnLugar.Top;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelLed.Height = btnAeropuerto.Height;
            panelLed.Top = btnAeropuerto.Top;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelLed.Height = btnRutas.Height;
            panelLed.Top = btnRutas.Top;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panelLed.Height = btnHoteles.Height;
            panelLed.Top = btnHoteles.Top;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panelLed.Height = btnTarijas_Hotel.Height;
            panelLed.Top = btnTarijas_Hotel.Top;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panelLed.Height = btnTarijas_Vuelo.Height;
            panelLed.Top = btnTarijas_Vuelo.Top;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panelLed.Height = btnVehiculos.Height;
            panelLed.Top = btnVehiculos.Top;
        }
    }
}
