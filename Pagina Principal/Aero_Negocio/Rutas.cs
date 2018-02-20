using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Base;

namespace Aero_Negocio
{
    public class Rutas
    {
        public void insertarRuta(int codigo, string rutaOrigen, string rutaDestino, string duracion)
        {
            DB_Rutas registrar = new DB_Rutas();
            registrar.agregarRuta(codigo, rutaOrigen, rutaDestino, duracion);
        }

        public void modificarRuta()
        {

        }

        public void eliminarRuta()
        {

        }
    }
}
