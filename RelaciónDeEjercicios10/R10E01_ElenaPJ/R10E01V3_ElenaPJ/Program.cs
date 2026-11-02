namespace R10E01V3_ElenaPJ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// programa que calcule la superficie y el volumen de la piscina dada el largo, el ancho y la profundidad de la misma.
            /// </summary>
            /// <param name="args"></param>
            static void Main(string[] args)
            {
                // CONSTANTES
                const float LARGO_MIN = 2.5f;
                const float LARGO_MAX = 20.5f;

                const float ANCHO_MIN = 2.5f;
                const float ANCHO_MAX = 10.25f;

                const float PROFUNDIDAD_MIN = 0.5f;
                const float PROFUNDIDAD_MAX = 5.75f;

                const float SUPERFICIE_MIN = 6;

                // VARIABLES
                float largo = 0;
                float ancho = 0;
                float profundidad = 0;
                float superficie = 0;
                float volumen = 0;

                bool esValido = true;
                string cadenaAux = "";
                byte codError = 0;

                // ENTRADA
                // Solicitamos y validamos el largo de la piscina
                do
                {
                    codError = 0;
                    //esValido = true;

                    // Solicitamos y validamos el largo de la piscina
                    Console.Write($"Introduce el largo de la piscina (entre {LARGO_MIN}m y {LARGO_MAX}m): ");
                    cadenaAux = Console.ReadLine();
                    esValido = float.TryParse(cadenaAux, out largo);

                    if (!esValido)
                    {
                        codError = 1;
                    }
                    else if (largo < LARGO_MIN || largo > LARGO_MAX)
                    {
                        esValido = false;
                        codError = 2;
                    }

                    // Si el largo es válido, pedimos el ancho de la piscina
                    if (esValido)
                    {
                        Console.Write($"Introduce el ancho de la piscina (entre {ANCHO_MIN}m y {ANCHO_MAX}m): ");
                        cadenaAux = Console.ReadLine();
                        esValido = float.TryParse(cadenaAux, out ancho);

                        if (!esValido)
                        {
                            codError = 1;
                        }
                        else if (ancho < ANCHO_MIN || ancho > ANCHO_MAX)
                        {
                            esValido = false;
                            codError = 3;
                        }
                        else if ((largo * ancho) < SUPERFICIE_MIN)
                        {
                            esValido = false;
                            codError = 4;
                        }
                    }

                    // Si el largo y el ancho son válidos, pedimos la profundidad
                    if (esValido)
                    {
                        Console.Write($"Introduce la profundidad de la piscina (entre {PROFUNDIDAD_MIN}m y {PROFUNDIDAD_MAX}m): ");
                        cadenaAux = Console.ReadLine();
                        esValido = float.TryParse(cadenaAux, out profundidad);

                        if (!esValido)
                        {
                            codError = 1;
                        }
                        else if (profundidad < PROFUNDIDAD_MIN || profundidad > PROFUNDIDAD_MAX)
                        {
                            esValido = false;
                            codError = 5;
                        }
                    }

                    // Retroalimentación de errores
                    switch (codError)
                    {
                        case 1:
                            Console.WriteLine("ERROR: El valor introducido no es un número válido. Inténtalo de nuevo.");
                            break;
                        case 2:
                            Console.WriteLine($"ERROR: El largo debe estar entre {LARGO_MIN}m y {LARGO_MAX}m.");
                            break;
                        case 3:
                            Console.WriteLine($"ERROR: El ancho debe estar entre {ANCHO_MIN}m y {ANCHO_MAX}m.");
                            break;
                        case 4:
                            Console.WriteLine($"ERROR: La superficie resultante debe ser de al menos {SUPERFICIE_MIN}m².");
                            break;
                        case 5:
                            Console.WriteLine($"ERROR: La profundidad debe estar entre {PROFUNDIDAD_MIN}m y {PROFUNDIDAD_MAX}m.");
                            break;
                    }

                } while (!esValido);


                // PROCESO
                // Calculamos la superficie y el volumen de la piscina
                superficie = largo * ancho;
                volumen = superficie * profundidad;

                // SALIDA
                // Mostramos los resultados
                Console.WriteLine("\n--- RESULTADOS DE LA PISCINA ---");
                Console.WriteLine($"Largo: {largo} m");
                Console.WriteLine($"Ancho: {ancho} m");
                Console.WriteLine($"Profundidad: {profundidad} m");
                Console.WriteLine($"Superficie: {superficie} m");
                Console.WriteLine($"Volumen: {volumen} m");
            }
        }
    }
}
