namespace R6E02_ElenaPJ
{
    internal class Program
    {
        // Programa que solicite dos numeros enteros y muestre un menú para elegir la operacion a realizar
        static void Main(string[] args)
        {
            // CONSTANTES
            const byte OPCION_MAX = 5;
           
            // VARIABLES
            int num1 = 0;
            int num2 = 0;
      
            int opcion = 0;         // Variable para almacenar la opcion del menu   
            int resultado = 0;

            string entrada = "";         // Cadena auxiliar para validar la entrada de datos del usuario
            bool esValido = true;       // Centinela para validar la entrada de datos
            byte codigoError = 0;       // Codigo de error para validar la entrada de datos
            /*
             Codigo de error:
             1: Entrada no valida (no es un numero o es decimal)
             2: Opcion del menu no valida
             3: Opcion del menu fuera de rango
            */

            // ENTRADA
            // Solicitamos al usuario que ingrese tres numeros
            Console.WriteLine("Ingrese el primer numero: ");
            entrada = Console.ReadLine();       // Leemos la entrada del usuario
            esValido = int.TryParse(entrada, out num1);
            Console.WriteLine("Ingrese el segundo numero: ");
            entrada = Console.ReadLine();
            esValido = int.TryParse(entrada, out num2);

            // Validacion de que los numeros ingresados no sean decimales
            if (int.TryParse(entrada, out num1) == false || int.TryParse(entrada, out num2) == false)
            {
                esValido = false;
                codigoError = 1;
            }

            // Mostramos el menú
            Console.WriteLine ("\t\t\t Selecciona que operación desea realizar: \n");
            Console.WriteLine ("\t 1. Suma");
            Console.WriteLine ("\t 2. Resta");
            Console.WriteLine ("\t 3. Producto");
            Console.WriteLine ("\t 4. Division");
            Console.WriteLine ("\t 5. Salir");
            entrada = Console.ReadLine();
            esValido = int.TryParse(entrada, out opcion);

            // Validacion / Identificacion de errores
            if (!esValido)      // if (esValido == false)
            {
                codigoError = 2;
            }
            else if (opcion > OPCION_MAX)       
            {
                esValido = false;
                codigoError = 3;
            }

            // PROCESO
            if (esValido)
            {
                switch (opcion)
                {
                    case 1:
                        resultado = num1 + num2;
                        break;
                    case 2:
                        resultado = num1 - num2;
                        break;
                    case 3:
                        resultado = num1 * num2;
                        break;
                    case 4:     // Validamos que no se divida por cero
                        if (num1 != 0 && num2 != 0)
                        {
                            resultado = num1 / num2;
                        }
                        else
                        {
                            esValido = false;
                            Console.WriteLine("ERROR: No se puede dividir por cero, introduce datos válidos.");
                        }
                        break;

                }
            }
            // SALIDA
            if (esValido)       // Si no hay error, mostramos el mensaje correspondiente
            {
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine($"La suma de {num1}, {num2} y es: {resultado}");
                        break;
                    case 2:
                        Console.WriteLine($"La resta de {num1}, {num2} y es: {resultado}");
                        break;
                    case 3:
                        Console.WriteLine($"El producto de {num1}, {num2} y es: {resultado}");
                        break;
                    case 4:
                        Console.WriteLine($"La división de {num1}, {num2} y es: {resultado}");
                        break;
                    case 5:
                        Console.WriteLine("Gracias por usar el programa, hasta luego.");
                        break;
                }
            }
            else        // Si hay error, mostramos el mensaje de error correspondiente
            {
                switch (codigoError)
                {
                    case 1:
                        Console.WriteLine("ERROR: Entrada no válida");
                        break;
                    case 2:
                        Console.WriteLine("ERROR: Ha seleccionado una opción del menú no válida");
                        break;
                    case 3:
                        Console.WriteLine("ERROR: Ha seleccionado una opción del menú fuera de rango");
                        break;
                }
            }
        }
    }
}
