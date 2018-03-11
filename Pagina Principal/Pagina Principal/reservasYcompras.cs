﻿using System;
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
    public partial class reservasYcompras : Form
    {
        int cedul;
        string name;
        public reservasYcompras(int cedula, string nombre)
        {
            InitializeComponent();
            cedul = cedula;
            name = nombre;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ver = new Form1();
            ver.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_User ver = new Menu_User(cedul, name);
            ver.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ventana_Calificacion ver = new Ventana_Calificacion();
            ver.Show();
        }
    }
}
