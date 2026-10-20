namespace R7E01V3_ElenaPJ
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
            for(contador = VALOR_INICIAL; contador < VALOR_FINAL; contador++)
            {
                lista += $"{contador}\t";
            }

            // SALIDA
            Console.WriteLine(lista);

        }
    }
}
