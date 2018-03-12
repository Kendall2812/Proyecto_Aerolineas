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

        public DataSet cargarDatosVuelos(int codigo2)
        {
            infoReservas.Clear();
            //infoReservas = 
            return infoReservas;
        }
    }
}
