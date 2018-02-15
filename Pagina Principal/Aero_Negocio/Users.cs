using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Base;
using System.Windows.Forms;

namespace Aero_Negocio
{
    public class Users
    {
        static void Main(string[] args)
        {
        }

        public bool encriptar_clave(string user, string clave)
        {
            //encripta la contraseña
            bool respuesta;
            string resultado = string.Empty;
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(clave);
            resultado = Convert.ToBase64String(encryted);
            Console.WriteLine(resultado);

            UserAdmin consultar = new UserAdmin();
            respuesta = consultar.cosultarUsuario(user, resultado);

            return respuesta;
        }

        public void desencriptar_clave(string user, string clave)
        {
            //desencriotar contraseña
            string resultado2 = string.Empty;
            byte[] decryted = Convert.FromBase64String(clave);
            resultado2 = System.Text.Encoding.Unicode.GetString(decryted, 0, decryted.ToArray().Length);
            resultado2 = System.Text.Encoding.Unicode.GetString(decryted);
            Console.WriteLine(resultado2);
        }
    }
}
