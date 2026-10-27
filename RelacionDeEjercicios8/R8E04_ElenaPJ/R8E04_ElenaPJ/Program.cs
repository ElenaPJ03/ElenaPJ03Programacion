namespace R8E04_ElenaPJ
{
    internal class Program
    {
        // Realizar un programa que realice la lectura de una serie de números enteros positivos por teclado distintos de cero, el cero finalizará la lectura.
        // El programa mostrará el número de números leídos, la suma y la media de dichos números.
        
        static void Main(string[] args)
        {
            // CONSTANTES
            const int VALOR_FINAL = 0;

            // VARIABLES
            int numero = 0;
            int suma = 0;
            float media = 0;
            int cantidadNumeros = 0;

            bool esCorrecto = true;           // Centinela

            string cadena = "";
            string lista = "";

            byte codigoError = 0;

            // Hacemos un bucle tipo do/while
            do
            {
                // ENTRADA
                // Pedimos al usuario que introduzca un número
                Console.Write("Introduzca un número: ");
                cadena = Console.ReadLine();
                esCorrecto = int.TryParse(cadena, out numero);

                // Retroalimentación
                if (!esCorrecto)
                {
                    codigoError = 1;
                }
                else if (numero < 0)
                {
                    codigoError = 2;
                    esCorrecto = false;
                }   // PROCESO
                else if (numero != VALOR_FINAL)
                {
                    // Si el número es válido, positivo y distinto de 0, lo procesamos
                    lista += $"{numero}\t";
                    suma += numero;
                    cantidadNumeros++;
                }

                // Calculamos la media si se han introducido números
                if (cantidadNumeros > 0)
                {
                    media = (float)suma / cantidadNumeros;
                }

                // SALIDA
                switch (codigoError)
                {
                    case 1:
                        Console.WriteLine("ERROR: Has introducido un número válido. Inténtalo de nuevo.");
                        break;
                    case 2:
                        Console.WriteLine("ERROR: El número introducido no puede ser negativo. Inténtelo de nuevo.");
                        break;
                }
            } while (numero != VALOR_FINAL || !esCorrecto);

            // Mostramos la lista de los números que se han introducido, la suma y la media
            Console.WriteLine("Los números que se han introducido son: ");
            Console.WriteLine(lista);
            Console.WriteLine($"La suma de los números introducidos es: {suma}");
            Console.WriteLine($"La media de los números introducidos es {media}");


        }
    }
}
