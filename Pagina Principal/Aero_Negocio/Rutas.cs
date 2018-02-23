using Data_Base;
using System.Data;

namespace Aero_Negocio
{
    public class Rutas
    {
        DataSet rellenar = new DataSet();
        DB_Rutas registrar = new DB_Rutas();

        public void insertarRuta(int codigo, string rutaOrigen, string rutaDestino, string duracion)
        {
            registrar.agregarRuta(codigo, rutaOrigen, rutaDestino, duracion);
        }

        public void modificarRuta(int codigo, string rutaOrigen, string rutaDestino, string duracion)
        {
            registrar.editarRuta(codigo,rutaOrigen,rutaDestino,duracion);
        }

        public void eliminarRuta(int codigo)
        {
            registrar.eliminarRuta(codigo);
        }

        public DataSet cargarGriedView()
        {
            rellenar = registrar.CargarDataGried();
            return rellenar;
        }
    }
}
