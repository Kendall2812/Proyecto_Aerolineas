using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using Data_Base;
using Npgsql;

namespace Data_Base
{
    public class Alojamientos
    {
        NpgsqlCommand cmd;
        NpgsqlConnection conexion;

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
                cmd = new NpgsqlCommand("Select nombre from aeropuertos", conexion);               
                NpgsqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cajaTexto.AutoCompleteCustomSource.Add(dr["nombre"].ToString());
                }
                dr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo autocompletar el TextBox: " + ex.ToString());
            }
        }
    }
}

