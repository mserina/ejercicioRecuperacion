using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduRecuperacionC.Servicios
{
    /// <summary>
    ///  clase que se encarga de la operativa de la aplicación
    /// </summary>
    internal interface OperativaInterfaz
    {
        /// <summary>
        /// metodo que se encarga de dar alta un nuevo alumno
        /// </summary>
        public void darAlta();

        /// <summary>
        /// metodo que se encarga de borrar un alumno
        /// </summary>
        public void borrarAlumno();

        /// <summary>
        /// metodo que se encarga de mostrar los alumnos de la lista alumnos
        /// </summary>
        public void mostrarAlumnos();
    }
}
