namespace R13E01_ElenaPJ
{
    internal class Program
    {
        // Elaborar un programa que lea y almacene en un array 10 números enteros y una vez terminada la lectura, imprima los 10 números con un formato de salida.
        static void Main(string[] args)
        {
            // CONSTANTES
            const int TAMANO_MAX = 10;

            // VARIABLES
            int[] numeros;
            int numeroLeido;

            bool esValido = true;
            string entrada = "";
            string salida = "";

            // INICIALIZACIÓN
            numeros = new int[TAMANO_MAX];
            
            // ENTRADA
            // Captar los números introducidos
            for (int i = 0; i < TAMANO_MAX; i++)
            {
                do
                {
                    Console.Write($"Introduce el número {i + 1} de {TAMANO_MAX}: ");
                    entrada = Console.ReadLine();
                    esValido = int.TryParse(entrada, out numeroLeido);

                    if (!esValido)
                    {
                        Console.WriteLine("ERROR: Debes introducir un número entero válido. Inténtalo de nuevo");
                    }
                } while (!esValido);
            }

            // PROCESO
            for (int i = 0; i < TAMANO_MAX; i++)
            {
                salida += $"Posición {i + 1}: {numeros[i]}\n";
            }

            // SALIDA
            Console.WriteLine("\n--- Números introducidos ---");
            Console.Write(salida);
        }
    }
}
