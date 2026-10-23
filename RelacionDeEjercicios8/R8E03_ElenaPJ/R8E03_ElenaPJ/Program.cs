using System.Runtime.ConstrainedExecution;

namespace R8E03_ElenaPJ
{
    internal class Program
    {
        // Diseñar un algoritmo que lea e imprima una serie de números distintos de cero. El algoritmo debe terminar con un valor cero que no se debe imprimir.
        
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

            // PROCESO
            do
            {
                Console.Write("Introduzca un número: ");
                cadena = Console.ReadLine();
                esValido = int.TryParse(cadena, out numeroIntroducido);

                if (!esValido)
                {
                    Console.Write("ERROR: No has introducido un número válido. Inténtalo de nuevo. ");
                }
                else if (numeroIntroducido != VALOR_FINAL)
                {
                    lista += $"{numeroIntroducido}\t";
                }
            } while (numeroIntroducido != VALOR_FINAL);
            
            // SALIDA
            Console.WriteLine("Los números que se han introducido son: ");
            Console.Write(lista);

        }
    }
}
