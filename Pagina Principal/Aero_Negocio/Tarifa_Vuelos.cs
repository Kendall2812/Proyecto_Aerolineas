using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data;
using System.Threading.Tasks;
using Data_Base;

namespace Aero_Negocio
{
    public class Tarifa_Vuelos
    {
        DB_Tarifas_Vuelos vuelos = new DB_Tarifas_Vuelos();
        DataSet rellenar = new DataSet();
        bool repeticionCodigo = false;

        public void insertarTarifaVuelo(string codigoTarifa0, string codigoRuta0, string precioTarifaPersona0)
        {
            try
            {
                Int32 codigoTarifa = Convert.ToInt32(codigoTarifa0);
                Int32 codigoRuta = Convert.ToInt32(codigoRuta0);
                Int32 precioXPersona = Convert.ToInt32(precioTarifaPersona0);
                if (codigoTarifa != 0 && precioXPersona != 0)
                {
                    repeticionCodigo = vuelos.cosultarCodigoRuta(codigoRuta);
                    if (repeticionCodigo == false)
                    {
                        vuelos.insertarTarifaVuelo(codigoTarifa, codigoRuta, precioXPersona);
                    }else if (repeticionCodigo == true)
                    {
                        MessageBox.Show("Esta ruta se encuentra registrada con un precio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No pueden quedar espacios en blanco.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            
        }

        public void modificarTarifaVuelo(Int32 codigoTarifa1, Int32 codigoRuta1, Int32 precioTarifaPersona1)
        {
            vuelos.modificarTarifaVuelo(codigoTarifa1, codigoRuta1, precioTarifaPersona1);
        }

        public void eliminarTarifaVuelo(Int32 codigoTarifa)
        {
            vuelos.eliminarTarifaVuelo(codigoTarifa);
        }

        public DataSet cargarDatosTarifas()
        {
            rellenar = vuelos.cargarDatosTarifasVuelos();
            return rellenar;
        }

        public bool prueba(Int32 codigoTarifa, Int32 codigoRuta)
        {
            bool verificacion = vuelos.verificacion(codigoTarifa, codigoRuta);

            return verificacion;
        }
    }
}
