namespace R4E02_ElenaPJ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CONSTANTES
            const int VALOR_CIEN = 100;

            // VARIABLES
            int numero;

            string cadenaAuxiliar;

            // ENTRADA
            Console.Write("Introduzca un número entero: ");
            cadenaAuxiliar = Console.ReadLine();
            numero = Convert.ToInt32(cadenaAuxiliar);

            // PROCESO

            // SALIDA
            if (numero > VALOR_CIEN)
            {
                Console.WriteLine($"El número {numero} introducido es mayor que {VALOR_CIEN}.");
            }
            else
            {
                Console.WriteLine($"El número {numero} introducido es menor o igual que {VALOR_CIEN}.");
            }
        }
    }
}
