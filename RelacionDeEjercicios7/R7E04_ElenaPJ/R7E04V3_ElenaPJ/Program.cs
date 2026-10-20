namespace R7E04V3_ElenaPJ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CONSTANES
            const byte VALOR_INICIAL = 1;
            const byte VALOR_FINAL = 100;

            // VARIABLES
            int contador;
            string lista = "";
            int suma = 0;

            // ENTRADA
            // Hacemos un bucle com el metodo for
            for (contador = VALOR_INICIAL; contador <= VALOR_FINAL; contador++)
            {
                suma += contador;           // Se acumula la suma
                lista += $"{contador}\t";
            }

            // SALIDA
            // Mostramos la lista de los números y el resultado de la suma
            Console.WriteLine(lista);
            Console.WriteLine($"\n\n La suma total de los 100 primeros números es: {suma}");

        }
    }
}
