namespace R7E01V1_ElenaPJ
{
    internal class Program
    {
        // Diseño de un algoritmo que muestre por pantalla los numeros del 1 al 100.
        static void Main(string[] args)
        {
            // CONSTANTES
            const byte VALOR_MIN = 1;
            const byte VALOR_MAX = 100;
            const byte INCREMENTO = 1;

            // VARIABLES
            byte contador = VALOR_MIN;

            // ENTRADA

            // PROCESO

            // SALIDA
            // Mostramos la salida con un bucle 
            while (contador <= VALOR_MAX)
            {
                Console.Write(contador);
                Console.Write("\t");        // Console.Write(${contador}\t");

                contador = (byte)(contador + INCREMENTO);
            }
        }
    }
}
