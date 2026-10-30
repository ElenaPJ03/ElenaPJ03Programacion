namespace R9E01_ElenaPJ
{
    internal class Program
    {
        // Diseñar un programa que determine si un número entero es par o impar.
        static void Main(string[] args)
        {
            // CONSTANTES

            // VARIABLES
            int numero = 0;

            bool esPar = true;
            //bool esImpar = true;          // Variable que se puede no utilizarse
            bool esCorrecto = true;         // Centinela

            byte codigoError = 0;           // 0 --> No hay error
                                            // 1 --> El número introducido está fuera del rango permitido
                                            // 2 --> El número introducido es negativo

            string cadena = "";             // Cadena auxiliar

            // Iniciamos la entrada con un bucle do/while
            do
            {   // ENTRADA
                codigoError = 0;
                // Solicitamos al usuario que introduzca el numero
                Console.Write("Introduce un numero entero para comprobar si es par o impar: ");
                cadena = Console.ReadLine();
                esCorrecto = Int32.TryParse(cadena, out numero);

                // Validación
                if (!esCorrecto)
                {
                    codigoError = 1;
                }

                if (numero < 0)
                {
                    codigoError = 2;
                    esCorrecto = false;
                }

                // Retroalimentación
                switch (codigoError)
                {
                    case 1:
                        Console.WriteLine("ERROR: No has introducido un número válido. Inténtalo de nuevo.");
                        break;
                    case 2:
                        Console.WriteLine("ERROR: El número debe ser mayor que cero. Inténtalo de nuevo.");
                        break;
                }
            } while (!esCorrecto);


            // PROCESO
            if (numero % 2 == 0)
            {
                esPar = true;
                //esImpar = false;
            }
            else
            {
                //esImpar = true;
                esPar = false;
            }

            // SALIDA
            if (esPar)
            {
                Console.WriteLine($"El número {numero} es PAR.");
            }
            else
            {
                Console.WriteLine($"El número {numero} es IMPAR.");
            }
        }
    }
}
