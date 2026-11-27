namespace PoyectoGestionNominas_ElenaPJ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CONSTANTES
            const int MAX_HORAS_TRABAJADAS = 60;    // Máximo de horas de trabajo a la semana
            const int MIN_HORAS_TRABAJADAS = 3;     // Suposición - Mínimo de horas de trabajo a la semana

            const float MAX_PRECIO_HORA = 22.5f;    // Máximo valor de la hora trabajada
            const float MIN_PRECIO_HORA = 2f;       // Suposición - Mínimo valor de la hora trabajada

            // VARIABLES
            string nombre = "";
            string apellidos = "";
            string puesto = "";

            int horasTotales = 0;
            float precioHora = 0;

            string aux = "";

            bool esCorrecto = true;

            byte codigoError;       // 0 -> No se han producido errores
                                    // 1 -> El valor introducido no es del tipo int/float
                                    // 2 -> El valor introducido no puede ser mayor que valorMaximo
                                    // 3 -> El valor introducido no puede ser menor que valorMinimo

            // ENTRADA
            // 1.- Encabezado y solicitud del nombre, apellidos y puesto del trabajador
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

            // 2.- Solicitud del numero de horas trabajadas
            do
            {
                // Inicialización del código de error
                codigoError = 0;
                // Solicitud del número de horas semanales trabajadas
                Console.WriteLine("Introduzca el número de horas semanales trabajadas: ");
                aux = Console.ReadLine();
                // Pasar de string a int
                esCorrecto = Int32.TryParse(aux, out horasTotales);

                // Detención e Identificación de errores
                if (esCorrecto)
                {
                    codigoError = 0;
                }
                else if ((horasTotales < MIN_HORAS_TRABAJADAS) || (horasTotales > MAX_HORAS_TRABAJADAS))
                {
                    esCorrecto = false;
                    if (horasTotales < MIN_HORAS_TRABAJADAS)
                    {
                        codigoError = 3;
                    }
                    else
                    {
                        codigoError = 2;
                    }
                }

                // Mensajes de error
                if (!esCorrecto)
                {
                    Console.Clear();        // Limpiar la consola

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

            // 3.- Solicitud del precio por hora trabajadas
            do
            {
                // Inicialización del código de error
                codigoError = 0;
                // Solicitud del precio por horas trabajadas
                Console.WriteLine("Introduzca el precio por horas trabajadas: ");
                aux = Console.ReadLine();
                // Pasar de string a int
                esCorrecto = Single.TryParse(aux, out precioHora);

                // Detención e Identificación de errores
                if (esCorrecto)
                {
                    codigoError = 0;
                }
                else if ((horasTotales < MIN_PRECIO_HORA) || (horasTotales > MAX_PRECIO_HORA))
                {
                    esCorrecto = false;
                    if (horasTotales < MIN_PRECIO_HORA)
                    {
                        codigoError = 3;
                    }
                    else
                    {
                        codigoError = 2;
                    }
                }

                // Mensajes de error
                if (!esCorrecto)
                {
                    Console.Clear();        // Limpiar la consola

                    switch (codigoError)
                    {
                        case 1:
                            Console.WriteLine($"ERROR: \"{aux}\" no es un NUMERO ENTERO o no esta dentro del rango de la variable de tipo \"int\"");
                            break;
                        case 2:
                            Console.WriteLine($"ERROR: El valor introducido no puede ser mayor que {MIN_PRECIO_HORA}");
                            break;
                        case 3:
                            Console.WriteLine($"ERROR: El valor introducido no puede ser menor que {MAX_PRECIO_HORA}");
                            break;
                    }
                }
            } while (!esCorrecto);

            Console.Clear();        // Limpieza de los datos de la consola
            // PROCESO
            // 4.- Calcular la nómina

            // SALIDA
            // Mostrar los datos calculados por salida
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
