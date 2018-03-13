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
        NpgsqlDataAdapter comando3 = new NpgsqlDataAdapter();
        DataSet infoVuelos = new DataSet();
        NpgsqlDataAdapter comando4 = new NpgsqlDataAdapter();
        DataSet infoVehi = new DataSet();
        NpgsqlDataAdapter comando5 = new NpgsqlDataAdapter();
        DataSet infoHotel = new DataSet();

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

        public void restarVehiculos(int codigo_reserva)
        {///este metodo los que hace es resta la cantidad de habitaciones en los hoteles 
            Int32 cantidad = 0;
            string codigo_ve="";
            try
            {
                connection.Open();
                comandos = new NpgsqlCommand("SELECT re.vehiculo, ve.cantidad FROM reservas AS re JOIN vehiculos AS ve ON re.vehiculo = Cast(ve.codigo as integer) "
                                            + " WHERE re.id_compras_reservas = '" + codigo_reserva + "'", connection);
                NpgsqlDataReader dr = comandos.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        codigo_ve = dr.GetString(0);
                        cantidad = dr.GetInt32(1);
                    }
                }
                connection.Close();

                if (cantidad != 0)
                {
                    int resta = cantidad - 1;

                    connection.Open();
                    comandos = new NpgsqlCommand("UPDATE vehiculos SET cantidad = '" + resta + "' WHERE codigo = '" + codigo_ve + "'", connection);
                    comandos.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("No se pudo conectar." + e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataSet cargarVuelos(int cedula)
        {//este metodo lo que hace es cargar los vuelos del usuario
            infoVuelos.Clear();
            connection = conexion1.Conexion();
            try
            {
                connection.Open();
                comando3 = new NpgsqlDataAdapter("SELECT id_compras_reservas,ini_pais_origen, fin_pais_destino, escalas, vehiculo, total_vuelo, total_vehículo, total_hotel, total_compra, niños, adultos, id_hotel, fecha_inicio, fecha_final, nombre_hotel, duracion_vuelo, canti_habitaciones " +
                    "FROM reservas WHERE cedula= '" + cedula+ "' AND tipo_accion = false ", connection);
                comando3.Fill(infoVuelos);
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("No se pudo conectar." + e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return infoVuelos;
        }
        public DataSet cargarvehiculos(string id_vehi)
        {//este metodo lo que hace es cargar los vehiculos del usuario
            infoVehi.Clear();
            connection = conexion1.Conexion();
            try
            {
                connection.Open();
                comando4 = new NpgsqlDataAdapter("SELECT codigo, marca, modelo, precio, cantidad, capacidad FROM vehiculos WHERE codigo= '" + id_vehi + "'", connection);
                comando4.Fill(infoVehi);
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("No se pudo conectar." + e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return infoVehi;
        }
        public DataSet cargarhotel(int id_ho)
        {//este metodo lo que hace es cargar los hoteles del usuario
            infoHotel.Clear();
            connection = conexion1.Conexion();
            try
            {
                connection.Open();
                comando5 = new NpgsqlDataAdapter("SELECT ho.codigo, ho.nombre, ho.lugar, pa.nombre, ta.precio ,ho.habitaciones FROM hoteles AS ho JOIN lugares AS lu ON ho.lugar = lu.nombre JOIN paises AS pa ON pa.codigo = lu.codigo_pais JOIN tarifas_hoteles AS ta ON ta.codigo = ho.codigotarifahotel WHERE ho.codigo= '" + id_ho + "'", connection);
                comando5.Fill(infoHotel);
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("No se pudo conectar." + e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return infoHotel;
        }
    }
}
