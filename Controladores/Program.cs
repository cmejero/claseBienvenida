
using ClaseBienvenida.Servicios;

namespace ClaseBienvenida.Controladores
{
    /// <summary>
    /// Clase principal de la aplicación
    /// /// 250923 - cmr
    /// </summary>
    class Program
    {
        /// <summary>
        /// Método de entrada a la aplicación
        /// 250923 - cmr
        /// </summary>
        /// <param name=""></param>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            MenuInterfaz mi = new MenuImplementacion();
            mi.mostrarMensajeBienvenida();

            // variable que controla la entrada y salida del bucle while
            bool cerrarMenu = false;
           //contener la opción del usuario
            int opcionSeleccionada;

            //desde la primera iteración debe cumplirse la condición
            while (!cerrarMenu)
            {
               opcionSeleccionada = mi.mostrarMenuYSeleccion();
                Console.WriteLine(opcionSeleccionada);
               
                switch(opcionSeleccionada)
                {
                    case 0:
                        Console.WriteLine("[INFO] - Se ejecuta caso 0");
                        cerrarMenu = true;
                        break;
                    case 1:
                        Console.WriteLine("[INFO] - Se ejecuta caso 1");
                        break;
                    case 2:
                        Console.WriteLine("[INFO] - Se ejecuta caso 2");
                        break;
                    case 3:
                        Console.WriteLine("[INFO] - Se ejecuta caso 3");
                        break;
                    case 4:
                        Console.WriteLine("[INFO] - Se ejecuta caso 4");
                        break;
                    case 5:
                        Console.WriteLine("[INFO] - Se ejecuta caso 5");
                        break;
                    default:
                        Console.WriteLine("[INFO] - La opción seleccionada no coincide con ninguna");
                        break;
                   
                    }
            }
        }
    }
}