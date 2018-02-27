using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Base;

namespace Aero_Negocio
{
    public class Lugares
    {
        DB_Lugar lugar1 = new DB_Lugar();
        List<object> nombre = new List<object>();
        List<object> datos = new List<object>();

        public void insertarLugar(Int32 codigo, string lugar)
        {
            lugar1.agregarLugar(codigo, lugar);
        }

        public List<object> lugares1()
        {
            nombre = lugar1.cargarLugares();
            return nombre;
        }

        public List<object> cargarDatos1(Int32 codigolugar)
        {
            datos = lugar1.cargarDatos(codigolugar);
            return datos;
        }

        public void modificarInfo(int codigo, string lugar)
        {
            lugar1.infoModificada(codigo, lugar);
        }

        public void eliminar(Int32 codigo2)
        {
            lugar1.eliminarPlace(codigo2);
        }

    }
}
