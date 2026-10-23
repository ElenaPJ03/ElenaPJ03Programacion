namespace R8E03V2_ElenaPJ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CONSTANTES
            const int VALOR_FINAL = 0;

            // VARIABLES
            int numeroIntroducido = 0;
            bool esValido = true;
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

            //if (!esValido)           // Se comprueba que el número sea válido, y si no es válido que introduzca otro número
            //{
            //    Console.Write("ERROR: No has introducido un número válido. Inténtalo de nuevo. ");
            //}

            // PROCESO
            do
            {

            } while (numeroIntroducido != VALOR_FINAL || !esValido);
            //do
            //{
            //    // Solicitamos los datos 
            //    Console.Write("Introduzca un número: ");
            //    cadena = Console.ReadLine();
            //    esValido = int.TryParse(cadena, out numeroIntroducido);

            //    if (!esValido)          // Comprobación de datos
            //    {
            //        Console.WriteLine("ERROR: No has introducido un número válido. Inténtalo de nuevo. ");
            //    }
            //    else if (numeroIntroducido != VALOR_FINAL)
            //    {
            //        lista += $"{numeroIntroducido}\t";
            //    }
            //} while (numeroIntroducido != VALOR_FINAL || !esValido);


            // SALIDA
            // Mostramos la lista de los números que se han introducido
            Console.WriteLine("Los números que se han introducido son: ");
            Console.Write(lista);
        }
    }
}
