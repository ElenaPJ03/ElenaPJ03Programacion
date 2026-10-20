namespace R7E05V3_ElenaPJ
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
            // Hacemos un bucle con el metodo for
            for(contador = VALOR_INICIAL; contador <= VALOR_FINAL; contador++)
            {
                if (contador % 2 != 0)          // Se comprueba si los numeros son impares
                {
                    lista += $"\t{contador}";
                    numeroImpares++;            // Se incrementa el numero de impares
                }
            }

            // SALIDA
            // Mostramos la lista y el número total de impares.
            Console.WriteLine(lista);
            Console.WriteLine($"\nTotal de números impares encontrados: {numeroImpares}");
        }
    }
}
