namespace R8E04_ElenaPJ
{
    internal class Program
    {
        // Realizar un programa que realice la lectura de una serie de números enteros positivos por teclado distintos de cero, el cero finalizará la lectura.
        // El programa mostraá el número de números leídos, la suma y la media de dichos números.
        
        static void Main(string[] args)
        {
            // CONSTANTES
            const int VALOR_FINAL = 0;

            // VARIABLES
            int numeroIntroducido = 0;
            int suma = 0;
            float media = 0;
            int cantidadNumeros = 0;

            bool esValido = true;           // Centinela

            string cadena = "";
            string lista = "";

            // ENTRADA

            // PROCESO
            // Hacemos un bucle tipo do/while
            do
            {
                Console.Write("Introduzca un número: ");
                cadena = Console.ReadLine();

                // Validamos si la entrada es un número entero
                esValido = int.TryParse(cadena, out numeroIntroducido);

                if (!esValido)
                {
                    Console.WriteLine("ERROR: No has introducido un número válido. Inténtalo de nuevo.");
                }
                else if (numeroIntroducido < 0)
                {
                    Console.WriteLine("ERROR: El número introducido no puede ser negativo. Inténtelo de nuevo.");
                }
                else if (numeroIntroducido != VALOR_FINAL)
                {
                    // Si el número es válido, positivo y distinto de 0, lo procesamos
                    lista += $"{numeroIntroducido}\t";
                    suma += numeroIntroducido;
                    cantidadNumeros++;
                }

            } while (numeroIntroducido != VALOR_FINAL || !esValido);

            // Calculamos la media si se han introducido números
            if (cantidadNumeros > 0)
            {
                media = (float)suma / cantidadNumeros;
            }

            // SALIDA
            // Mostramos la lista de los números que se han introducido, la suma y la media
            Console.WriteLine("Los números que se han introducido son: ");
            Console.WriteLine(lista);
            Console.WriteLine($"La suma de los números introducidos es: {suma}");
            Console.WriteLine($"La media de los números introducidos es {media}");
        }
    }
}
