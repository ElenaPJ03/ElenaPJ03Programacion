namespace R8E05V4_ElenaPJ
{
    internal class Program
    {
        /// <summary>
        /// V4: Se considera que todos los números tienen 2 divisores
        /// Encontrar un divivosr más para saber que NO es primo
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // CONSTANES
            const int LIM_INFERIOR = 0;
            // VARIABLES
            int numero = 0;
            int divisor = 0;
            //int numeroDivisores = 2;    // Ya sabemos que tiene 2 divisores
            bool esPrimo = true;    // Se supone que el usuario introducirá un número primo

            string aux = "";

            // Recursos para el control de errores
            bool esValido = true;
            byte codError = 0;   // 0 -> No hay error
                                 // 1 -> El valor no es un número o fuera del rango de los enteros
                                 // 2 -> El número no mayor estricto de 0

            // Recursos para las pruebas de Rendimiento
            DateTime tiempoInicial;
            DateTime tiempoFinal;

            TimeSpan duracion;

            // ENTRADA
            // Captar el número a evaluar
            do
            {
                // Inicializar el control de errores
                codError = 0;
                //esValido = true;  Optimización del código por una actualización posterior

                // Solicitar el dato de entrada
                Console.Write("Introduzca él número a evaluar: ");
                aux = Console.ReadLine();

                // Procesamiento de la entrada
                esValido = Int32.TryParse(aux, out numero);

                // Validación - Detectar e Identificar los errores
                if (!esValido)
                {
                    codError = 1;
                    //esValido = false;
                }
                else
                {
                    if (numero <= LIM_INFERIOR)
                    {
                        esValido = false;
                        codError = 2;
                    }
                }

                // Retroalimentación de errores
                switch (codError)
                {
                    case 1:
                        Console.WriteLine("ERROR: El valor no es un número o está fuera del rango. Inténtelo de nuevo.");
                        break;
                    case 2:
                        Console.WriteLine("ERROR: El valor es menor de 0. Inténtelo de nuevo.");
                        break;
                }

            } while (!esValido);    // esValido == false;

            // PROCESO
            // Iniciar el Control de Tiempo
            tiempoInicial = DateTime.Now;

            // Encontrar el número de divisores que tiene el número introducido
            //            Quito divisor numero   Quito divisor 1
            for (divisor = numero - 1; (divisor > LIM_INFERIOR - 1) && esPrimo; divisor--)
            {
                // Forzar un pequeño retraso
                Thread.Sleep(500);

                if (numero % divisor == 0)
                {
                    //numeroDivisores++;
                    esPrimo = false;
                }
            }

            // Como no utilizo el numeroDivisores no necesito evaluarlos para saber si el número es o no primo
            /*
            if (numeroDivisores != 2)
            {
                esPrimo = false;
            }
            else
            {
                esPrimo = true;
            }
            */

            // Finalizar el Control de Tiempo
            tiempoFinal = DateTime.Now;

            // Calcular el Tiempo Empleado
            duracion = tiempoFinal - tiempoInicial;

            // SALIDA
            if (!esPrimo)
            {
                Console.WriteLine($"El número {numero} NO es primo.");
            }
            else
            {
                Console.WriteLine($"El número {numero} es primo.");
            }

            // Mostrar el Tiempo Empleado
            Console.WriteLine($"El tiempo empleado es {duracion.TotalSeconds} segundos.");
        }
        
            
        
    }
}
