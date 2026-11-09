using System.Security.Cryptography.X509Certificates;

namespace R11E2_ElenaPJ
{
    internal class Program
    {
        // Diseñar un algoritmo para determinar si un número N es primo (un número primo sólo puede ser divisible por él mismo y por la unidad).
        static void Main(string[] args)
        {
            // CONSTANTES

            // VARIABLES
            int numero = 0;
            int divisor = 0;
            
            bool esPrimo = true;    // Se supone que el usuario introducirá un número primo

            // ENTRADA
            // Captar y leer el número introducido por el usuario
            numero = CaptarNumero();

            // PROCESO
            // Calcular si el número introducido es primo o no.
            esPrimo = ComprobarPrimo(numero);

            // SALIDA
            MostrarDatoCalculado(numero,esPrimo);

            #region MÉTODOS ENTRADA DE DATOS
            static int CaptarNumero()
            {
                // CONSTANTES

                // VARIABLES
                int valorNumero = 0;
                bool esCorrecto = true;

                string entrada = "";
                byte codError = 0;      // 0 -> No hay error
                                        // 1 -> El valor no es un número o fuera del rango permitido
                                        // 2 -> El valor es negativo

                do
                {
                    // ENTRADA
                    // Inicializar el control de errores
                    codError = 0;

                    // Solicitar al usuario que introduzca un número entero positivo
                    Console.Write("Introduzca el número a evaluar: ");
                    entrada = Console.ReadLine();

                    // Procesamiento de la entrada
                    esCorrecto = int.TryParse(entrada, out valorNumero);

                    // Validación - Detectar e identificar errores
                    if (esCorrecto)
                    {
                        if (valorNumero < 0)        // El valor es negativo
                        {
                            codError = 2;
                            esCorrecto = false;
                        }
                    }
                    else
                    {
                        codError = 1;
                    }

                    // SALIDA - Retroalimentación de errores
                    switch (codError)
                    {
                        case 1:
                            MostrarMensajeError("ERROR: El valor introducido no es un número entero válido.");
                            break;
                        case 2:
                            MostrarMensajeError("ERROR: El valor introducido es negativo. Debe ser un número entero positivo.");
                            break;
                    }
                } while (!esCorrecto);

                // SALIDA
                return valorNumero;
            }
            #endregion

            #region MÉTODOS PROCESAMIENTO DE DATOS
            static bool ComprobarPrimo(int valorNumero)
            {
                // CONSTANTES

                // VARIABLES
                int divisor = 0;
                bool esPrimo = true;

                // ENTRADA

                // PROCESO
                for (divisor = 2; (divisor <= Math.Sqrt(valorNumero)) && esPrimo; divisor++)
                {
                    if (valorNumero % divisor == 0)
                    {
                        esPrimo = false;
                    }
                }

                // SALIDA
                return esPrimo;
            }
            #endregion

            #region MÉTODOS SALIDA DE DATOS 
            static void MostrarMensajeError(string mensaje)
            {
                Console.WriteLine(mensaje);

                Console.Write("Pulse Enter / Intro para continuar......");
                Console.ReadLine();      // Pausa para que el usuario lea el mensaje de error
                Console.Clear();        // Limpiar la pantalla
            }

            static void MostrarDatoCalculado(int valorNumero, bool esPrimo)
            {
                if (esPrimo)
                {
                    Console.Write($"El número {valorNumero} es Primo.");
                }
                else
                {
                    Console.Write($"El número {valorNumero} NO es primo.");
                }   
            }
            #endregion
        }
    }
}
