using System;
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
        //List<string> paths = new List<string>();
        public crud_pais()
        {
            InitializeComponent();
            imagenes();
        }

        private void crud_pais_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.Columns.Add("Banderas", 150);
            listView1.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void imagenes()
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

            listView1.SmallImageList = image;
            listView1.Items.Add("Costa Rica", 0);
            listView1.Items.Add("Mexico", 1);
            listView1.Items.Add("Panama", 2);
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
                    paises guardar = new paises();
                    guardar.registro_Pais(codigo, nombre, direccion_imagen);
                }
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
    }
}
