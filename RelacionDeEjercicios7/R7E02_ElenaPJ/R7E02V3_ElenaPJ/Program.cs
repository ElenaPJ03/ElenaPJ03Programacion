namespace R7E02V3_ElenaPJ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CONSTANTES
            const int VALOR_INICIAL = 100;
            const int VALOR_FINAL = 1;

            // VARIABLES
            int contador;
            string lista = "";

            // ENTRADA

            // PROCESO
            // Bucle para decrementar el contador con el metodo for
            for (contador = VALOR_INICIAL; contador > VALOR_FINAL; contador++)
            {
                lista += $"{contador}\t";
            }

            // SALIDA
            Console.WriteLine(lista);

        }
    }
}
