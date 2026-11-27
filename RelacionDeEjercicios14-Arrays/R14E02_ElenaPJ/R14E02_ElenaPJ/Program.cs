using System.Runtime.ConstrainedExecution;

namespace R14E02_ElenaPJ
{
    internal class Program
    {
        //  Realizar un programa que lea e imprima una serie de números distintos de cero. El algoritmo debe terminar con un valor cero que no se debe imprimir.
        //  Imprimir el número de valores leídos.
        static void Main(string[] args)
        {
            // CONSTANTES
            const int VALOR_FINAL = 0;      // Valor para terminar el algoritmo

            // VARIABLES
            int[] numeros;    
            int numeroIntroducido = 0;
            int cantidadLeidos = 0;
            string lista = "";
            string cadena = "";         // cadena auxiliar

            bool esCorrecto = true;     // centinela

            // Construcción del array
            numeros = new int[0];       // Inicializamos el array a 0

            // ENTRADA
            // Solicitud de los números a introducir hasta 0
            Console.WriteLine("Introduce números distintos de cero (0 para terminar):");
            cadena = Console.ReadLine();
            // Conversión de la cadena a "int" y guarda el resultado en "numeroIntroducido"
            esCorrecto = Int32.TryParse(cadena, out numeroIntroducido);

            do
            {
                cadena = Console.ReadLine();
                esCorrecto = int.TryParse(cadena, out numeroIntroducido);

                if (!esCorrecto)
                {
                    Console.WriteLine("ERROR: Solo se permiten números enteros. Inténtalo de nuevo.");
                }
                else if (numeroIntroducido != VALOR_FINAL)
                {
                    // Crea un nuevo array con el nuevo tamaño que le indiques
                    // Amplia el array "numero" a "cantidadLeidos + 1" conservando los elementos anteriores
                    Array.Resize(ref numeros, cantidadLeidos + 1);      // Se usa ref para que Array.Resize modifique los numeros
                    numeros[cantidadLeidos] = numeroIntroducido;        // Guarda el número
                    cantidadLeidos++;       // Incrementa el contador
                }

            } while (!esCorrecto || numeroIntroducido != VALOR_FINAL);

            // PROCESO
            // Recoger el array ya relleno/almacenado
            for (int i = 0; i < cantidadLeidos; i++)
            {
                lista += $"{numeros[i]}\t";     // Concatenación de la lista
            }

            // SALIDA
            // Muestra de los resultados
            Console.WriteLine("\n--- RESULTADOS ---");
            Console.WriteLine("Números leídos (distintos de cero):");
            Console.WriteLine(lista);
            Console.WriteLine($"Número de valores leídos: {cantidadLeidos}");

        }
    }
}
