using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduRecuperacionC.Servicios
{

    /// <summary>
    /// clase que se encarga de los metodos relaciondos con ficheros
    /// </summary>
    internal interface FicherosInterfaz
    {
        /// <summary>
        /// metodo que se encarga de escribir en un fichero.
        /// </summary>
        /// <param name="mensaje"></param>
        public void escribirFichero(string mensaje);


        /// <summary>
        /// metodo que se encarga en escribir en fichero los alumnos de la lista
        /// </summary>
        public void escribirAlumnos();

        /// <summary>
        /// Metodo que lee el fichero de alumnos y carga los alumnos a la lista
        /// msm - 030624
        /// </summary>
        public void cargaIncial();

    }
}
