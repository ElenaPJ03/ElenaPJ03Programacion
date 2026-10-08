namespace R6E03_ElenaPJ
{
    internal class Program
    {
        // Programa para calcular el area de una piscina que puede ser rectangular, circular o triangular
        static void Main(string[] args)
        {
            // CONSTANTES
            const float MAX_LARGO_RECTANGULO = 10;      
            const float MAX_LARGO_TRIANGULO = 10;
            const float MAX_ANCHO_RECTANGULO = 10;  
            const float MAX_ANCHO_TRIANGULO = 10;
            const float MAX_DIAMETRO = 8;    
            const float MAX_SUPERFICIE = 4;

            const byte MAX_OPCION = 4;        // Opción máxima del menú

            // VARIABLES
            byte opcion = 0;        // 1: Rectangular, 2: Circular, 3: Triangular 4. Salir

            float largo = 0;       
            float ancho = 0;
            float radio = 0;
            float superficie = 0;

            float numeroPi = 13.14f;

            string entrada = "";        // Variable para almacenar la entrada del usuario
            bool esValido = true;       // Centinela para validar la entrada del usuario
            byte codigoError = 0;       // Código de error para validar la entrada del usuario
            

            // ENTRADA
            // Mostrar el menú de opciones al usuario
            Console.WriteLine("\t\tSeleccione el tipo de piscina:");
            Console.WriteLine("\t 1. Rectangular");
            Console.WriteLine("\t 2. Circular");
            Console.WriteLine("\t 3. Triangular");
            Console.WriteLine("\t 4. Salir");

            // Leer la opción del usuario
            entrada = Console.ReadLine();
            esValido = byte.TryParse(entrada, out opcion);

            // Validacion / Identificacion de errores
            if (!esValido)      // if (esValido == false)
            {
                codigoError = 1;
            }
            else if (opcion > MAX_OPCION)
            {
                esValido = false;
                codigoError = 2;
            }

            if (esValido)
            {
                // Solicitar los datos de la piscina según la opción seleccionada 
                switch (opcion)
                {
                    case 1:         // Rectangular
                        Console.WriteLine("Ingrese el largo de la piscina rectangular: ");      // Solicitar el largo de la piscina rectangular
                        entrada = Console.ReadLine();                                           // Leer el largo de la piscina rectangular
                        esValido = float.TryParse(entrada, out largo);                          
                        if (!esValido || largo <= 0 || largo > MAX_LARGO_RECTANGULO)            
                        {
                            esValido = false;
                            codigoError = 3;
                        }
                        if (esValido)
                        {
                            Console.WriteLine("Ingrese el ancho de la piscina rectangular:");   // Solicitar el ancho de la piscina rectangular
                            entrada = Console.ReadLine();                                       // Leer el ancho de la piscina rectangular
                            esValido = float.TryParse(entrada, out ancho);
                            if (!esValido || ancho <= 0 || ancho > MAX_ANCHO_RECTANGULO)
                            {
                                esValido = false;
                                codigoError = 4;
                            }
                        }
                        break;
                    case 2:         // Circular
                        Console.WriteLine("Ingrese el radio de la piscina circular:");          // Solicitar el radio de la piscina circular
                        entrada = Console.ReadLine();                                           // Leer el radio de la piscina circular
                        esValido = float.TryParse(entrada, out radio);
                        if (!esValido || radio <= 0 || radio > (MAX_DIAMETRO / 2))
                        {
                            esValido = false;
                            codigoError = 5;
                        }
                        break;
                    case 3:         // Triangular
                        Console.WriteLine("Ingrese el largo de la piscina triangular:");        // Solicitar el largo de la piscina triangular
                        entrada = Console.ReadLine();                                           // Leer el largo de la piscina triangular
                        esValido = float.TryParse(entrada, out largo);
                        if (!esValido || largo <= 0 || largo > MAX_LARGO_TRIANGULO)
                        {
                            esValido = false;
                            codigoError = 6;
                        }
                        if (esValido)
                        {
                            Console.WriteLine("Ingrese el ancho de la piscina triangular: ");   // Solicitamos el ancho de la piscina triangular
                            entrada = Console.ReadLine();                                       // Leer el ancho de la piscina triangular
                            esValido = float.TryParse(entrada, out ancho);
                            if (!esValido || ancho <= 0 || ancho > MAX_ANCHO_TRIANGULO)
                            {
                                esValido = false;
                                codigoError = 7;
                            }
                        }
                        break;
                }
            }

            // PROCESO
            // Operaciones segun la opción elegida
            if (esValido) 
            { 
                switch (opcion)
                {
                    case 1:
                        superficie = largo * ancho;
                        break;
                    case 2:
                        superficie = (numeroPi * (radio * radio));
                        break;
                    case 3:
                        superficie = (0.5f * largo * ancho);
                        break;
                }
            }
            // SALIDA
            // Mostrar el resultado según la opción elegida
            if (esValido)
            {
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine($"La superficie de la piscina rectangular con un largo de { largo} m y un ancho de {ancho} m es de {superficie} m2.");
                        break;
                    case 2:
                        Console.WriteLine($"La superficie de la piscina circular con un radio de { radio} m es de {superficie} m2.");
                        break;
                    case 3:
                        Console.WriteLine($"La superficie de la piscina triangular con un largo de { largo} m y un ancho de {ancho} m es de {superficie} m2.");
                        break;
                    case 4:
                        Console.WriteLine($"Gracias por usar el programa.");
                        break;
                }
            }
            else
            {
                switch (codigoError)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                }
            }

        }
    }
}
