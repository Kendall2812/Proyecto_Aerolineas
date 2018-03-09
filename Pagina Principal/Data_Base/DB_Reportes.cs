using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Data_Base
{
    public class DB_Reportes
    {
        List<object> nombre = new List<object>();
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
            catch (Exception)
            {

            }
            return nombre;
        }
    }
}
