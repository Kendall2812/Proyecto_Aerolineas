﻿using System;
using Data_Base;
using System.Collections.Generic;

namespace Aero_Negocio
{
    public class Hoteles
    {
        DB_Hoteles hotel2 = new DB_Hoteles();
        List<object> nombreHotel = new List<object>();
        List<object> datosHotel = new List<object>();
        //, string pais
        public void insertarHotel(int codigo, string hotel, string lugar, int cantiHabita, string imageHotel, Int32 codigoTarifa)
        {
            hotel2.agregarHoteles(codigo, hotel, lugar, cantiHabita, imageHotel, codigoTarifa);
            ///, pais
        }

        //, string pais2
        public void modificarHotal(int codigo2, string hotel3, string lugar2, int cantiHabita2, string imageHotel2, int codigoTarifa)
        {
            hotel2.editarHoteles(codigo2, hotel3, lugar2, cantiHabita2, imageHotel2, codigoTarifa);
            //, pais2
        }

        public void eliminarHotel(int codigo)
        {
            hotel2.eliminarHotel(codigo);
        }

        public List<object> cargarDatos(int codigoHotel)
        {
            datosHotel = hotel2.datosHotel(codigoHotel);
            return datosHotel;
        }

        public List<object> nombre()
        {
            nombreHotel = hotel2.infoHoteles();
            return nombreHotel;
        }
    }
}
