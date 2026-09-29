namespace R4E03_ElenaPJ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CONSTANTES

            // VARIABLES
            int numero1, numero2, mayor;

            string cadenaAuxiliar;

            // ENTRADA
            // Solicitar al usuario que introduzca dos números enteros
            Console.Write("Introduce el primer número: ");
            cadenaAuxiliar = Console.ReadLine();
            numero1 = Convert.ToInt32(cadenaAuxiliar);

            Console.Write("Introduce el segundo número: ");
            cadenaAuxiliar = Console.ReadLine();
            numero2 = Convert.ToInt32(cadenaAuxiliar);

            // PROCESO
            // Comparar los dos números y determinar cuál es el mayor
            if (numero1 > numero2)
            {
                mayor = numero1;
            }
            else
            {
                mayor = numero2;
            }

            // SALIDA
            // Mostrar el resultado al usuario
            Console.WriteLine($"El mayor del numero {numero1} y número {numero2} es el número {mayor}");
        }
    }
}
