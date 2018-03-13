using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Base;

namespace Aero_Negocio
{
    public class Reportes
    {
        DB_Reportes reporte = new DB_Reportes();
        List<object> Hoteles = new List<object>();
        List<object> segundoReporte = new List<object>();

        public List<object> PrimerReporte()
        {
            Hoteles = reporte.hoteles();
            return Hoteles;
        }

        public List<object> SegundoReporte()
        {
            segundoReporte = reporte.SegundoReporte();
            return segundoReporte;
        }
    }
}
