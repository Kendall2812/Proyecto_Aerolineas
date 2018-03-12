using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace Data_Base
{
    public class DB_Reservas
    {
        DataSet infoReservas = new DataSet();
        static NpgsqlConnection connection;
        static NpgsqlCommand comandos;
        Conexio_BaseDatos conexion1 = new Conexio_BaseDatos();
        NpgsqlDataAdapter comando2 = new NpgsqlDataAdapter();

        public DataSet cargarReservas(int cedula)
        {
            infoReservas.Clear();
            connection = conexion1.Conexion();
            try
            {
                connection.Open();
                comando2 = new NpgsqlDataAdapter("SELECT ho.nombre, re.adultos, re.niños, re.fecha_inicio, re.fecha_final, re.total_hotel "
                    + " FROM reservas AS re JOIN hoteles AS ho ON re.id_hotel = ho.codigo \n"
                    + " WHERE re.cedula = '" + cedula + "'", connection);
                comando2.Fill(infoReservas);
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("No se pudo conectar." + e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return infoReservas;
        }
    }
}
