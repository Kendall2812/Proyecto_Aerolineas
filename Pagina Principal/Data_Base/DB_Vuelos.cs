using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Base
{
    public class DB_Vuelos
    {
       
        NpgsqlCommand cmd;
        NpgsqlDataReader dr;
        static NpgsqlConnection connection;
        Conexio_BaseDatos conexion1 = new Conexio_BaseDatos();
        List<object> hotel = new List<object>();
        public void Autocompletar(TextBox Origen, TextBox Destino)
        {
            try
            {
                connection = conexion1.Conexion();
                connection.Open();
                cmd = new NpgsqlCommand("SELECT concat(pa.nombre, ', ', lu.nombre,', ' , ae.nombre) " +
                    "AS nombre FROM aeropuertos AS ae JOIN lugares AS lu ON ae.localidad = lu.nombre JOIN paises AS pa ON pa.codigo = lu.codigo_pais;", connection);
                NpgsqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Origen.AutoCompleteCustomSource.Add(dr[0].ToString());
                        Destino.AutoCompleteCustomSource.Add(dr[0].ToString());
                    }
                }

                dr.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                dr.Close();
                connection.Close();
            }
        }

        public List<object> datosHoteles(string destino, int habi, string pais,DataGridView tablaHotel)
        {
            try
            {
                connection = conexion1.Conexion();
                connection.Open();
                cmd = new NpgsqlCommand("SELECT ho.codigo, ho.nombre, pa.nombre, lu.nombre, ho.habitaciones, th.precio, (SELECT AVG(pu.puntuacion) FROM calificacion AS pu WHERE pu.id_hotel = ho.codigo)" +
                    "FROM hoteles AS ho JOIN tarifas_hoteles AS th ON ho.codigotarifahotel = th.codigo JOIN lugares AS lu ON ho.lugar = lu.nombre" +
                    "JOIN paises AS pa ON pa.codigo = lu.codigo_pais WHERE pa.nombre = "+pais+ " AND ho.habitaciones >="+habi+" AND ho.lugar = "+destino+";", connection);
                NpgsqlDataReader dre = cmd.ExecuteReader();
                if (dre.HasRows)
                {
                    while (dre.Read())
                    {
                        hotel.Add(dre.GetInt32(0));
                        hotel.Add(dre.GetString(1));
                        hotel.Add(dre.GetString(2));
                        hotel.Add(dre.GetString(3));
                        hotel.Add(dre.GetInt32(4));
                        hotel.Add(dre.GetInt32(5));
                        hotel.Add(dre.GetInt32(6));
                        tablaHotel.Rows.Add(dre.GetInt32(0), dre.GetString(1), dre.GetString(2), dre.GetString(3), dre.GetInt32(4), dre.GetInt32(5), dre.GetInt32(6));
                    }

                }
                dre.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return hotel;
        }

        public List<object> CargarVehi(int personas, DataGridView tablaVehi)
        {
            List<object> vehiculos = new List<object>();
            try
            {
                connection = conexion1.Conexion();
                connection.Open();
                cmd = new NpgsqlCommand("SELECT codigo,marca,modelo, estilo, cantidad, precio FROM vehiculos WHERE cantidad >= " + personas + ";", connection);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        vehiculos.Add(dr.GetString(0));
                        vehiculos.Add(dr.GetString(1));
                        vehiculos.Add(dr.GetString(2));
                        vehiculos.Add(dr.GetString(3));
                        vehiculos.Add(dr.GetInt32(4));
                        vehiculos.Add(dr.GetInt32(5));
                        tablaVehi.Rows.Add(dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetInt32(4), dr.GetInt32(5));
                    }
                }
                dr.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                dr.Close();
                connection.Close();
            }
            return vehiculos;
        }


        public string escala_Directo(string pais_origen, string pais_destino)
        {
            string final = null;
            string paiso = null;
            connection = conexion1.Conexion();
            connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT pais_origen FROM ruta WHERE pais_destino = '" + pais_destino + "'", ConexionBD.conexion);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    paiso = (reader.GetString(0));
                }

            }
            finally
            {
                reader.Close();
                cmd.Dispose();
                ConexionBD.conexion.Close();
            }

            if (paiso != pais_origen)
            {
                final = paiso + ", " + pais_destino;
            }
            else
            {
                final = "Vuelo Directo";
            }

            return final;
        }
    }

   
}

