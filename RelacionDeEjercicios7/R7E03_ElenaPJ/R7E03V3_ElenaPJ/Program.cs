namespace R7E03V3_ElenaPJ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CONSTANTES
            const int VALOR_INICIAL = 1;
            const int VALOR_FINAL = 100;

            // VARIABLES
            int contador;
            string lista = "";

            // ENTRADA

            // PROCESO
            // Hacemos un buble con el metodo for
            for (contador = VALOR_INICIAL; contador < VALOR_FINAL; contador++)
            {
                if (contador % 2 == 0)          // Comprobamos que el número sea par
                {
                    lista += $"{contador}\t";
                }
            }

            // SALIDA
            Console.WriteLine(lista);

        }
    }
}
