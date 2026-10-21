namespace R7E02_ElenaPJ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CONSTANTES
            const byte VALOR_INICIAL = 0;
            const byte VALOR_FINAL = 100;

            // VARIABLES
            byte contador = VALOR_INICIAL;

            // ENTRADA

            // PROCESO

            // SALIDA
            // Mostramos la salida con un buble while
            while (contador <= VALOR_FINAL)
            {
                Console.Write(contador);
                Console.Write("\t");

                contador--;
            }
        }
    }
}
