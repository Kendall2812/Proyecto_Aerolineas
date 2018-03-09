using System;
using System.Windows.Forms;
using Aero_Negocio;
using System.Collections.Generic;

namespace Pagina_Principal
{
    public partial class crud_lugares : Form
    {
        Lugares lugar = new Lugares();
        paises cargarPais = new paises();
        List<object> lugares = new List<object>();
        List<object> datosLugar = new List<object>();
        List<object> codigosLugar = new List<object>();
        List<object> paises = new List<object>();
        List<object> codigos_paises = new List<object>();

        public crud_lugares()
        {
            InitializeComponent();
            cargarCombo();
            cargarCombox2();
        }

        public void ingresarLugar()
        {
            try
            {
                Int32 codigo = Convert.ToInt32(txtCodigo.Text);
                string nombre = txtNombre.Text;
                string pais = comboPais3.Text;

                if (nombre.Equals(""))
                {
                    MessageBox.Show("No debe quedar espacios en blaco." , "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {                    
                    if (pais.Equals("Seleccionar"))
                    {
                        MessageBox.Show("Seleccionar otro Item.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        int items = codigos_paises.IndexOf(pais);
                        int coigoPais = Convert.ToInt32(codigos_paises[items - 1]);

                        lugar.insertarLugar(codigo, nombre, coigoPais);
                        txtCodigo.Text = "";
                        txtNombre.Text = "";
                        comboPais3.SelectedItem = "Seleccionar";
                        cargarCombo();
                    }                   
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
                comboPais4.SelectedItem = datosLugar[2].ToString();
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
                string pais2 = comboPais4.Text;
                if (nombre.Equals(""))
                {
                    MessageBox.Show("Error no pueden quedar el espacio del nombre en blanco." + e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {                  
                    if (pais2.Equals("Seleccionar"))
                    {
                        MessageBox.Show("Seleccionar otro Item.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        int items = codigos_paises.IndexOf(pais2);
                        int coigoPais2 = Convert.ToInt32(codigos_paises[items - 1]);

                        lugar.modificarInfo(codigo, nombre, coigoPais2);
                        txtCodigo2.Text = "";
                        txtNombre2.Text = "";
                        comboPais4.SelectedItem = "Seleccionar";
                        cargarCombo();
                    }                   
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

        public void cargarCombox2()
        {
            paises.Clear();
            comboPais3.Items.Clear();
            comboPais4.Items.Clear();

            paises = cargarPais.listaPaises();
            comboPais3.Items.Add("Seleccionar");
            comboPais3.SelectedItem = "Seleccionar";

            comboPais4.Items.Add("Seleccionar");
            comboPais4.SelectedItem = "Seleccionar";


            for (int i = 1; i < paises.Count; i = i + 2)
            {
                comboPais3.Items.Add(paises[i]);
                comboPais4.Items.Add(paises[i]);
            }

            for(int x = 0; x < paises.Count; x++)
            {
                codigos_paises.Add(paises[x]);
            }

            paises.Clear();
        }

        private void comboPais3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
