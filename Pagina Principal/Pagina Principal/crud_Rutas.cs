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
    public partial class crud_Rutas : Form
    {
        List<object> paises = new List<object>();
        paises cargarPais = new paises();
        Rutas rutas = new Rutas();

        public crud_Rutas()
        {
            InitializeComponent();
            cargarCombox();
        }

        private void crud_aeropuertos_Load(object sender, EventArgs e)
        {
            
        }

        public void cargarCombox()
        {
            comboPaisOrigen.Items.Clear();
            paises = cargarPais.listaPaises();
            comboPaisOrigen.Items.Add("Seleccionar");
            comboPaisOrigen.SelectedItem = "Seleccionar";
            comboPaisDestino.Items.Add("Seleccionar");
            comboPaisDestino.SelectedItem = "Seleccionar";

            for (int i = 0; i < paises.Count; i++)
            {
                comboPaisOrigen.Items.Add(paises[i]);
                comboPaisDestino.Items.Add(paises[i]);
            }
            paises.Clear();
        }

        public void registarRuta()
        {
            try
            {
                Int32 codigo = Convert.ToInt32(txtCodigoR.Text);
                string paisOrigen = comboPaisOrigen.Text;
                string paisDestino = comboPaisDestino.Text;
                string duracion = Horas.Value.ToString("hh:mm");
                if (paisOrigen.Equals(paisDestino))
                {
                    MessageBox.Show("El país de Destino debe ser digente del de Origen.", "Adventencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Rutas guardarRuta = new Rutas();
                    guardarRuta.insertarRuta(codigo, paisOrigen, paisDestino, duracion);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("El codigo de la ruta debe ser numerico y no debe quedar en espacios blancos.", "Adventencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Window_Admin regresar = new Window_Admin();
            regresar.Show();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            registarRuta();
        }

        private void txtCodigoR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
