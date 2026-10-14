namespace R7E04_ElenaPJ
{
    internal class Program
    {
        // Diseñar un algoritmo que realice la suma de los 100 primeros números.
        static void Main(string[] args)
        {
            // CONSTANTES
            const byte VALOR_MIN = 1;
            const byte VALOR_MAX = 100;
            const byte INCREMENTO = 1;

            // VARIABLES
            int contador = VALOR_MIN;
            int suma = 0;

            // ENTRADA

            // PROCESO

            // SALIDA
            // Bucle para mostrar la suma de los números
            while (contador <= VALOR_MAX)
            {
                suma += contador;
                contador = (byte)(contador += INCREMENTO);
                //contador += INCREMENTO;
            }

            Console.Write($"La suma de los 100 primeros números es: {suma}.");
        }
    }
}
