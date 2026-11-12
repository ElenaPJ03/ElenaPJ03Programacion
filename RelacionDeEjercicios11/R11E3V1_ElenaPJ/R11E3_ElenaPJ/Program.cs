using System.ComponentModel.Design;

namespace R11E3_ElenaPJ
{
    internal class Program
    {
        // Diseñar un algoritmo que muestre un menú por pantalla para que el usuario seleccione el tipo de figura a mostrar por pantalla.

        static void Main(string[] args)
        {
            // CONSTANTES

            // VARIABLES
            byte opcionSeleccionada = 0;

            // ENTRADA
            // Mostrar el menú de opciones
            opcionSeleccionada = MostrarMenu();

            // PROCESO
            // No hay proceso en este programa

            // SALIDA
            // Mostrar la figura elegida por el usuario o el error correspondiente
            MostrarOpcion(opcionSeleccionada);
        }

        #region MÉTODO ENTRADA DE DATOS
        static public byte MostrarMenu()
        {
            // CONSTANTES
            const int MIN_OPCION = 1;   // 1 es la primera opcion del menu
            const int MAX_OPCION = 5;    // 5 es la ultima opcion del menu

            // VARIABLES
            byte valorOpcion = 0;
            string cadena = "";
            bool esCorrecto = true;
            byte codError = 0;      // 0 -> No hay error
                                    // 1 -> No es un número valido
                                    // 2 -> Fuera de rango (del 1 al 5)
            do
            {
                codError = 0;

                // ENTRADA - Solicitud de la opción
                Console.WriteLine("Selecciona la opción de la figura que deseas ver:");
                Console.WriteLine("1. Triángulo");
                Console.WriteLine("2. Escuadra");
                Console.WriteLine("3. Escuadra2");
                Console.WriteLine("4. Pirámide invertida");
                Console.WriteLine("5. Pirámide");
                Console.Write("Introduce una opción: ");

                cadena = Console.ReadLine();

                // PROCESO - Validación 
                esCorrecto = Byte.TryParse(cadena, out valorOpcion);

                if (esCorrecto)
                {
                    // Comprobamos que esté dentro del rango del menú
                    if (valorOpcion < MIN_OPCION || valorOpcion > MAX_OPCION)
                    {
                        esCorrecto = false;
                        codError = 2;
                    }
                }
                else
                {
                    codError = 1;
                }

                // SALIDA - Retroalimentación de errores
                switch (codError)
                {
                    case 1:
                        MostrarMensajeError("\nERROR: No has introducido un número válido. Inténtalo de nuevo.\n");
                        break;
                    case 2:
                        MostrarMensajeError("\nERROR: La opción introducida está fuera del rango (1 al 5). Inténtalo de nuevo.\n");
                        break;
                }
            } while (!esCorrecto);

            // SALIDA
            return valorOpcion;

        }
        #endregion

        #region MÉTODO DE PROCESAMIENTO

        #endregion

        #region MÉTODO DE SALIDA DE DATOS
        static void MostrarOpcion(int opcionSeleccionada)
        {
            switch (opcionSeleccionada)
            {
                case 1:     // Triangulo
                    Console.WriteLine("*");
                    Console.WriteLine("* *");
                    Console.WriteLine("* * *");
                    Console.WriteLine("* * * *");
                    Console.WriteLine("* * * * *");
                    break;
                case 2:     // Escuadra
                    Console.WriteLine("* * * * *");
                    Console.WriteLine("* * * *");
                    Console.WriteLine("* * *");
                    Console.WriteLine("* *");
                    Console.WriteLine("*");
                    break;
                case 3:     // Escuadra invertida
                    Console.WriteLine("* * * * *");
                    Console.WriteLine("  * * * *");
                    Console.WriteLine("    * * *");
                    Console.WriteLine("      * *");
                    Console.WriteLine("        *");
                    break;
                case 4:     // Piramide invertida
                    Console.WriteLine("* * * * *");
                    Console.WriteLine(" * * * *");
                    Console.WriteLine("  * * *");
                    Console.WriteLine("   * *");
                    Console.WriteLine("    *");
                    break;
                case 5:     // Piramide
                    Console.WriteLine("    *");
                    Console.WriteLine("   * *");
                    Console.WriteLine("  * * *");
                    Console.WriteLine(" * * * *");
                    Console.WriteLine("* * * * *");
                    break;
            }
        #endregion

        }

        static void MostrarMensajeError(string mensaje)
        {
            Console.WriteLine(mensaje);

            Console.Write("Pulse Enter / Intro para continuar......");
            Console.ReadLine();      // Pausa para que el usuario lea el mensaje de error
            Console.Clear();        // Limpiar la pantalla
        }

    }
}
