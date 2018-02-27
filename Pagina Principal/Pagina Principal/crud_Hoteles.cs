using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using Aero_Negocio;
using System.Collections.Generic;

namespace Pagina_Principal
{
    public partial class crud_Hoteles : Form
    {
        string direccion = "";
        Hoteles hotel = new Hoteles();
        paises cargarPais = new paises();
        Lugares lugares = new Lugares();
        Tarifas_Hoteles tarifas = new Tarifas_Hoteles();
        List<object> paises = new List<object>();
        List<object> lugar = new List<object>();
        List<object> Hoteles1 = new List<object>();
        List<object> InfoHoteles = new List<object>();
        List<object> CodigoHoteles = new List<object>();
        List<object> precioHabitacion = new List<object>();
        List<object> codigosHabitacion = new List<object>();

        public crud_Hoteles()
        {
            InitializeComponent();
            cargarCombox2();
            cargarComboLugar();
            cargarNombreHoteles();
            cargarPrecioHabitacion();
        }

        public void guardarInfo()
        {
            try
            {
                Int32 codigo = Convert.ToInt32(txtCodigo3.Text);
                string nombre = txtNombre3.Text;
                string pais = comboPais3.Text;
                string lugar = comboLugar3.Text;
                Int32 codigoTarifa = Convert.ToInt32(comboPrecioHabitacion.Text);
                int catiHabitacion = Convert.ToInt32(numericUp3.Value.ToString());

                if (nombre.Equals("") || pais.Equals("Seleccionar") || pais.Equals("") || lugar.Equals("") || lugar.Equals("Seleccionar") || catiHabitacion.Equals(0) || direccion.Equals("") || codigoTarifa == 0)
                {
                    MessageBox.Show("Ningun espacio puede quedar vacio. Las cantidad de las habitaciones tiene que ser direntes de 0. Debe seleccionar una imagen. País y Lugar no pueden quedar con seleccionar." , "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    int items = codigosHabitacion.IndexOf(codigoTarifa);
                    int precioTarifa = Convert.ToInt32(codigosHabitacion[items - 1]);

                    hotel.insertarHotel(codigo,nombre,pais,lugar,catiHabitacion, direccion, precioTarifa);
                    cargarNombreHoteles();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Ningun espacio puede quedar vacio. Las cantidad de las habitaciones tiene que ser direntes de 0. Debe seleccionar una imagen. País y Lugar no pueden quedar con seleccionar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardarInfo();
        }

        public void abrirImagen()
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new
                System.IO.StreamReader(openFileDialog1.FileName);
                direccion = openFileDialog1.FileName;
                sr.Close();
            }
        }

        private void FotoHotel_Click(object sender, EventArgs e)
        {
            abrirImagen();
            if (direccion != "")
            {
                Imagenhotel.Image = Image.FromFile(direccion);
            }
        }

        public void cargarPrecioHabitacion()
        {
            precioHabitacion.Clear();
            codigosHabitacion.Clear();
            precioHabitacion = tarifas.datosTarifas();

            comboPrecioHabitacion.Items.Add("Seleccionar");
            comboPrecioHabitacion.SelectedItem = "Seleccionar";

            comboTarifaHotel1.Items.Add("Seleccionar");
            comboTarifaHotel1.SelectedItem = "Seleccionar";

            for (int i = 1; i < precioHabitacion.Count; i = i+2)
            {
                comboPrecioHabitacion.Items.Add(precioHabitacion[i]);
                comboTarifaHotel1.Items.Add(Convert.ToString(precioHabitacion[i]));
            }

            for (int x = 0; x < precioHabitacion.Count; x++)
            {
                codigosHabitacion.Add(precioHabitacion[x]);
            }
            precioHabitacion.Clear();
        }

        public void cargarCombox2()
        {
            paises.Clear();
            comboPais3.Items.Clear();
            comboPais2.Items.Clear();

            paises = cargarPais.listaPaises();
            comboPais3.Items.Add("Seleccionar");
            comboPais3.SelectedItem = "Seleccionar";

            comboPais2.Items.Add("Seleccionar");
            comboPais2.SelectedItem = "Seleccionar";

            for (int i = 1; i < paises.Count; i=i+2)
            {
                comboPais3.Items.Add(paises[i]);
                comboPais2.Items.Add(paises[i]);

            }
            paises.Clear();
        }

        public void cargarComboLugar()
        {
            lugar.Clear();

            comboLugar3.Items.Clear();
            comboLugar2.Items.Clear();

            lugar = lugares.lugares1();
            comboLugar3.Items.Add("Seleccionar");
            comboLugar3.SelectedItem = "Seleccionar";

            comboLugar2.Items.Add("Seleccionar");
            comboLugar2.SelectedItem = "Seleccionar";

            for (int i = 1; i < lugar.Count; i=i+2)
            {
                comboLugar3.Items.Add(lugar[i]);
                comboLugar2.Items.Add(lugar[i]);
            }
            lugar.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Window_Admin regresar = new Window_Admin();
            regresar.Show();
        }

        public void cargarNombreHoteles()
        {
            CodigoHoteles.Clear();
            comboBox1.Items.Clear();
            Hoteles1 = hotel.nombre();
            comboBox1.Items.Add("Seleccionar");
            comboBox1.SelectedItem = "Seleccionar";
            for (int i = 1; i < Hoteles1.Count; i = i+2)
            {
                comboBox1.Items.Add(Hoteles1[i]);
            }

            for (int x = 0; x < Hoteles1.Count; x++)
            {
                CodigoHoteles.Add(Hoteles1[x]);
            }
            Hoteles1.Clear();
        }

        public void cargarInfo()
        {
            string NomHotel;
            NomHotel = comboBox1.SelectedItem.ToString();
            if (NomHotel.Equals("Seleccionar"))
            {
                MessageBox.Show("Seleccionar otro Item.");
            }
            else
            {
                int items = CodigoHoteles.IndexOf(NomHotel);
                int codigo = Convert.ToInt32(CodigoHoteles[items - 1]);
                
                txtCodigo2.Text = "";
                txtNombre2.Text = "";
                InfoHoteles.Clear();
                InfoHoteles = hotel.cargarDatos(codigo);
                if (InfoHoteles.Count != 0) {

                    txtCodigo2.Text = InfoHoteles[0].ToString();
                    txtNombre2.Text = InfoHoteles[1].ToString();

                    if (comboTarifaHotel1.Items.Contains(InfoHoteles[6].ToString()))
                    {
                        comboTarifaHotel1.SelectedItem = InfoHoteles[6].ToString();
                    }
                    else
                    {
                        comboTarifaHotel1.Items.Add(InfoHoteles[6].ToString());
                    }

                    if (comboPais2.Items.Contains(InfoHoteles[2].ToString()))
                    {
                        comboPais2.SelectedItem = InfoHoteles[2].ToString();
                    }
                    else
                    {
                        comboPais2.Items.Add(InfoHoteles[2].ToString());
                    }

                    if (comboLugar2.Items.Contains(InfoHoteles[3].ToString()))
                    {
                        comboLugar2.SelectedItem = InfoHoteles[3].ToString();
                    }
                    else
                    {
                        comboLugar2.Items.Add(InfoHoteles[3].ToString());
                    }

                    numericUp2.Value = Convert.ToInt32(InfoHoteles[4]);

                    pictureBox2.Image = Image.FromFile(Convert.ToString(InfoHoteles[5]));

                    direccion = InfoHoteles[5].ToString();
                }
            }
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cargarInfo();
        }

        public void modificarHotel()
        {
            try
            {
                Int32 codigo = Convert.ToInt32(txtCodigo2.Text);
                string nombre = txtNombre2.Text;
                string pais = comboPais2.Text;
                string lugar = comboLugar2.Text;
                int tarifaHabitacion = Convert.ToInt32(comboTarifaHotel1.Text);
                int catiHabitacion = Convert.ToInt32(numericUp2.Value.ToString());

                if (nombre.Equals("") || pais.Equals("")|| pais.Equals("Seleccionar") || lugar.Equals("") || lugar.Equals("Seleccionar") || catiHabitacion.Equals(0) || direccion.Equals("") || tarifaHabitacion == 0)
                {
                    MessageBox.Show("Ningun espacio puede quedar vacio. Las cantidad de las habitaciones tiene que ser direntes de 0. Debe seleccionar una imagen. País y Lugar no pueden quedar con seleccionar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    int items = codigosHabitacion.IndexOf(tarifaHabitacion);
                    int precioTarifa = Convert.ToInt32(codigosHabitacion[items - 1]);

                    hotel.modificarHotal(codigo, nombre, pais, lugar, catiHabitacion, direccion, precioTarifa);
                    cargarNombreHoteles();

                    txtCodigo2.Text = "";
                    txtNombre2.Text = "";
                    comboPais2.SelectedItem = "Seleccionar";
                    comboLugar2.SelectedItem = "Seleccionar";
                    comboTarifaHotel1.SelectedItem = "Seleccionar";
                    numericUp2.Value = 0;
                    direccion = "";
                    pictureBox2.Image = null;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ningun espacio puede quedar vacio. Las cantidad de las habitaciones tiene que ser direntes de 0. Debe seleccionar una imagen. País y Lugar no pueden quedar con seleccionar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnGuardar2_Click(object sender, EventArgs e)
        {
            modificarHotel();
        }

        private void FotoHotel2_Click(object sender, EventArgs e)
        {
            abrirImagen();
            if (direccion != "")
            {
                pictureBox2.Image = Image.FromFile(direccion);
            }
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCodigo2.Text = "";
            txtNombre2.Text = "";
            comboPais2.SelectedItem = "Seleccionar";
            comboLugar2.SelectedItem = "Seleccionar";
            comboBox1.SelectedItem = "Seleccionar";
            comboTarifaHotel1.SelectedItem = "Seleccionar";
            numericUp2.Value = 0;
            direccion = "";
            pictureBox2.Image = null;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Int32 codigo = Convert.ToInt32(txtCodigo2.Text);
                hotel.eliminarHotel(codigo);
                cargarNombreHoteles();
                txtCodigo2.Text = "";
                txtNombre2.Text = "";
                comboPais2.SelectedItem = "Seleccionar";
                comboLugar2.SelectedItem = "Seleccionar";
                comboBox1.SelectedItem = "Seleccionar";
                comboTarifaHotel1.SelectedItem = "Seleccionar";
                numericUp2.Value = 0;
                direccion = "";
                pictureBox2.Image = null;
            }
            catch (Exception)
            {
                MessageBox.Show("Debe haber seleccionado un Hotel para eliminarlo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                txtCodigo2.Text = "";
                txtNombre2.Text = "";
                comboPais2.SelectedItem = "Seleccionar";
                comboLugar2.SelectedItem = "Seleccionar";
                comboBox1.SelectedItem = "Seleccionar";
                comboTarifaHotel1.SelectedItem = "Seleccionar";
                numericUp2.Value = 0;
                direccion = "";
                pictureBox2.Image = null;
            }
        }
    }
}