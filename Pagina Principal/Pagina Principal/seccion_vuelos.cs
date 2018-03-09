using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data_Base;
namespace Pagina_Principal
{
    public partial class Seccion_vuelos : Form
    {
        public string[] destino;
        List<object> hoteles;
       
        public Seccion_vuelos()
        {
            InitializeComponent();
            panelPersonas.Visible = true;
        }

        private void seccion_vuelos_Load(object sender, EventArgs e)
        {
            DB_Vuelos vu =new  DB_Vuelos();
            vu.Autocompletar(textBox1, textBox2);
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            destino = textBox2.Text.Split(',');
           
            if (!destino.Equals(string.Empty) & !habi.Equals(0))
            {
                //hoteles = db_vuelo.Cargar_Hoteles(destino[0], int.Parse(habi.Text));
                dtgHotel.DataSource = hoteles;
                if (hoteles.Count() > 0)
                {
                    dtgHotel.CurrentRow.Selected = false;
                }
            }
            else
            {
                dtgHotel.Columns.Clear();
            }
        }
        
    }
}
