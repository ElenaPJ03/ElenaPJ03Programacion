namespace GestionNominasV1
{
    class Program
    {
        static void Main(string[] args)
        {
            //DEFINICIÓN DE CONSTANTES
            const int MAX_HORAS_TRABAJADAS = 60;    // Máximo de horas de trabajo a la semana
            const int MIN_HORAS_TRABAJADAS = 3;     // Suposición - Mínimo de horas de trabajo a la semana

            const float MAX_PRECIO_HORA = 220.5f;   // Máximo valor de la hora trabajada
            const float MIN_PRECIO_HORA = 2f;       // Suposición - Mínimo valor de la hora trabajada


            //DECLARACIÓN DE VARIABLES
            string nombre, apellidos, puesto;
            int horasTotales;
            float precioHora;
            string aux;
            bool esCorrecto;
            byte codigoError;
            /* CÓDIGO       SIGNIFICADO
             *   0          No se han producido errores
             *   1          El valor introducido no es del tipo "int"/"float"
             *   2          El valor introducido no puede ser mayor que valorMaximo
             *   3          El valor introducido no puede ser menor que valorMinimo
             */


            //Inicialización de variables
            nombre = apellidos = puesto = "";
            horasTotales = 0;
            precioHora = 0;

            //ENTRADA

            //PASO 1: Encabezado y solicitud del nombre, apellidos y puesto del trabajador
            Console.WriteLine("*******************************************************************");
            Console.WriteLine("*                                                                 *");
            Console.WriteLine("*          Calculador del salario semanal de un empleado          *");
            Console.WriteLine("*                                                                 *");
            Console.WriteLine("*******************************************************************");

            Console.WriteLine("");
            Console.Write("Introduzca el nombre del trabajador: ");
            nombre = Console.ReadLine();

            Console.WriteLine("");
            Console.Write("Introduzca los apellidos del trabajador: ");
            apellidos = Console.ReadLine();

            Console.WriteLine("");
            Console.Write("Introduzca el puesto del trabajador: ");
            puesto = Console.ReadLine();

            //PASO 2: Solicitud del numero de horas trabajadas
            do
            {
                //Inicialización del código de error
                codigoError = 0;

                //Solicitud del número de horas semanales trabajadas
                Console.Write("\nIntroduzca el numero de horas trabajadas: ");
                aux = Console.ReadLine();
                //Detección del posible error y/o conversión de string a byte
                esCorrecto = Int32.TryParse(aux, out horasTotales);

                //Detección e identificación de posibles errores
                if (!esCorrecto) codigoError = 1;  //Identificación del error
                else if ((horasTotales > MAX_HORAS_TRABAJADAS) || (horasTotales <= MIN_HORAS_TRABAJADAS))
                {
                    esCorrecto = false;    //Detección del error

                    //Identificación de los dos posibles errores
                    if (horasTotales > MAX_HORAS_TRABAJADAS) codigoError = 3;
                    else codigoError = 2;
                }

                //Mensajes de error mostrados en caso de que se produzca alguno
                if (esCorrecto)
                {
                    Console.Clear();    //Limpieza de los mensajes mostrados en la consola

                    switch (codigoError)
                    {
                        case 1:
                            Console.WriteLine($"ERROR: \"{aux}\" no es un NUMERO ENTERO o no esta dentro del rango de la variable de tipo \"int\"");
                            break;
                        case 2:
                            Console.WriteLine($"ERROR: El valor introducido no puede ser mayor que {MAX_HORAS_TRABAJADAS}");
                            break;
                        case 3:
                            Console.WriteLine($"ERROR: El valor introducido no puede ser menor que {MIN_HORAS_TRABAJADAS}");
                            break;
                    }
                }

            } while (!esCorrecto);


            //PASO 3: Solicitud del precio de la hora trabajada
            do
            {
                //Inicialización del código de error
                codigoError = 0;

                //Solicitud del número de horas semanales trabajadas
                Console.Write("\nIntroduzca el precio de la hora trabajada: ");
                aux = Console.ReadLine();
                //Detección del posible error y/o conversión de string a byte
                esCorrecto = Single.TryParse(aux, out precioHora);

                //Detección e identificación de posibles errores
                if (!esCorrecto) codigoError = 1;  //Identeficación del error
                else if ((precioHora > MAX_PRECIO_HORA) && (precioHora < MIN_PRECIO_HORA))
                {
                    esCorrecto = false;    //Detección del error

                    //Identificación de los dos posibles errores
                    if (precioHora < MAX_PRECIO_HORA) codigoError = 2;
                    else codigoError = 3;
                }

                //Mensajes de error mostrados en caso de que se produzca alguno
                if (!esCorrecto)
                {
                    Console.Clear();    //Limpieza de los mensajes mostrados en la consola

                    switch (codigoError)
                    {
                        case 1:
                            Console.WriteLine($"ERROR: \"{aux}\" no es un NUMERO REAL o no esta dentro del rango de la variable de tipo \"float\"");
                            break;
                        case 2:
                            Console.WriteLine($"ERROR: El valor introducido no puede ser mayor que {MAX_PRECIO_HORA}");
                            break;
                        case 3:
                            Console.WriteLine($"ERROR: El valor introducido no puede ser menor que {MIN_PRECIO_HORA}");
                            break;
                    }
                }

            } while (!esCorrecto);

            Console.Clear();    //Limpieza de los mensajes mostrados en la consola

            //PROCESO


            //SALIDA

            Console.WriteLine("************************************************************************************************************************");
            Console.WriteLine("");
            Console.WriteLine($"Puesto:\t\t{puesto}");
            Console.WriteLine($"Nombre:\t\t{nombre}\t\tApellidos:\t{apellidos}");
            Console.WriteLine("");
            Console.WriteLine("************************************************************************************************************************");
            Console.WriteLine("");
            Console.WriteLine($"\t\tHoras Trabajadas:\t{horasTotales}");
            Console.WriteLine($"\t\tPrecio por hora:\t{precioHora} Euros/Hora");
            Console.WriteLine("");
            Console.WriteLine("************************************************************************************************************************");

            Console.WriteLine("\n");
            Console.WriteLine("Pulse ENTER para continuar...");
            Console.ReadLine();
        }

    }
}
