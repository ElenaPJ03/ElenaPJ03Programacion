namespace EjemploMenu
{
    internal class Program
    {
        /*
         Descripcion Ejemplo: Mostrar al usuario un menu de opciones
         Obtener la opcion seleccionada por el usuario
         Mostrar, en caso de error, la retroalimentacion correspondiente
         Mostrar, en caso de éxito, el mensaje con la opcion seleccionada
        */ 
        static void Main(string[] args)
        {
            // CONSTANTES
            const byte OPCION_MAX = 5;      // Constante para almacenar la opcion maxima del menu

            // VARIABLES
            string entrada = "";        // Variable para almacenar la entrada del usuario
            byte opcion = 0;        // Variable para almacenar la opcion seleccionada por el usuario
            bool esValido = true;       // Centinela para controlar si la opcion es valida o no
            byte codigoError = 0;       // Variable para almacenar el codigo de error
            /*
             Codigo de error:
             0 - No hay error
             1 - Error de introducción de un valor que no es un número o esta fuera del rango permitido
             2 - Error de opción fuera de las proporcionadas en el menu
            */
            // ENTRADA
            // Mostramos el menu de opciones al usuario
            Console.WriteLine("\t\t CAFETERIA - ROSA\n");
            Console.WriteLine("\t 1 - Bocadillo Sorpresa");
            Console.WriteLine("\t 2 - Bocadillo Mortadela");
            Console.WriteLine("\t 3 - Sandwich Jamón y Queso");
            Console.WriteLine("\t 4 - Bocadillo Tortilla");
            Console.WriteLine("\t 5 - Serranito Gigante");
            Console.WriteLine("\t 0 - Salir");
            Console.WriteLine("Seleccione la opción: ");
            entrada = Console.ReadLine();       // Leemos la entrada del usuario
            esValido = byte.TryParse(entrada, out opcion);      // Validamos que la entrada sea un número

            // Validación - Identificación de errores
            if (!esValido)      // if (esValido == false)
            {
                codigoError = 1;
            }
            else
            {
                if (opcion > OPCION_MAX)
                {
                    esValido = false;
                    codigoError = 2;
                }
            }

            // PROCESO
            if (esValido)
            {
                switch (opcion) 
                {
                    case 1:
                        // Acciones para elaborar el Bocadillo Sorpresa
                        break;
                    case 2:
                        // Acciones para elaborar el Bocadillo de Mortadela
                        break;

                }
            }

            // SALIDA
            if (esValido)       // Si no hay error, mostramos el mensaje correspondiente
            {
                switch (opcion)
                {
                    case 0:
                        Console.WriteLine("Gracias por su visita. A la próxima elija algo");
                        break;
                    case 1:
                        Console.WriteLine("Aqui tiene su Bocadillo Sorpresa");
                        break;
                }
            }
            else        // Si hay error, mostramos el mensaje de error correspondiente
            {
                switch (codigoError)
                {
                    case 1:
                        Console.WriteLine("ERROR: Introduzca un valor numérico o esta fuera de rango");
                        break;
                    case 2:
                        Console.WriteLine("ERROR: Ha seleccionado una opción del menú no válida");
                        break;
                }
            }

        }
    }
}
