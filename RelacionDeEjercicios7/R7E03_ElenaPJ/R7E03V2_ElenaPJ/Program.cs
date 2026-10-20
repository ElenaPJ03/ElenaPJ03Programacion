namespace R7E03V2_ElenaPJ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CONSTANTES
            const int VALOR_INICIAL = 1;
            const int VALOR_FINAL = 100;

            // VARIABLES
            int contador = VALOR_INICIAL;
            string lista = "";

            // PROCRESO
            // Hacemos el bucle con el metodo do/while
            do
            {
                if (contador % 2 == 0)          // Se comprueba si el número es par
                {
                    lista += $"{contador++}\t";
                }

                contador++;

            } while (contador <= VALOR_FINAL);

            // ENTRADA

            // SALIDA
            Console.WriteLine(lista);

        }
    }
}
