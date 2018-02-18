using System;
using Data_Base;
using System.Collections.Generic;

namespace Aero_Negocio
{
    public class paises
    {
        DB_Pais guardar = new DB_Pais();
        List<object> nombres = new List<object>();
        List<object> infopais = new List<object>();

        public void registro_Pais(int codigo, string nombre, string direccionImagen)
        {
            guardar.guardarPais(codigo,nombre,direccionImagen);
        }

        public List<object> listaPaises()
        {
            nombres = guardar.nombrePais();
            return nombres;
        }

        public List<object> infoPais(string pais)
        {
            infopais = guardar.informPais(pais);
            return infopais;
        }

        public void modificarPais(int codigo, string nombre, string direccionImagen)
        {
            guardar.infoModificada(codigo,nombre,direccionImagen);
        }

        public void eliminarPais(int codigo)
        {
            guardar.eliminarPais(codigo);
        }
    }
}
