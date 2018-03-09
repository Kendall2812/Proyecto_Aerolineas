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
                cmd = new NpgsqlCommand("SELECT concat(lu.nombre,',',aero.nombre) AS nombre FROM aeropuertos AS aero JOIN lugares AS lu ON aero.localidad = lu.nombre;", connection);
                dr = cmd.ExecuteReader();
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

        public List<object> datosHoteles(string destino, int habi)
        {
            try
            {

                connection = conexion1.Conexion();
                connection.Open();
                cmd = new NpgsqlCommand("SELECT ho.id_hotel, pa.nombre_pais, lu.nombre, ho.nombre_hotel, ho.habitaciones, th.precio, (SELECT AVG(pu.puntuacion) FROM puntuacion AS pu WHERE pu.id_hotelfk = ho.id_hotel) " +
                    "FROM hoteles AS ho INNER JOIN tarifas_hoteles AS th ON ho.preciohab_fk = th.id_tarifa " +
                    "INNER JOIN lugares AS lu ON ho.lugar_fk = lu.id_lugar " +
                    "INNER JOIN paises AS pa ON pa.id_paises = lu.id_paisfk WHERE pa.id_paises = " + destino + " AND ho.habitaciones >= " + habi + ";", connection);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        hotel.Add(dr.GetInt32(0));
                        hotel.Add(dr.GetString(1));
                        hotel.Add(dr.GetString(2));
                        hotel.Add(dr.GetString(3));
                        hotel.Add(dr.GetInt32(4));
                        hotel.Add(dr.GetInt32(5));
                        hotel.Add(dr.GetInt32(6));
                        
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
            return hotel;
        }
           
    }
}

