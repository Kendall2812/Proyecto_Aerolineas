using System;
using System.Windows.Forms;
using Aero_Negocio;

namespace Pagina_Principal
{
    public partial class window_registry : Form
    {
        public window_registry()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 principal = new Form1();
            principal.Show();
        }

        public void registro()
        {
            try
            {
                Users registro = new Users();
                Int32 cedula = Convert.ToInt32(txtCedula.Text);
                string nombre = txtNombre.Text;
                string clave = txtClave.Text;

                if (BoxAdministrador.Checked)
                {
                    string tipo = "T";
                    Console.WriteLine("hola");
                    registro.registrar(cedula, nombre, clave,tipo);
                }
                else
                {
                    string tipo = "U";
                    Console.WriteLine("hola2");
                    registro.registrar(cedula, nombre, clave, tipo);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No pueden quedar espacios vacios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            registro();
        }
    }
}
