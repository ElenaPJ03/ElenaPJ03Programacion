namespace R7E01V2_ElenaPJ
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

            // ENTRADA

            // PROCESO
            do
            {
                lista += $"{contador++}\t";       // lista = lista + $"{contador}\t";
                //contador++;
            } while (contador <= VALOR_FINAL);

            // SALIDA
            Console.WriteLine(lista);

        }
    }
}
