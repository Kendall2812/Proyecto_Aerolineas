﻿using System;
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
        static NpgsqlConnection connection;
        static NpgsqlCommand comandos;
        Conexio_BaseDatos conexion1 = new Conexio_BaseDatos();
        List<object> nombreHotel = new List<object>();
        List<object> infoHotel = new List<object>();
        //, string pais
        public void agregarHoteles(int codigo, string hotel, string lugar, int cantiHabita, string imageHotel, Int32 codigoTarifaHabitacion)
        {
            connection = conexion1.Conexion();
            try
            {
                //, pais
                connection.Open();
                // '" + pais + "' ,
                comandos = new NpgsqlCommand("INSERT INTO hoteles (codigo, nombre, lugar, habitaciones, foto, codigotarifahotel) VALUES ('" + codigo + "', '" + hotel + "', '" + lugar + "', '" + cantiHabita + "', '" + imageHotel + "', '" + codigoTarifaHabitacion + "')", connection);
                comandos.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Se registro con exito.", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error no se pudo conectar a la base de datos. " + e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public void editarHoteles(int codigo2, string hotel2, string lugar2, int cantiHabita2, string imageHotel2, int codigoTarifa)
        {
            //, string pais2
            connection = conexion1.Conexion();
            //, pais = '" + pais2 + "'
            try
            {
                connection.Open();
                comandos = new NpgsqlCommand("UPDATE hoteles SET codigo = '" + codigo2 + "', nombre = '" + hotel2 + "', lugar = '" + lugar2 + "', habitaciones = '" + cantiHabita2 + "', foto = '" + imageHotel2 + "', codigotarifahotel = '" + codigoTarifa + "'  WHERE codigo = '" + codigo2 + "'", connection);
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
                //, hoteles.pais as pais
                comandos = new NpgsqlCommand("SELECT hoteles.codigo as codigo, hoteles.nombre as nombre, hoteles.lugar as lugar, hoteles.habitaciones as habitaciones, hoteles.foto as foto, hoteles.codigotarifahotel as codigotarifahotel," 
                           + " tarifas_hoteles.precio as preacio \n"
                           + " FROM hoteles \n"
                           + " INNER JOIN tarifas_hoteles \n"
                           + " ON hoteles.codigotarifahotel = tarifas_hoteles.codigo \n"
                           + " WHERE hoteles.codigo = '" + codigonombre + "'", connection);
                NpgsqlDataReader dr = comandos.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        infoHotel.Add(dr.GetInt32(0));
                        infoHotel.Add(dr.GetString(1));
                       // infoHotel.Add(dr.GetString(2));
                        infoHotel.Add(dr.GetString(2));
                        infoHotel.Add(dr.GetInt32(3));
                        infoHotel.Add(dr.GetString(4));
                        //infoHotel.Add(dr.GetString(5));
                        infoHotel.Add(dr.GetString(6));
                    }
                    connection.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error no se pudo conectar a la base de datos. " + e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return infoHotel;
        }

        public void eliminarHotel(int codigoHotel)
        {
            connection = conexion1.Conexion();
            try
            {
                connection.Open();
                comandos = new NpgsqlCommand("DELETE FROM hoteles WHERE codigo = '" + codigoHotel + "'", connection);
                comandos.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Se elimino con exito.", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error no se pudo conectar a la base de datos. " + e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
