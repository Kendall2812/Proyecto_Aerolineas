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
    public partial class Menu_User : Form
    {
        int cedula;
        string nom;
        public Menu_User(int cedu, string nombre)
        {
            InitializeComponent();
            cedula = cedu;
            nom = nombre;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            reservasYcompras re = new reservasYcompras(cedula, nom);
            re.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 ver = new Form2(cedula, nom);
            ver.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Seccion_vuelos ver = new Seccion_vuelos(cedula, nom);
            ver.Show();

        }
    }
}
