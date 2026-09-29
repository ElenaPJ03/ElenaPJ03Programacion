namespace R4E01V1_ElenaPJ
{
    internal class Program
    {
        // V1: Consideramos el 0 como un número entero positivo.

        static void Main(string[] args)
        {
            // CONSTANTES
            const int VALOR_CERO = 0;

            // VARIABLES
            int numero;

            string cadenaAuxiliar;

            // ENTRADA
            Console.Write("Introduzca un número entero: ");
            cadenaAuxiliar = Console.ReadLine();
            numero = Convert.ToInt32(cadenaAuxiliar);

            // PROCESO

            // SALIDA
            if (numero >= VALOR_CERO)
            {
                Console.WriteLine($"El número {numero} introducido es positivo.");
            }
            else
            {
                Console.WriteLine($"El número {numero} introducido es negativo.");
            }
        }
    }
}
