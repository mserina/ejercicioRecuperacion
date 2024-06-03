using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduRecuperacionC.Servicios
{
    /// <summary>
    /// clase que implementa el menu interfaz
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {


        public int menuYSeleccionPrincipal()
        {



            int opcionUsuario;

            Console.WriteLine("############################");
            Console.WriteLine("0. Cerrar Aplicación");
            Console.WriteLine("1. Dar alta alumno");
            Console.WriteLine("2. Borrar alumno");
            Console.WriteLine("3. Mostrar alumnos");
            Console.WriteLine("############################");

            opcionUsuario = Convert.ToInt32(Console.ReadLine());
            return opcionUsuario;





        }

    }
}
