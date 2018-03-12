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
            infoReservas = reserva.cargarReservas(cedula);
            return infoReservas;
        }
    }
}
