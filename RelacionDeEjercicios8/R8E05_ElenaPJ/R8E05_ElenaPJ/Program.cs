namespace R8E05_ElenaPJ
{
    internal class Program
    {
        // Diseñar un algoritmo para determinar si un número N es primo (un número primo sólo puede ser divisible por él mismo y por la unidad)
        static void Main(string[] args)
        {
            // CONSTANTES
            const int DIVISOR_INICIAL = 2;

            // VARIABLES
            int numeroN = 0;
            int divisor = DIVISOR_INICIAL;

            bool esPrimo = true;
            bool esCorrecto = true;

            string cadena = "";

            // ENTRADA
            // Le pedimos al usuario que introduzca un numero con el bucle do/while
            do
            {
                Console.Write("Introduce un número entero para comprobar si es primo: ");
                cadena = Console.ReadLine();
                esCorrecto = int.TryParse(cadena, out numeroN);

                if (!esCorrecto)
                {
                    Console.WriteLine("ERROR: No has introducido un número válido. Inténtalo de nuevo.");
                }
                else if (numeroN <= 0)
                {
                    Console.WriteLine("ERROR: El número debe ser mayor que cero. Inténtalo de nuevo.");
                    esCorrecto = false;          // Forzamos a que repita si no es positivo
                }

            } while (!esCorrecto);

            // PROCESO
            // El número 1 no es primo de por sí.
            if (numeroN == 1)
            {
                esPrimo = false;
            }
            else
            {
                while (divisor < numeroN)            // Bucle while para comprobar si es divisible por algún número
                {
                    if (numeroN % divisor == 0)
                    {
                        esPrimo = false;            // Si es divisible, ya no es primo
                        break;                      // Rompemos el bucle
                    }

                    divisor++;
                }
            }
            // SALIDA
            // Mostramos la salida con un if/else 
            if (esPrimo)
            {
                Console.WriteLine($"El número {numeroN} es un número PRIMO.");           // Si es primo
            }
            else
            {
                Console.WriteLine($"El número {numeroN} no es un número primo.");         // Si no es primo
            }
        }
    }
}
