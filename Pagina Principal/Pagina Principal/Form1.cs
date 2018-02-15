using System;
using System.Drawing;
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
                Users consultar = new Users();
                tipo_user = consultar.encriptar_clave(usuario, clave);
                if (tipo_user == true)
                {
                    //vetana administrado
                    MessageBox.Show("Entro");
                }
                else
                {
                    //vetana usuario
                    MessageBox.Show("No Entro");
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            verificarUser();
        }

        private void btnCerrar_MouseDown(object sender, MouseEventArgs e)
        {
            string message = "Desea cerrar la aplicación";
            string captura = "Advertencia";
            MessageBoxButtons boton = MessageBoxButtons.YesNo;
            MessageBoxIcon boton2 = MessageBoxIcon.Warning;
            DialogResult result;

            result = MessageBox.Show(message, captura, boton, boton2);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnCerrar_MouseHover(object sender, EventArgs e)
        {
            btnCerrar.ForeColor = Color.White;
        }

        private void btnCerrar_MouseLeave(object sender, EventArgs e)
        {
            btnCerrar.ForeColor = Color.SkyBlue;
        }
    }
}
