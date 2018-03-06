using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Windows.Forms;
using Npgsql;


namespace Data_Base
{
    public class DB_Vehiculo
    {
        static NpgsqlConnection connection;
        static NpgsqlCommand comandos;
        Conexio_BaseDatos conexion1 = new Conexio_BaseDatos();
        DataSet cargarDatos = new DataSet();
        NpgsqlDataAdapter comando2 = new NpgsqlDataAdapter();
        List<object> nombreTarifaVuelo = new List<object>();
        bool varlor = false;

        public bool insertarVehiculo(Int32 placa, string marca, string modelo, string estilo, Int32 precio, Int32 cantidad)
        {
            connection = conexion1.Conexion();
            try
            {
                connection.Open();
                comandos = new NpgsqlCommand("INSERT INTO vehiculos (codigo, marca, modelo, estilo, precio, cantidad) VALUES ('" + placa + "', '" + marca + "', '" + modelo + "' ,'" + estilo + "', '" + precio + "', '" + cantidad + "')", connection);
                comandos.ExecuteNonQuery();
                varlor = true;
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error no se pudo conectar a la base de datos. " + e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                varlor = false;
            }

            return varlor;
        }

        public bool modificarVehiculo(Int32 placa2, string marca2, string modelo2, string estilo2, Int32 precio2, Int32 cantidad2)
        {
            connection = conexion1.Conexion();
            try
            {
                connection.Open();
                comandos = new NpgsqlCommand("UPDATE vehiculos SET codigo = '" + placa2 + "', marca = '" + marca2 + "', modelo = '" + modelo2 + "', estilo = '" + estilo2 + "', precio = '" + precio2 + "', cantidad = '" + cantidad2 + "' WHERE codigo = '" + placa2 + "'", connection);
                comandos.ExecuteNonQuery();
                varlor = true;
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error no se pudo conectar a la base de datos. " + e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                varlor = false;
            }

            return varlor;
        }

        public bool eliminarVehiculo(Int32 placa3)
        {
            connection = conexion1.Conexion();
            try
            {
                connection.Open();
                comandos = new NpgsqlCommand("DELETE FROM vehiculos WHERE codigo = '" + placa3 + "'", connection);
                comandos.ExecuteNonQuery();
                varlor = true;
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error no se pudo conectar a la base de datos. " + e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                varlor = false;
            }

            return varlor;
        }

        public DataSet InfoVehiculo()
        {
            cargarDatos.Clear();
            connection = conexion1.Conexion();
            try
            {
                connection.Open();
                comando2 = new NpgsqlDataAdapter("SELECT codigo, marca, modelo, estilo, precio, cantidad FROM vehiculos ", connection);
                comando2.Fill(cargarDatos);
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("No se pudo conectar." + e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return cargarDatos;
        }
    }
}
