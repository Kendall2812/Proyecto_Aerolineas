using System;
using System.Windows.Forms;
using Aero_Negocio;
using System.Collections.Generic;

namespace Pagina_Principal
{
    public partial class crud_lugares : Form
    {
        Lugares lugar = new Lugares();
        List<object> lugares = new List<object>();
        List<object> datosLugar = new List<object>();
        List<object> codigosLugar = new List<object>();

        public crud_lugares()
        {
            InitializeComponent();
            cargarCombo();
        }

        public void ingresarLugar()
        {
            try
            {
                Int32 codigo = Convert.ToInt32(txtCodigo.Text);
                string nombre = txtNombre.Text;
                if (nombre.Equals(""))
                {
                    MessageBox.Show("No debe quedar espacios en blaco." , "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    lugar.insertarLugar(codigo, nombre);
                    txtCodigo.Text = "";
                    txtNombre.Text = "";
                    cargarCombo();
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("No debe quedar espacios en blaco.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ingresarLugar();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        public void cargarCombo()
        {
            codigosLugar.Clear();
            combo1Lugar.Items.Clear();
            lugares = lugar.lugares1();
            combo1Lugar.Items.Add("Seleccionar");
            combo1Lugar.SelectedItem = "Seleccionar";
            for (int i = 1; i < lugares.Count; i=i+2)
            {
                combo1Lugar.Items.Add(lugares[i]);
            }

            for (int x = 0; x < lugares.Count; x++)
            {
                codigosLugar.Add(lugares[x]);
            }
            lugares.Clear();
        }

        public void cargarDatos()
        {
            string lugarSelect;
            lugarSelect = combo1Lugar.SelectedItem.ToString();
            if (lugarSelect.Equals("Seleccionar"))
            {
                txtCodigo2.Text = "";
                txtNombre2.Text = "";

                MessageBox.Show("Seleccionar otro Item.");
            }
            else
            {
                int items = codigosLugar.IndexOf(lugarSelect);
                int codigo = Convert.ToInt32(codigosLugar[items - 1]);

                txtCodigo2.Text = "";
                txtNombre2.Text = "";
                datosLugar.Clear();
                datosLugar = lugar.cargarDatos1(codigo);

                txtCodigo2.Text = datosLugar[0].ToString();
                txtNombre2.Text = datosLugar[1].ToString();
            }
        }

        private void combo1Lugar_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void btnGuarda2_Click(object sender, EventArgs e)
        {
            try
            {
                Int32 codigo = Convert.ToInt32(txtCodigo2.Text);
                string nombre = txtNombre2.Text;
                if (nombre.Equals(""))
                {
                    MessageBox.Show("Error no pueden quedar el espacio del nombre en blanco." + e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    lugar.modificarInfo(codigo, nombre);
                    txtCodigo2.Text = "";
                    txtNombre2.Text = "";
                    cargarCombo();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error no pueden quedar el espacio del nombre en blanco." + e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Int32 codigo = Convert.ToInt32(txtCodigo2.Text);
            lugar.eliminar(codigo);
            txtCodigo2.Text = "";
            txtNombre2.Text = "";
            cargarCombo();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Window_Admin ver = new Window_Admin();
            ver.Show();
        }
    }
}
