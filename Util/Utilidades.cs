using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduRecuperacionC.Util
{
    /// <summary>
    /// clase que contiene metodos donde se usa varias veces en el proyecto
    /// </summary>
    internal static class Utilidades
    {
        /// <summary>
        /// metodo que se encarga de crear el nombre del fichero log
        /// </summary>
        /// <returns></returns>
        public static string crearNombreLog()
        {
            string fecha = "9";
            try
            {
                DateTime fechaActual = DateTime.Now;

                string fechaString = fechaActual.ToString("ddMMyy");

                fecha = String.Concat("log-", fechaString, ".txt");



            }
            catch (Exception ex)
            {

                Console.WriteLine("Se ha producido un error aplicación (error 1000)");

            }
            return fecha;

        }

    }
}
