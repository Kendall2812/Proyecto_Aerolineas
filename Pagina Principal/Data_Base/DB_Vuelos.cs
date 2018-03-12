using Npgsql;
using System;
using System.Collections;
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
                    "FROM hoteles AS ho JOIN tarifas_hoteles AS th ON ho.codigotarifahotel = th.codigo JOIN lugares AS lu ON ho.lugar = lu.nombre " +
                    "JOIN paises AS pa ON pa.codigo = lu.codigo_pais WHERE pa.nombre = '"+ pais + "' and ho.habitaciones >= '" + habi + "'", connection); // AND ho.habitaciones >= '" + habi + "' AND ho.lugar = '" + destino + "'
                //' and ho.lugar = '" + destino + "
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
                        //hotel.Add(dre.GetInt32(6));
                        tablaHotel.Rows.Add(dre.GetInt32(0), dre.GetString(1), dre.GetString(2), dre.GetString(3), dre.GetInt32(4), dre.GetInt32(5));//, dre.GetInt32(6)
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


        public string escala_vuelo_Directo(string pais_origen, string p_destino)
        {
            string termina = null;
            string paisorigen = null;

            paisorigen = TraerInfo("SELECT pais_origen FROM rutas WHERE pais_destino = '" + p_destino + "'");
              
            if (paisorigen != pais_origen)
            {
                termina = paisorigen + ", " + p_destino;
            }
            else
            {
                termina = "Directo";
            }      
            return termina;
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


        public ArrayList Escala_en_paises(string pais_origen, string pais_destino)
        {
            string termina = null;
            string paisorigen = null;
            ArrayList paises = new ArrayList();
            connection = conexion1.Conexion();
            connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT pais_origen FROM rutas WHERE pais_destino = '" + pais_destino + "'", connection);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    paises.Add(reader.GetString(0));
                }
            }
            finally
            {
                reader.Close();
                cmd.Dispose();
                connection.Close();
            }
            if (paisorigen != pais_origen)
            {
                termina = paisorigen;
            }
            else
            {
                termina = "Directo";
            }
            return paises;
        }

        public ArrayList escalas_vuelo(string pais_destino)
        {          
            ArrayList escalas = new ArrayList();
            connection = conexion1.Conexion();
            connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT pais_origen FROM rutas WHERE pais_destino = '" + pais_destino + "'",connection);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    escalas.Add(reader.GetString(0) + "," + pais_destino);
                }
            }
            finally
            {
                reader.Close();
                cmd.Dispose();
                connection.Close();
            }

            return escalas;
        }

    }

   
}

