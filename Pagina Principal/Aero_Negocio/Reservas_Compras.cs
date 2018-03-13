using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Data_Base;

namespace Aero_Negocio
{
    public class Reservas_Compras
    {
        DB_Reservas reserva = new DB_Reservas();
        List<object> informacion = new List<object>();
        DataSet infoReservas = new DataSet();
        DataSet infoRvuelos = new DataSet();

        public DataSet datos(int cedula)
        {
            infoReservas.Clear();
            infoReservas = reserva.cargarReservas(cedula);
            return infoReservas;
        }
        public void realizarCompra(int codigo)
        {
            reserva.registrarCompra(codigo);
        }

        public void eliminarReserva(int codigo1)
        {
            reserva.eliminarRserva(codigo1);
        }
        public void eliminarReservaVuelo(int codigo1)
        {
            reserva.eliminarRserva(codigo1);
        }

        public DataSet cargarDatosVuelos(int cedula)
        {
            infoRvuelos.Clear();
            infoRvuelos = reserva.cargarVuelos(cedula);
            return infoRvuelos;
        }

        public void calificacion(int codigoHotel, int calificacion)
        {
            reserva.insertarCalificacion(codigoHotel, calificacion);
        }

        public void restarHabitaciones(int codigo_reserva, int cantiHabit)
        {
            reserva.restarHabitacion_Hotel(codigo_reserva, cantiHabit);
        }

        public void restarVehiculos(int codigo_reserva)
        {
            reserva.restarVehiculos(codigo_reserva);
        }
    }
}
