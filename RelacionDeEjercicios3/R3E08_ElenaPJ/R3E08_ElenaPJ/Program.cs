namespace R3E08_ElenaPJ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CONSTANTES

            // VARIABLES
            int numero;
            bool esPar;

            string cadenaAuxiliar;

            // ENTRADA
            //Solicitar al usuario que introduzca un número
            Console.Write("Introduce un número: ");
            cadenaAuxiliar = Console.ReadLine();
            numero = Convert.ToInt32(cadenaAuxiliar);

            // PROCESO
            //Comprobar si el número es par o impar
            esPar = numero % 2 == 0;

            // SALIDA
            //Mostrar el número introducido y si es par o impar
            Console.WriteLine($"El número {numero}");
            Console.Write($"Es par: {esPar}");
        }
    }
}
