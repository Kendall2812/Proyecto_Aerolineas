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
            try
            {
                string tipo_user;
                String usuario = txtNombre.Text;
                int clave = Convert.ToInt32(txtPassword.Text);
                if (usuario.Equals("") && clave.Equals(""))
                {
                    MessageBox.Show("No pueden quedar espacios vacios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Users consultar = new Users();
                    tipo_user = consultar.encriptar_clave(usuario, clave);
                    if (tipo_user.Equals("T"))
                    {
                        //vetana administrado
                        this.Hide();
                        Window_Admin admin = new Window_Admin();
                        admin.Show();

                    }
                    else if (tipo_user.Equals("U"))
                    {
                        //vetana usuario
                        this.Hide();
                        Form2 ver = new Form2();
                        ver.Show();
                    }
                    else
                    {
                        MessageBox.Show("No se encontro el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No pueden quedar espacios vacios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
