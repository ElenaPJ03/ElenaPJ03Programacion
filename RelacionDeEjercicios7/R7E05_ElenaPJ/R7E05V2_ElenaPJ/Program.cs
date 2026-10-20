namespace R7E05V2_ElenaPJ
{
    internal class Program
    {
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
            Console.WriteLine($"Números impares entre {VALOR_INICIAL} y {VALOR_FINAL}: \n");

            // PROCESO
            // Hacemos un bucle con el metodo do/while
            do
            {
                if (contador % 2 != 0)          // Se comprueba si el número es impar
                {
                    lista += $"\t{contador}";
                    numeroImpares++;          // Se incrementa el contador de numeros impares
                }

                contador++;

            } while (contador <= VALOR_FINAL);
            // SALIDA
            // Mostramos la lista y el número total de impares.
            Console.WriteLine(lista);
            Console.WriteLine($"\nTotal de números impares encontrados: {numeroImpares}");
        }
    }
}
