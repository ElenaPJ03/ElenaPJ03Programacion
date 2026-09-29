namespace R4E04_ElenaPJ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // COSTANTES

            // VARIABLES
            int numero1, numero2, numero3, numero4;

            string cadenaAuxiliar;

            // ENTRADA
            Console.Write("Introduce el primer número: ");
            cadenaAuxiliar = Console.ReadLine();
            numero1 = Convert.ToInt32(cadenaAuxiliar);

            Console.Write("Introduce el segundo número: ");
            cadenaAuxiliar = Console.ReadLine();
            numero2 = Convert.ToInt32(cadenaAuxiliar);

            Console.Write("Introduce el tercer número: ");
            cadenaAuxiliar = Console.ReadLine();
            numero3 = Convert.ToInt32(cadenaAuxiliar);

            Console.Write("Introduce el cuarto número: ");
            cadenaAuxiliar = Console.ReadLine();
            numero4 = Convert.ToInt32(cadenaAuxiliar);

            // PROCESO

            // SALIDA
            // Mostramos los números introducidos
            Console.Write("Datos introducidos: ");
            Console.WriteLine($"Número 1: {numero1} ------ Número 2: {numero2}");
            Console.WriteLine($"Número 3: {numero3} ------ Número 4: {numero4}");

            // Comparamos los números para determinar cuál es el mayor
            if (numero1 >= numero2 && numero1 >= numero3 && numero1 >= numero4)
            {
                Console.WriteLine("El número mayor es: " + numero1);
            }
            else if (numero2 >= numero1 && numero2 >= numero3 && numero2 >= numero4)
            {
                Console.WriteLine("El número mayor es: " + numero2);
            }
            else if (numero3 >= numero1 && numero3 >= numero2 && numero3 >= numero4)
            {
                Console.WriteLine("El número mayor es: " + numero3);
            }
            else
            {
                Console.WriteLine("El número mayor es: " + numero4);
            }

        }
    }
}
