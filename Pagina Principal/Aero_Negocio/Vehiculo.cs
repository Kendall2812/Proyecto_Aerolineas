using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Data_Base;
using System.Data;

namespace Aero_Negocio
{
    public class Vehiculo
    {
        DB_Vehiculo carro = new DB_Vehiculo();
        DataSet infoVehiculo = new DataSet();
        private DataGridView datosCarros = new DataGridView();
        bool respuesta = false;

        public void InsertarCarro(string placa, string marca, string modelo, string estilo, string precio, string cantidad)
        {
            Int32 costoPorDia = Convert.ToInt32(precio);
            Int32 cantidad1 = Convert.ToInt32(cantidad);
            if (placa.Equals("") || marca.Equals("") || modelo.Equals("") || estilo.Equals("") || costoPorDia == 0 || cantidad1 == 0)
            {
                MessageBox.Show("Ningun espacio puede quedar vacio. ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Int32 matricula = Convert.ToInt32(placa);
                respuesta = carro.insertarVehiculo(matricula, marca, modelo, estilo, costoPorDia, cantidad1);
                if (respuesta == true)
                {
                    MessageBox.Show("Se registro con exito.", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("No se pudo registrar el vehiculo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void ModificarCarro(string placa2, string marca2, string modelo2, string estilo2, string precio2, string cantidad2)
        {
            Int32 costoPorDia = Convert.ToInt32(precio2);
            Int32 cantidad1 = Convert.ToInt32(cantidad2);
            if (placa2.Equals("") || marca2.Equals("") || modelo2.Equals("") || estilo2.Equals("") || costoPorDia == 0 || cantidad1 == 0)
            {
                MessageBox.Show("No pueden pueden quedar espacios en blanco.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Int32 matricula = Convert.ToInt32(placa2);
                respuesta = carro.modificarVehiculo(matricula, marca2, modelo2, estilo2, costoPorDia, cantidad1);
                if (respuesta == true)
                {
                    MessageBox.Show("Se modifico con exito.", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("No se pudo modificar la informacion del vehiculo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void EliminarCarrro(string placa3)
        {
            Int32 placa4 = Convert.ToInt32(placa3);
            respuesta = carro.eliminarVehiculo(placa4); 
            if (respuesta == true)
            {
                MessageBox.Show("Se elimino con exito.", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("No se pudo eliminar el vehiculo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataSet cargarDataGriedView()
        {
            infoVehiculo = carro.InfoVehiculo();
            return infoVehiculo;
        }
    }
}
