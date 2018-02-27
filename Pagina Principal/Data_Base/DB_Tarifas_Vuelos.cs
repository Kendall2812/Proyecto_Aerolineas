using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data;
using System.Threading.Tasks;
using Npgsql;

namespace Data_Base
{
    public class DB_Tarifas_Vuelos
    {
        static NpgsqlConnection connection;
        static NpgsqlCommand comandos;
        Conexio_BaseDatos conexion1 = new Conexio_BaseDatos();
        DataSet cargarDatos = new DataSet();
        NpgsqlDataAdapter comando2 = new NpgsqlDataAdapter();
        List<object> nombreTarifaVuelo = new List<object>();
        List<object> infoTarifaVuelo = new List<object>();

        public void insertarTarifaVuelo(Int32 codigoTarifa, Int32 codigoRuta, Int32 precioTarifaPersona)
        {
            connection = conexion1.Conexion();
            try
            {
                connection.Open();
                comandos = new NpgsqlCommand("INSERT INTO tarijas_vuelos (codigo_vuelo,codigo_ruta,precio) VALUES ('" + codigoTarifa + "', '" + codigoRuta + "', '" + precioTarifaPersona + "')", connection);
                comandos.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Se registro con exito.", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error no se pudo conectar a la base de datos. " + e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void modificarTarifaVuelo(Int32 codigoTarifa2, Int32 codigoRuta2, Int32 precioTarifaPersona2)
        {
            connection = conexion1.Conexion();
            try
            {
                connection.Open();
                comandos = new NpgsqlCommand("UPDATE tarijas_vuelos SET codigo_vuelo = '" + codigoTarifa2 + "', codigo_ruta = '" + codigoRuta2 + "', precio = '" + precioTarifaPersona2 + "'  WHERE codigo_vuelo = '" + codigoTarifa2 + "'", connection);
                comandos.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Se modifico con exito.", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error no se pudo conectar a la base de datos. " + e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void eliminarTarifaVuelo(Int32 codigoTarifa3)
        {
            connection = conexion1.Conexion();
            try
            {
                connection.Open();
                comandos = new NpgsqlCommand("DELETE FROM tarijas_vuelos WHERE codigo_vuelo = '" + codigoTarifa3 + "'", connection);
                comandos.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Se elimino con exito.", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error no se pudo conectar a la base de datos. " + e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataSet cargarDatosTarifasVuelos()
        {
            cargarDatos.Clear();
            connection = conexion1.Conexion();
            try
            {
                connection.Open();
                comando2 = new NpgsqlDataAdapter("SELECT tarijas_vuelos.codigo_vuelo as codigo_vuelo, tarijas_vuelos.precio as precio,"  
                       + " rutas.codigo as codigo ,rutas.pais_origen as pais_origen, rutas.pais_destino as pais_destino, rutas.duracion as duracion \n"
                       + " FROM tarijas_vuelos \n"
                       + " INNER JOIN rutas \n"
                       + " ON rutas.codigo = tarijas_vuelos.codigo_ruta ", connection);

                comando2.Fill(cargarDatos);
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("No se pudo conectar." + e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return cargarDatos;
            //, tarijas_vuelos.codigo_ruta as codigo_ruta
        }

        public bool cosultarCodigoRuta(Int32 codigoRuta)
        {
            bool valor = false;
            connection = conexion1.Conexion();
            try
            {
                connection.Open();
                comandos = new NpgsqlCommand("SELECT * FROM tarijas_vuelos WHERE codigo_ruta ='" + codigoRuta + "'", connection);
                NpgsqlDataReader dr = comandos.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        valor = true;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("No se pudo conectar." + e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return valor;
        }

        public bool verificacion(Int32 codigoTarifa, Int32 codigoRuta)
        {
            bool verificado = false;
            connection = conexion1.Conexion();
            try
            {
                connection.Open();
                comandos = new NpgsqlCommand("SELECT codigo_vuelo, codigo_ruta FROM tarijas_vuelos", connection);
                NpgsqlDataReader dr = comandos.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Int32 codigotarifa1 = dr.GetInt32(0);
                        Int32 codigoruta1 = dr.GetInt32(1);

                        if (codigotarifa1 != codigoTarifa)
                        {
                            if (codigoruta1 == codigoRuta)
                            {
                                verificado = true;
                                break;
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("No se pudo conectar." + e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return verificado;
        }
    }
}
