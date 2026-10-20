namespace R7E04V2_ElenaPJ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CONSTANTES
            const byte VALOR_INICIAL = 1;
            const byte VALOR_FINAL = 100;

            // VARIABLES
            int contador = VALOR_INICIAL;
            string lista = "";
            int suma = 0;

            // ENTRADA

            // PROCESO
            // Hacemos un bucle con el metodo do/while
            do
            {
                suma += contador;           // Se acumula la suma
                lista += $"{contador}\t";
                contador++;
            }while (contador <= VALOR_FINAL);

            // SALIDA
            // Mostramos la lista entera y el resultado de la suma
            Console.WriteLine(lista);
            Console.WriteLine($"\n\n La suma total de los 100 primeros números es: {suma}");
        }
    }
}
