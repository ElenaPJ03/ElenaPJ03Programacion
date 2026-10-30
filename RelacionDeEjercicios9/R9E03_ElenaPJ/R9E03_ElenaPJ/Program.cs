namespace R9E03_ElenaPJ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CONSTANTES
            const float PULGADAS_POR_METRO = 39.27f;        // 1 metro = 39.27 pulgadas
            const int PULGADAS_POR_PIE = 12;                // 1 pie = 12 pulgadas
                
            // VARIABLES
            float metros = 0;
            float totalPulgadas = 0;
            int pies = 0;
            float pulgadas = 0;

            bool esValido = false;      // Centinela

            byte codigoError = 0;       // 0 --> No hay error
                                        // 1 --> El núnero introducido está fuera del rango permitido
                                        // 2 --> El número introducido es negativo

            string cadena = "";         // Cadena auxiliar

            // ENTRADA
            // Pedimos al usuario que introduzca la distancia en metros con un bucle do/while y posteriormente hacer la validación de datos.
            do
            {
                codigoError = 0;
                Console.Write("Introduce la distancia en metros: ");
                cadena = Console.ReadLine();
                esValido = float.TryParse(cadena, out metros);

                // Validación de errores
                if (!esValido)
                {
                    codigoError = 1;
                }
                else if (metros < 0)
                {
                    esValido = false;
                    codigoError = 2;
                }

                // Retroalimentación
                switch (codigoError)
                {
                    case 1:
                        Console.WriteLine("ERROR: No has introducido un número válido. Inténtalo de nuevo.");
                        break;
                    case 2:
                        Console.WriteLine("ERROR: La distancia no puede ser negativa. Inténtalo de nuevo.");
                        break;
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
            // Mostramos los resultados
            Console.WriteLine($"{metros} metros equivalen a: ");
            Console.WriteLine($"----> {pies} pies");
            Console.WriteLine($"----> {pulgadas:F2} pulgadas");
        }
    }
}
