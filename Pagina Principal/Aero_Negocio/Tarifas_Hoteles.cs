using System;
using System.Collections.Generic;
using System.Data;
using Data_Base;

namespace Aero_Negocio
{
    public class Tarifas_Hoteles
    {
        DataSet rellenar = new DataSet();
        List<object> infoTarifas = new List<object>();
        DB_Tarifas_Hoteles tarifas = new DB_Tarifas_Hoteles();

        public void insertarTarifa(Int32 codigo, Int32 precio)
        {
            tarifas.insertarTarifa(codigo, precio);
        }

        public void modificarTarifa(Int32 codigo2, Int32 precio2)
        {
            tarifas.editarTarifa(codigo2, precio2);
        }

        public void eliminarTarifa(int codigo)
        {
            tarifas.eliminarTarifa(codigo);
        }

        public DataSet cargarTarifa_GriedView()
        {
            rellenar = tarifas.cargarTarifas_GriedView();
            return rellenar;
        }

        public List<object> datosTarifas()
        {
            infoTarifas = tarifas.infoTarifas();
            return infoTarifas;
        }
    }
}
