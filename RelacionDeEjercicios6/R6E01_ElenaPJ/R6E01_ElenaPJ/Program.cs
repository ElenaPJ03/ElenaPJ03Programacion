namespace R6E01_ElenaPJ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CONSTANTES
            const int MIN_OPCION = 1;   // 1 es la primera opcion del menu
            const int MAX_OPCION = 5;    // 5 es la ultima opcion del menu

            // VARIABLES
            int opcion;                    // opcion elegida por el usuario
            bool esCorrecto;                // centinela 
            byte codigoError = 0;
            /*
              0 - No hay error
              1 - No es un numero
              2 - Numero fuera de rango en las opciones
            */

            string cadenaAuxiliar;        // variable auxiliar para leer la opcion elegida por el usuario

            // ENTRADA
            // Mostrar el menu de opciones
            Console.WriteLine("Selecciona la opcion de la figura que desees ver: ");
            Console.WriteLine("1.Triangulo - 2.Escuadra - 3.Escuadra2 - 4.Piramide invertida - 5.Piramide");

            // Leer la opcion elegida por el usuario
            cadenaAuxiliar = Console.ReadLine();
            esCorrecto = Int32.TryParse(cadenaAuxiliar, out opcion);

            // Validar que la opcion sea un numero y que este dentro del rango de opciones
            if (!esCorrecto)    // No es un numero
            {
                codigoError = 1;            
            }
            else
            {
                if (opcion < MIN_OPCION || opcion > MAX_OPCION)   // No esta dentro del rango de opciones
                {
                    esCorrecto = false;    
                    codigoError = 2;
                }
            }

            //PROCESO
            // No hay proceso en este programa / no se necesita 


            //SALIDA
            // Mostrar la figura elegida por el usuario o el error correspondiente
            switch (codigoError)
            {
                case 0:     // No hay error
                    Console.WriteLine();
                    switch (opcion)
                    {
                        case 1:     // Triangulo
                            Console.WriteLine("*");
                            Console.WriteLine("* *");
                            Console.WriteLine("* * *");             
                            Console.WriteLine("* * * *");
                            Console.WriteLine("* * * * *");
                            break;
                        case 2:     // Escuadra
                            Console.WriteLine("* * * * *");
                            Console.WriteLine("* * * *");
                            Console.WriteLine("* * *");              
                            Console.WriteLine("* *");
                            Console.WriteLine("*");
                            break;
                        case 3:     // Escuadra2
                            Console.WriteLine("* * * * *");
                            Console.WriteLine("  * * * *");
                            Console.WriteLine("    * * *");         
                            Console.WriteLine("      * *");
                            Console.WriteLine("        *");
                            break;
                        case 4:     // Piramide invertida
                            Console.WriteLine("* * * * *");
                            Console.WriteLine(" * * * *");
                            Console.WriteLine("  * * *");          
                            Console.WriteLine("   * *");
                            Console.WriteLine("    *");
                            break;
                        case 5:     // Piramide
                            Console.WriteLine("    *");
                            Console.WriteLine("   * *");
                            Console.WriteLine("  * * *");           
                            Console.WriteLine(" * * * *");
                            Console.WriteLine("* * * * *");
                            break;
                    }
                    break;
                case 1:     // No es un numero
                    Console.WriteLine("ERROR: Lo introducido no es un numero");
                    break;
                case 2:     // Numero fuera de rango en las opciones
                    Console.WriteLine($"ERROR: La opcion {opcion} no esta entre el rango establecido 1-5.");
                    break;
            }
        }
    }
}
