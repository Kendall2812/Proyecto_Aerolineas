using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using Data_Base;
using Npgsql;
using System.Data;
using System.Drawing;

namespace Data_Base
{
    public class Alojamientos
    {
        NpgsqlCommand cmd;
        NpgsqlConnection conexion;
        static NpgsqlConnection connection;
        static NpgsqlCommand comandos;
        Conexio_BaseDatos conexion1 = new Conexio_BaseDatos();
        String [] infomacion= new String[] { };

        public Alojamientos()
        {
            try
            {
                string servidor = "localhost";
                int puerto = 5432;
                string usuario = "postgres";
                string clave = "postgres";
                string baseDatos = "Aeropuertos";//nombre de la base en la que voy a trabajar

                string cadenaConexion = "Server=" + servidor + ";" + "Port=" + puerto + ";" + "User Id=" + usuario + ";" + "Password=" + clave + ";" + "Database=" + baseDatos;
                conexion = new NpgsqlConnection(cadenaConexion);
                conexion.Open();
                MessageBox.Show("conectado");

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo conectar: " + ex.ToString());
            }
        }

        public void autoCompletar(TextBox cajaTexto)
        {
            try
            {
                cmd = new NpgsqlCommand("SELECT nombre, pais, lugar FROM hoteles ", conexion);
                NpgsqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cajaTexto.AutoCompleteCustomSource.Add(dr["nombre"].ToString() + "," + dr["pais"].ToString() + "," + dr["lugar"].ToString());
                }
                dr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo autocompletar el TextBox: " + ex.ToString());
            }
        }


        public void cargarDatos(string dato, DataGridView dataGridView1)
        {
            try
            {
                connection = conexion1.Conexion();
                connection.Open();
                comandos = new NpgsqlCommand("SELECT h.codigo, h.nombre, h.pais, h.lugar, h.foto, t.precio FROM hoteles AS h " +
                    "JOIN tarifas_hoteles AS t ON h.codigotarifahotel= t.codigo", connection);
                NpgsqlDataReader dr = comandos.ExecuteReader();
              
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        if (dato.Equals(dr.GetString(1)))
                        {
                            Image img = Image.FromFile(@dr.GetString(4));
                            //THEN AD ROW DATA           
                            Object[] row = new Object[] { dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(5), img };
                            dataGridView1.Rows.Add(row);
                        }else if (dato.Equals(dr.GetString(2)) || dato.Equals(dr.GetString(3)))
                        {
                            Image img = Image.FromFile(@dr.GetString(4));
                            //THEN AD ROW DATA           
                            Object[] row = new Object[] { dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(5), img };
                            dataGridView1.Rows.Add(row);
                        }
             
                    }
                    connection.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error no se pudo conectar a la base de datos. " + e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }
    }

}
    


