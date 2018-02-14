using System;
using System.Windows.Forms;
using Aero_Negocio;

namespace Pagina_Principal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void verificarUser()
        {
            bool tipo_user;
            String usuario = txtNombre.Text;
            String clave = txtPassword.Text;
            if (usuario.Equals("") && clave.Equals(""))
            {
                MessageBox.Show("No pueden quedar espacios vacios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Negocio consultar = new Negocio();
                tipo_user = consultar.encriptar_clave(usuario, clave);
                if (tipo_user == true)
                {
                    //vetana administrado
                }
                else
                {
                    //vetana usuario
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            verificarUser();
        }
    }
}
