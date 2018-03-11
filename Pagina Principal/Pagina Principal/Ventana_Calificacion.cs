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
    public partial class Ventana_Calificacion : Form
    {
        public Ventana_Calificacion()
        {
            InitializeComponent();
            
        }

        private void Ventana_Calificacion_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String mensaje = "";
            if (radioButton1.Checked)
            {
                mensaje = "1";
            }
            else if (radioButton2.Checked)
            {
                mensaje = "2";
            }
            else if (radioButton3.Checked)
            {
                mensaje = "3";
            }
            else if (radioButton4.Checked)
            {
                mensaje = "4";
            }
            else if (radioButton5.Checked)
            {
                mensaje = "5";
            }
            MessageBox.Show(mensaje);
            this.Hide();
        }
        
    }
}
