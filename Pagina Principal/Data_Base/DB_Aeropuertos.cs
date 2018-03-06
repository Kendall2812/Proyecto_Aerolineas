using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Base
{
    public class DB_Aeropuertos
    {
        static NpgsqlConnection connection;
        static NpgsqlCommand comandos;
        Conexio_BaseDatos conexion1 = new Conexio_BaseDatos();

        public void agregarAeropuerto(Int32 codigo, string nombre,string locali, string iata)
        {
            connection = conexion1.Conexion();
            try
            {
                connection.Open();
                comandos = new NpgsqlCommand("INSERT INTO aeropuertos (id, nombre,localidad,iata) VALUES ('" + codigo + "', '" + nombre + "', '"+locali+ "', '"+iata+ "')", connection);
                comandos.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Se registro con exito.", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception e)
            {
                MessageBox.Show("No se puedo conectar a la base de datos." + e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void MostrarDatosCombo(DataGridViewComboBoxColumn combo)
        {
            connection = conexion1.Conexion();
            connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT nombre FROM lugares order by nombre", connection);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            try
            {
               
                while (reader.Read())
                {
                    combo.Items.Add(reader.GetString(0));
                }
            }
            finally
            {
                reader.Close();
                cmd.Dispose();
                connection.Close();
            }
        }
        public void MostrarDatosTabla(DataGridView data)
        {
           
            connection = conexion1.Conexion();
            connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM aeropuertos order by nombre", connection);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            
            try
            {
                while (reader.Read())
                {
                    data.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));                  
                }

            }
            finally
            {
                reader.Close();
                cmd.Dispose();
                connection.Close();
            }
            data.Refresh();
            data.ClearSelection();
        }
      
        public void ModificarAeropuerto(Int32 codigo, Int32 nuevoCod,string nombre, string locali, string iata)
        {
            connection = conexion1.Conexion();
            try
            {
                connection.Open();
                comandos = new NpgsqlCommand("UPDATE aeropuertos SET id = '" + nuevoCod + "',nombre = '" + nombre + "', iata = '" + iata + "', localidad = '" + locali + "' WHERE id = '" + codigo + "'",connection);
                comandos.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Modificado correctamente!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show("No se puedo conectar a la base de datos." + e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
