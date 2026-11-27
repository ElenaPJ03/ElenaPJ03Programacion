namespace R13E02_ElenaPJ
{
    internal class Program
    {
        //  Realizar un programa que lea 10 números y calcule la suma de los 10 elementos (utilice arrays para almacenar los valores a sumar).
        static void Main(string[] args)
        {
            // CONSTANTES
            const int TAMANO_MAX = 10;

            // VARIABLES
            int[] numeros;
            int suma = 0;

            string entrada = "";
            string lista = "";

            // INICIALIZACIÓN
            numeros = new int[TAMANO_MAX];

            // ENTRADA
            for (int i = 0; i < TAMANO_MAX; i++)
            {
                Console.WriteLine($"Introduzca el número {i + 1} de {TAMANO_MAX}: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            // PROCESO
            for(int i = 0; i < TAMANO_MAX; i++)
            {
                suma += numeros[i];
                lista += $"{numeros[i]}" + (i < TAMANO_MAX - 1 ? " + " : "");
            }

            // SALIDA
            Console.WriteLine("\n--- RESULTADOS ---");
            Console.WriteLine($"Números almacenados: {lista}");
            Console.WriteLine($"La suma de los {TAMANO_MAX} elementos es: {suma}");
        }
    }
}
