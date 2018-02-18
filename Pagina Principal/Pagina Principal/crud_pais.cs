using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Aero_Negocio;

namespace Pagina_Principal
{
    public partial class crud_pais : Form
    {
        string[] paths = { };
        paises cargarBox = new paises();
        List<object> paises2 = new List<object>();
        List<object> Infopaises = new List<object>();
        bool valor = false;
        paises guardar = new paises();

        public crud_pais()
        {
            InitializeComponent();
            imagenes(valor);
            cargarCombo();
        }

        private void crud_pais_Load(object sender, EventArgs e)
        {

            listView1.View = View.Details;
            listView1.Columns.Add("Banderas", 150);
            listView1.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);

            listView2.View = View.Details;
            listView2.Columns.Add("Banderas", 150);
            listView2.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);

            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(this.listView2, "Haga clik en el nombre de la columna para editar la bandera.");
            toolTip1.SetToolTip(this.btnEliminar, "Eliminar País."); 
            toolTip1.SetToolTip(this.txtCodigo2, "No se puede editar.");
        }

        private void imagenes(bool valor)
        {
            ImageList image = new ImageList();
            image.ImageSize = new Size(50, 50);
            paths = Directory.GetFiles("C:/Users/Kendall/source/repos/Proyecto_Aerolineas/Banderas");
            try
            {
                foreach (string path in paths)
                {
                    image.Images.Add(Image.FromFile(path));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error no se puedo cargar imagenes." + e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (valor == false)
            {
                listView1.SmallImageList = image;
                listView1.Items.Add("Costa Rica", 0);
                listView1.Items.Add("Mexico", 1);
                listView1.Items.Add("Panama", 2);
            }

            if (valor == true)
            {
                listView2.SmallImageList = image;
                listView2.Items.Add("Costa Rica", 0);
                listView2.Items.Add("Mexico", 1);
                listView2.Items.Add("Panama", 2);
            }

        }

        private void btnRegistrar_Pais_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text;
                Int32 codigo = Convert.ToInt32(txtCodigo.Text);
                int indice_image = listView1.SelectedIndices[0];
                if (nombre == "" && codigo != 0)
                {
                    MessageBox.Show("Error no pueden quedar espacios en blanco." + e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Console.WriteLine(nombre);
                    string direccion_imagen = paths.ElementAtOrDefault(indice_image);
                    guardar.registro_Pais(codigo, nombre, direccion_imagen);
                    txtCodigo.Text = "";
                    txtNombre.Text = "";
                    listView1.Items.Clear();
                    imagenes(valor);
                }
                cargarCombo();

            }
            catch (Exception)
            {
                MessageBox.Show("Error debe seleccionar una bandera y no dejar espacios en blanco.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
 
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Window_Admin ver = new Window_Admin();
            ver.Show();
        }

        public void cargarCombo()
        {
            comboPais.Items.Clear();
            paises2 = cargarBox.listaPaises();
            comboPais.Items.Add("Seleccionar");
            comboPais.SelectedItem = "Seleccionar";
            for (int i = 0; i < paises2.Count; i++)
            {
                comboPais.Items.Add(paises2[i]);
            }
            paises2.Clear();
        }

        public void editarPais()
        {
            string paisSelect;
            paisSelect = comboPais.SelectedItem.ToString();
            if (paisSelect.Equals("Seleccionar"))
            {
                txtCodigo.Text = "";
                txtNombre.Text = "";

                MessageBox.Show("Seleccionar otro Item.");
            }
            else
            {
                ImageList image = new ImageList();
                txtCodigo2.Text = "";
                txtNombre2.Text = "";
                image.Images.Clear();
                listView2.Items.Clear();
                Infopaises.Clear();
                Infopaises = cargarBox.infoPais(paisSelect);

                txtCodigo2.Text = Infopaises[0].ToString();
                txtNombre2.Text = Infopaises[1].ToString();
                image.ImageSize = new Size(50, 50);
                image.Images.Add(Image.FromFile(Infopaises[2].ToString()));
                listView2.SmallImageList = image;
                listView2.Items.Add(Infopaises[1].ToString(), 0);
            }
        }

        private void comboPais_SelectionChangeCommitted(object sender, EventArgs e)
        {
            editarPais();
        }

        private void btnGuardar2_Click(object sender, EventArgs e)
        {
            try
            {
                Int32 codigo = Convert.ToInt32(txtCodigo2.Text);
                string nombre = txtNombre2.Text;
                int indice_image = listView2.SelectedIndices[0]; //obtine el indice de la imagen
                string direccion_imagen = paths.ElementAtOrDefault(indice_image);//con el indice busca la direccion de la imagen
                if(nombre == "")
                {
                    MessageBox.Show("Error no pueden quedar el espacio del nombre en blanco." + e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    guardar.modificarPais(codigo,nombre,direccion_imagen);
                    txtCodigo2.Text = "";
                    txtNombre2.Text = "";
                    listView2.Items.Clear();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error debe seleccionar una bandera.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Int32 codigo = Convert.ToInt32(txtCodigo2.Text);
            guardar.eliminarPais(codigo);
            cargarCombo();
            txtCodigo2.Text = "";
            txtNombre2.Text = "";
            listView2.Items.Clear();
        }

        private void listView2_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            bool valor = true;
            listView2.Items.Clear();
            imagenes(valor);
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
    }
}
