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
        {//este metodo lo que hace es cargar las reservas del usuario
            infoReservas.Clear();
            connection = conexion1.Conexion();
            try
            {
                connection.Open();
                comando2 = new NpgsqlDataAdapter("SELECT re.id_compras_reservas, ho.nombre, re.adultos, re.niños, re.fecha_inicio, re.fecha_final, re.canti_habitaciones, re.total_hotel "
                    + " FROM reservas AS re JOIN hoteles AS ho ON re.id_hotel = ho.codigo \n"
                    + " WHERE re.cedula = '" + cedula + "' AND re.tipo_accion = false ", connection);
                comando2.Fill(infoReservas);
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("No se pudo conectar." + e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return infoReservas;
        }

        public void registrarCompra(int codigo)
        {//este metodo lo que hace pasar el estado de la reserva false a true que es cuando esta comprado
            try
            {
                connection.Open();
                comando2 = new NpgsqlDataAdapter("UPDATE reservas SET tipo_accion = '" + true + "' WHERE id_compras_reservas = '" + codigo + "'", connection);
                comando2.Fill(infoReservas);
                MessageBox.Show("Se registro la compra",  "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("No se pudo conectar." + e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void eliminarRserva(int codigo1)
        {//este metodo borra las reservas del usuario 
            try
            {
                connection.Open();
                comandos = new NpgsqlCommand("DELETE FROM reservas WHERE id_compras_reservas = '" + codigo1 + "'", connection);
                comandos.ExecuteNonQuery();
                MessageBox.Show("Se elimino la reserva", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("No se pudo conectar." + e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void insertarCalificacion(int codigoHotel, int calificacion)
        {//este metodo lo que hace es guardar la calificacion de que el usuario le da a los hoteles 
            try
            {
                connection.Open();
                comandos = new NpgsqlCommand("INSERT INTO calificacion (id_hotel, puntuacion) VALUES ('" + codigoHotel + "', '" + calificacion + "')", connection);
                comandos.ExecuteNonQuery();
                MessageBox.Show("Se registro la calificacion", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("No se pudo conectar." + e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void restarHabitacion_Hotel(int codigo_reserva, int cantiHabit)
        {///este metodo los que hace es resta la cantidad de habitaciones en los hoteles 
            Int32 habitaciones = 0;
            Int32 codigo_Hotel3 = 0;
            try
            {
                connection.Open();
                comandos = new NpgsqlCommand("SELECT re.id_hotel, ho.habitaciones FROM reservas AS re JOIN hoteles AS ho ON re.id_hotel = ho.codigo "
                                            + " WHERE re.id_compras_reservas = '" + codigo_reserva + "'", connection);
                NpgsqlDataReader dr = comandos.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                         codigo_Hotel3 = dr.GetInt32(0);
                         habitaciones = dr.GetInt32(1);
                    }
                }
                connection.Close();

                if (habitaciones != 0)
                {
                    int resta = habitaciones - cantiHabit;

                    connection.Open();
                    comandos = new NpgsqlCommand("UPDATE hoteles SET habitaciones = '" + resta + "' WHERE codigo = '" + codigo_Hotel3 + "'", connection);
                    comandos.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("No se pudo conectar." + e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
