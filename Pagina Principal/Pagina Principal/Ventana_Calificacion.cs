using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aero_Negocio;

namespace Pagina_Principal
{
    public partial class Ventana_Calificacion : Form
    {
        int codigo = 0;
        Reservas_Compras calificar = new Reservas_Compras();

        public Ventana_Calificacion(int codigoHotel)
        {
            InitializeComponent();
            codigo = codigoHotel;
        }

        private void Ventana_Calificacion_Load(object sender, EventArgs e)
        {

        }

        public void calificarHotel()
        {
            int calificacion = 0;
            if (radioButton1.Checked)
            {
                calificacion = 1;
            }
            else if (radioButton2.Checked)
            {
                calificacion = 2;
            }
            else if (radioButton3.Checked)
            {
                calificacion = 3;
            }
            else if (radioButton4.Checked)
            {
                calificacion = 4;
            }
            else if (radioButton5.Checked)
            {
                calificacion = 5;
            }

            calificar.calificacion(codigo, calificacion);
            //MessageBox.Show(mensaje);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calificarHotel();
            this.Hide();
        }
        
    }
}
