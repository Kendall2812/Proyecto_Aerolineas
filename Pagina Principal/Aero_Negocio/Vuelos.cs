using Data_Base;
using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aero_Negocio
{
    public class Vuelos
    {          
        static NpgsqlConnection connection;
        Conexio_BaseDatos conexion1 = new Conexio_BaseDatos();

        public ArrayList precioEscala(string destino)
        {
            ArrayList preciosrutas = new ArrayList();
            ArrayList precioTotal = new ArrayList();

            connection = conexion1.Conexion();
            connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT tv.precio FROM tarijas_vuelos as tv join rutas as ru on ru.codigo = tv.codigo_ruta WHERE ru.pais_destino = '" + destino + "'", connection);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    preciosrutas.Add(reader.GetInt32(0));
                }
            }
            finally
            {
                reader.Close();
                cmd.Dispose();
                connection.Close();
            }
            for (int i = 0; i < preciosrutas.Count; i++)
            {
                precioTotal.Add((Convert.ToInt32(preciosrutas[i]) / 2) + Convert.ToInt32(preciosrutas[i]));
            }
            return precioTotal;
        }

        public ArrayList duracionEscala(string destinoVuelo)
        {
            ArrayList duracionVuelo = new ArrayList();
            connection = conexion1.Conexion();
            connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT ru.duracion FROM rutas as ru WHERE ru.pais_destino = '" + destinoVuelo + "'", connection);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    duracionVuelo.Add(reader.GetString(0));
                }
            }
            finally
            {
                reader.Close();
                cmd.Dispose();
                connection.Close();
            }
            return duracionVuelo;
        }

        public void mostrarInfo(DataGridView tablaVuelos, string origen, string destino, string directo, ArrayList paises, ArrayList escalas, ArrayList preciosescalas, ArrayList dura, int pasajeros, int habi)
        {
            if (directo == "Directo")
            {
                connection = conexion1.Conexion();
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT ru.pais_origen, ru.pais_destino, tv.precio,ru.duracion FROM rutas as ru JOIN tarijas_vuelos as tv on tv.codigo_ruta = ru.codigo " +
                    "WHERE ru.pais_origen = '" + origen + "' AND pais_destino = '" + destino + "'",connection);
                NpgsqlDataReader reader = cmd.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        tablaVuelos.Rows.Add(reader.GetString(0), reader.GetString(1), directo, reader.GetString(1), reader.GetString(0), directo, reader.GetInt32(2), 0, reader.GetString(3), pasajeros, habi);
                    }

                }
                finally
                {
                    reader.Close();
                    cmd.Dispose();
                    connection.Close();
                }
            }
            else
            {
                for (int i = 0; i < paises.Count; i++)
                {
                    tablaVuelos.Rows.Add(origen, destino, escalas[i], destino, origen, escalas[i], preciosescalas[i], dura[i], 0, pasajeros, habi);
                }
            }
            tablaVuelos.Refresh();
            tablaVuelos.ClearSelection();
        }

    }
}
