using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduRecuperacionC.Servicios
{
    /// <summary>
    /// clase que se encarga de mostrar los menus de la aplicación
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// metodo que se encarga de mostrar el menu principal de la aplicación
        /// </summary>
        /// <returns></returns>
        public int menuYSeleccionPrincipal();
    }
}
