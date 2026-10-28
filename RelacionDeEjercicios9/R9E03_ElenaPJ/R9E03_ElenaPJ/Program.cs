namespace R9E03_ElenaPJ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CONSTANTES
            const float PULGADAS_POR_METRO = 39.27f;
            const int PULGADAS_POR_PIE = 12;

            // VARIABLES
            float metros = 0;
            float totalPulgadas = 0;
            int pies = 0;
            float pulgadas = 0;

            bool esValido = false;

            //byte codigoError = 0;

            string cadena = "";

            // ENTRADA
            // Pedimos al usuario que introduzca la distancia en metros con un bucle do/while y posteriormente hacer la validación de datos.
            do
            {
                Console.Write("Introduce la distancia en metros: ");
                cadena = Console.ReadLine();
                esValido = float.TryParse(cadena, out metros);

                if (!esValido)
                {
                    codigoError = 1;
                    Console.WriteLine("ERROR: No has introducido un número válido. Inténtalo de nuevo.");
                }
                else if (metros < 0)
                {
                    codigoError = 2;
                    Console.WriteLine("ERROR: La distancia no puede ser negativa. Inténtalo de nuevo.");
                    esValido = false;
                }

            } while (!esValido);

            // PROCESO
            // Convertimos los metros a pulgadas
            totalPulgadas = metros * PULGADAS_POR_METRO;

            // Calculamos la parte entera correspondiente a los pies
            pies = (int)(totalPulgadas / PULGADAS_POR_PIE);

            // Calculamos el resto de pulgadas
            pulgadas = totalPulgadas % PULGADAS_POR_PIE;

            // SALIDA
            Console.WriteLine($"{metros} metros equivalen a: ");
            Console.WriteLine($"----> {pies} pies");
            Console.WriteLine($"----> {pulgadas:F2} pulgadas");
        }
    }
}
