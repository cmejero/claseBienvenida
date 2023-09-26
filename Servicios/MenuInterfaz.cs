using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseBienvenida.Servicios
{
    
    /// <summary>
    /// Interfaz con la relación de métodos de la funcionalidad menú
    /// 250923 - cmr
    /// </summary>
    internal interface MenuInterfaz
    {
      
        /// <summary>
        /// Muestra el mensaje de bienvenida al cajero.
        /// 200923 - cmr
        /// </summary>
        public void mostrarMensajeBienvenida();
        /// <summary>
        /// Método que muestra el menú y recoge la selección del usuario
        /// 260923 - cmr
        /// </summary>
        /// <returns>un entero con la opción seleccionada</returns>
        public int mostrarMenuYSeleccion();
    }

}
