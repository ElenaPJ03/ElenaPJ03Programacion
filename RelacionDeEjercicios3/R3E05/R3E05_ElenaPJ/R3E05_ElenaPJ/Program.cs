namespace R3E05_ElenaPJ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CONSTANTES

            // VARIABLES
            int base1;
            int altura;
            int superficie;
            string cadenaAuxiliar;

            // ENTRADA
            // Solicitar al usuario que ingrese la base y la altura del rectángulo
            Console.Write("Indica cuánto mide la base del rectángulo: ");
            cadenaAuxiliar = Console.ReadLine();
            base1 = Convert.ToInt32(cadenaAuxiliar);

            // Solicitar al usuario que ingrese la altura del rectángulo
            Console.Write("Indica cuánto mide la altura del rectángulo: ");
            cadenaAuxiliar = Console.ReadLine();
            altura = Convert.ToInt32(cadenaAuxiliar);

            // PROCESO
            // Calcular la superficie del rectángulo
            superficie = base1 * altura;

            // SALIDA
            // Mostrar el resultado al usuario
            Console.WriteLine("La superficie del rectángulo es: " + superficie);
         
        }
    }
}
