using System;
using System.Collections.Generic;
using Data_Base;
using Npgsql;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace Data_Base
{
    public class DB_Hoteles
    {
        Byte[] ImgBytes;
        static NpgsqlConnection connection;
        static NpgsqlCommand comandos;
        Conexio_BaseDatos conexion1 = new Conexio_BaseDatos();
        List<object> nombreHotel = new List<object>();
        List<object> infoHotel = new List<object>();
        //NpgsqlDataAdapter comando2 = new NpgsqlDataAdapter();

        public void agregarHoteles(int codigo, string hotel, string pais, string lugar, int cantiHabita, string imageHotel)
        {
            connection = conexion1.Conexion();
            try
            {
                connection.Open();
                comandos = new NpgsqlCommand("INSERT INTO hoteles (codigo, nombre, pais, lugar, habitaciones, foto) VALUES ('" + codigo + "', '" + hotel + "', '" + pais + "' ,'" + lugar + "', '" + cantiHabita + "', '" + imageHotel + "')", connection);
                comandos.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Se registro con exito.", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error no se pudo conectar a la base de datos. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<object> infoHoteles()
        {
            connection = conexion1.Conexion();
            try
            {
                connection.Open();
                comandos = new NpgsqlCommand("SELECT codigo, nombre FROM hoteles", connection);
                NpgsqlDataReader dr = comandos.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        nombreHotel.Add(dr.GetInt32(0));
                        nombreHotel.Add(dr.GetString(1));
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error no se pudo conectar a la base de datos. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return nombreHotel;
        }

        public void editarHoteles(int codigo2, string hotel2, string pais2, string lugar2, int cantiHabita2, string imageHotel2)
        {
            connection = conexion1.Conexion();
            try
            {
                connection.Open();
                comandos = new NpgsqlCommand("UPDATE hoteles SET codigo = '" + codigo2 + "', nombre = '" + hotel2 + "', pais = '" + pais2 + "', lugar = '" + lugar2 + "', habitaciones = '" + cantiHabita2 + "', foto = '" + imageHotel2 + "'  WHERE codigo = '" + codigo2 + "'", connection);
                comandos.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Se modifico con exito.", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception e)
            {
                MessageBox.Show("No se puedo conectar a la base de datos." + e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<object> datosHotel(Int32 codigonombre)
        {
            connection = conexion1.Conexion();
            try
            {
                connection.Open();
                comandos = new NpgsqlCommand("SELECT codigo, nombre, pais, lugar, habitaciones, foto FROM hoteles WHERE codigo = '" + codigonombre + "'", connection);
                NpgsqlDataReader dr = comandos.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        infoHotel.Add(dr.GetInt32(0));
                        infoHotel.Add(dr.GetString(1));
                        infoHotel.Add(dr.GetString(2));
                        infoHotel.Add(dr.GetString(3));
                        infoHotel.Add(dr.GetInt32(4));
                        infoHotel.Add(dr.GetString(5));
                       //Bitmap imagen = null;
                       //Byte[] bytes = (Byte[])(ImgBytes);
                       //MemoryStream ms = new MemoryStream(dr.GetByte(5));
                       //imagen = new Bitmap(ms);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error no se pudo conectar a la base de datos. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return infoHotel;
        }
    }
}
