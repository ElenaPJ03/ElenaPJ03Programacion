namespace R5E01_ElenaPJ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CONSTANTES
            // Definir las constantes para la superficie mínima, largo máximo y ancho máximo
            //const byte METROS_CUADRADOS = 4;  
            //const byte LARGO_MAXIMO = 10;     // Corrección de definicion de constantes
            //const byte ANCHO_MAXIMO = 6;

            const byte METROS_CUADRADOS = 4;
            const byte LARGO_MAXIMO = 10;
            const byte ANCHO_MAXIMO = 6;

            // VARIABLES
            float numero1 = 0;      // Variable para almacenar el largo de la piscina
            float numero2 = 0;      // Variable para almacenar el ancho de la piscina
            float superficie = 0;
            string cadenaAuxiliar;
            bool prueba;        // Variable para almacenar el resultado de la validación de entrada
            byte codigoError = 0;
            /*
             * CODIGO DE ERROR
             * 0 = Sin error
             * 1 = Largo no válido
             * 2 = Largo supera el máximo o es menor o igual a 0
             * 3 = Ancho no válido o superficie menor a 4 m2
             * 4 = Ancho supera el máximo o es menor o igual a 0
             * 5 = La superficie de la piscina es menor a 4 m2
             */

            // ENTRADA
            // Solicitar al usuario el largo y ancho de la piscina
            Console.Write("Introduce el largo de la piscina: ");
            cadenaAuxiliar = Console.ReadLine();
            prueba = Single.TryParse(cadenaAuxiliar, out numero1);

            // Validar que el largo sea un número válido y no supere los 10 metros
            if (!prueba)        // prueba == false
            {
                codigoError = 1;
            }
            else if (numero1 > LARGO_MAXIMO || numero1 <= 0)
            {
                codigoError = 2;
                prueba = false;
            }

            // Solicitar al usuario el ancho de la piscina
            /*Console.Write("Introduce el ancho de la piscina: ");
            cadenaAuxiliar = Console.ReadLine();
            prueba = Single.TryParse(cadenaAuxiliar, out numero2);*/
            if (prueba)        // prueba == true // Solo solicitar el ancho si el largo es válido
            {
                Console.Write("Introduce el ancho de la piscina: ");
                cadenaAuxiliar = Console.ReadLine();
                prueba = Single.TryParse(cadenaAuxiliar, out numero2);
            }

            // Validar que el ancho sea un número válido y no supere los 6 metros
            if (!prueba)
            {
                codigoError = 3;
            }
            else if (numero2 > ANCHO_MAXIMO || numero2 <= 0)
            {
                codigoError = 4;
            }

            // PROCESO
            // Calcular la superficie de la piscina y validar que sea mayor a 4 m2
            superficie = numero1 * numero2;
            if (superficie < METROS_CUADRADOS)
            {
                codigoError = 5;
            }

            // SALIDA
            switch (codigoError)    //segun (codigoError)    // Mostrar el resultado de la validación y la superficie de la piscina
            {
                case 0:
                    Console.WriteLine($"La superficie de la piscina es: {superficie} m2");
                    break;
                case 1:
                    Console.WriteLine("Error: Largo no válido.");
                    break;
                case 2:
                    Console.WriteLine("Error: Largo supera el máximo o es menor o igual a 0.");
                    break;
                case 3:
                    Console.WriteLine("Error: Ancho no válido o superficie menor a 4 m2.");
                    break;
                case 4:
                    Console.WriteLine("Error: Ancho supera el máximo o es menor o igual a 0.");
                    break;
                case 5:
                    Console.WriteLine("Error: La superficie de la piscina tiene que ser menor a 4 m2.");
                    break;
            }
        }
    }
}
