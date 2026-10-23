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
            // Pedimos al usuario que nos introduzca un número las veces que quiera hasta que introduzca 0.
            do
            {
                Console.Write("Introduzca un número: ");                // Pedimos el número y lo leemos posteriormente
                cadena = Console.ReadLine();
                esValido = int.TryParse(cadena, out numeroIntroducido);
            } while (!esValido);

            if (!esValido)           // Se comprueba que el número sea válido, y si no es válido que introduzca otro número
            {
                Console.Write("ERROR: No has introducido un número válido. Inténtalo de nuevo. ");
            }
            else if (numeroIntroducido < 0)
            {
                Console.Write("ERROR: El número introducido no puede ser negativo. Inténtelo de nuevo. ");
            }

            // PROCESO
            // Hacemos un bucle tipo do/while
            if (esValido)
            {
                do
                {
                    lista += $"{numeroIntroducido}\t";
                    suma += numeroIntroducido;
                    cantidadNumeros++;
                } while (numeroIntroducido != VALOR_FINAL || !esValido);
            }

            if (cantidadNumeros > 0)            // Si hay números introducidos, hacer la media de dichos números
            {
                media = suma / cantidadNumeros;
            }

            // SALIDA
            // Mostramos la lista de los números que se han introducido, la suma y la media
            Console.WriteLine("Los números que se han introducido son: ");
            Console.Write(lista);
            Console.WriteLine($"La suma de los números introducidos es: {suma}");
            Console.WriteLine($"La media de los números introducidos es {media}");
        }
    }
}
