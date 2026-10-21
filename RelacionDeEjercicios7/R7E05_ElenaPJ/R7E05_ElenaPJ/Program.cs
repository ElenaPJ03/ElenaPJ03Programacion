using System.ComponentModel;

namespace R7E05_ElenaPJ
{
    internal class Program
    {
        // Diseñar un algoritmo que muestre por pantalla los números impares entre 0 y 100 e indique cuantos impares hay.

        static void Main(string[] args)
        {
            // CONSTANTES 
            const int VALOR_INICIAL = 0;
            const int VALOR_FINAL = 100;

            // VARIABLES
            int contador = VALOR_INICIAL;
            int numeroImpares = 0;
            string lista = "";

            // ENTRADA
            // Console.WriteLine($"Números impares entre {VALOR_INICIAL} y {VALOR_FINAL}: \n");

            // PROCESO
            // Hacemos el bucle mediante el metodo while
            while (contador <= VALOR_FINAL)
            {
                if (contador % 2 != 0)          // Se comprueba si el numero es impar
                {
                    lista += $"{contador}\t";           
                    numeroImpares++;          // Incrementamos el contador de impares
                }

                contador++;
            }
            // SALIDA
            // Se muestra la lista y el total de numeros impares
            Console.WriteLine($"Números impares entre {VALOR_INICIAL} y {VALOR_FINAL}: \n");
            Console.WriteLine(lista);
            Console.WriteLine($"\nTotal de números impares encontrados: {numeroImpares}");
        }
    }
}
