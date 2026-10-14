namespace R7E02_ElenaPJ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CONSTANTES
            const byte VALOR_MIN = 0;
            const byte VALOR_MAX = 100;
            const byte DECREMENTO = 1;

            // VARIABLES
            byte contador = VALOR_MAX;

            // ENTRADA

            // PROCESO

            // SALIDA
            // Mostramos la salida con un buble 
            while (contador <= VALOR_MAX)
            {
                Console.Write(contador);
                Console.Write("\t");

                contador = (byte)(contador - DECREMENTO);
            }
        }
    }
}
