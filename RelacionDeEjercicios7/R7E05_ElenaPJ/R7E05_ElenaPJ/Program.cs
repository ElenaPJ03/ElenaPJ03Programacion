namespace R7E05_ElenaPJ
{
    internal class Program
    {
        // Diseñar un algoritmo que muestre por pantalla los números impares entre 0 y 100 e indique cuantos impares hay.

        static void Main(string[] args)
        {
            // CONSTANTES 
            const byte VALOR_MIN = 0;
            const byte VALOR_MAX = 100;
            const byte INCREMENTO = 1;

            // VARIABLES
            byte contador = VALOR_MIN;
            byte numeroImpares = 0;

            // ENTRADA

            // PROCESO

            // SALIDA
            while (contador <= VALOR_MAX)
            {
                if (contador % 2 != 0)
                {
                    Console.Write(contador);
                    Console.Write("\t");
                    numeroImpares++;
                }

                contador = (byte)(contador + INCREMENTO);
                Console.WriteLine($"Hay {numeroImpares} números impares. ");
            }
        }
    }
}
