using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Data_Base
{
    public class DB_Reportes
    {
        List<object> nombre = new List<object>();
        List<object> segundoReporte = new List<object>();
        static NpgsqlConnection connection;
        static NpgsqlCommand comandos;
        Conexio_BaseDatos conexion1 = new Conexio_BaseDatos();
        NpgsqlDataAdapter comando2 = new NpgsqlDataAdapter();

        public List<object> hoteles()
        {
            connection = conexion1.Conexion();
            try
            {
                connection.Open();
                comandos = new NpgsqlCommand("Select nombre_hotel FROM reservas;", connection);
                NpgsqlDataReader dr = comandos.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        nombre.Add(dr.GetString(0));
                    }
                }
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error no se pudo conectar a la base de datos. " + e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return nombre;
        }

        public List<object> SegundoReporte()
        {
            segundoReporte.Clear();

            connection = conexion1.Conexion();
            try
            {
                connection.Open();
                comandos = new NpgsqlCommand("SELECT ho.nombre, (re.niños + re.adultos) FROM reservas AS re JOIN hoteles AS ho ON re.id_hotel = ho.codigo AND re.tipo_accion = true", connection);
                NpgsqlDataReader dr = comandos.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        segundoReporte.Add(dr.GetString(0));
                        segundoReporte.Add(dr.GetInt32(1));
                    }
                }
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error no se pudo conectar a la base de datos. " + e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return segundoReporte;
        }
    }
}
