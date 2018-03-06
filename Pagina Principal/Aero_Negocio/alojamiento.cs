using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data_Base;
using Npgsql;

namespace Aero_Negocio
{
    public class alojamiento
    {
        String[] infoHotel = { };
        Alojamientos alo = new Alojamientos();
        static NpgsqlConnection connection;
        Conexio_BaseDatos conexion1 = new Conexio_BaseDatos();
       
        public String[] infoHotels(String datos)
        {
            //infoHotel = alo.buscarEnBase(datos);
            return infoHotel;
        }

        public string TraerInfo(string sql)
        {
            string dato = "";
            try
            {
                connection = conexion1.Conexion();
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand(sql, connection);
                NpgsqlDataReader reader = cmd.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        dato = reader.GetString(0);
                    }
                }
                finally
                {
                    reader.Close();
                    cmd.Dispose();
                    connection.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return dato;
        }
        public void InsertarReserva(string sql)
        {
            try
            {
                connection = conexion1.Conexion();
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error! " + error.Message, "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    

}
