internal class Program
{
    private static void Main(string[] args)
    {
        // CONSTANTES
        const int VALOR_INICIAL = 100;
        const int VALOR_FINAL = 1;

        // VARIABLES
        int contador = VALOR_INICIAL;
        string lista = "";

        // ENTRADA

        // PROCESO
        // Bucle para decrementar el contador con el metodo do/while
        do
        {
            lista += $"{contador++}\t";         // lista = lista + $"{contador}\t;
        } while (contador >= VALOR_FINAL);

        // SALIDA
        Console.WriteLine(lista);
    }
}