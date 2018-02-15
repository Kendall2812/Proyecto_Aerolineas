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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void numericUpDown1_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(numericUpDown1, 1, numericUpDown1.Height);
        }

       
    }  
}
