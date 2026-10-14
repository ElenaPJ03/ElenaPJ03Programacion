namespace R7E03_ElenaPJ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CONSTANTES
            const byte VALOR_MIN = 0;
            const byte VALOR_MAX = 100;
            const byte INCREMENTO = 1;

            // VARIABLES
            byte contador = VALOR_MIN;

            // ENTRADA

            // PROCESO

            // SALIDA
            // Mostramos bucle y decimos que solo muestre por pantalla los numeros pares.
            while (contador <= VALOR_MAX)
            {
                if (contador % 2 == 0)
                {
                    Console.Write(contador);
                    Console.Write("\t");
                }

                contador = (byte)(contador + INCREMENTO);
            }

        }
    }
}
