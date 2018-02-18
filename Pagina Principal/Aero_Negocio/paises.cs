using System;
using Data_Base;

namespace Aero_Negocio
{
    public class paises
    {

        public void registro_Pais(int codigo, string nombre, string direccionImagen)
        {
            DB_Pais guardar = new DB_Pais();
            guardar.guardarPais(codigo,nombre,direccionImagen);
        }
    }
}
