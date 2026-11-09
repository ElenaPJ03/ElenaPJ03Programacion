namespace R11E01V1_ElenaPJ
{
    internal class Program
    {
        // Diseñar un programa que determine si un número entero es par o impar.

        static void Main(string[] args)
        {
            // CONSTANTES

            // VARIABLES
            int numero = 0;

            bool esPar = true; 

            // ENTRADA
            // 1.- Captación / Lectura del número entero
            numero = LeerNumero();

            // PROCESO
            // Comprobramos si el número es Par o Impar
            esPar = ComprobarNumero(numero);

            // SALIDA
            MostrarResultado(numero, esPar);
        }

        #region MÉTODO DE ENTRADA DE DATOS

        static public int LeerNumero()
        {
            // CONSTANTES

            // VARIABLES
            int valorNumero = 0;
            string cadena = "";

            // Detención e Identificación de Errores
            bool esCorrecto = true;
            byte codError = 0;      // 0-> No hay error
                                    // 1-> No es un valor numérico o está fuera del rango de int
                                    // 2-> Es un número negativo

            do 
            {
                // Inicializamos el código de error a 0 (no hay error)
                codError = 0;

                // ENTRADA - Solicitud empleando la Interfaz de Usuario
                Console.Write("Introduzca un número entero positivo: ");
                cadena = Console.ReadLine();

                // PROCESO - Validación de la entrada
                esCorrecto = int.TryParse(cadena, out valorNumero);

                if (esCorrecto)
                {
                    // Número es negativo
                    if (valorNumero < 0)
                    {
                        esCorrecto = false;
                        codError = 2;
                    }
                }
                else        // Suponemos que va a introducir un número correcto
                {
                    codError = 1;
                }

                // SALIDA - Retroalimentación de Errores (Interfaz de Usuario)
                switch (codError)
                {
                    case 1:
                        MostrarMensajeError("ERROR: No es un valor númerico o está fuera del rango");
                        break;
                    case 2:
                        MostrarMensajeError("ERROR: El número es negativo");
                        break;
                }
            } while (!esCorrecto);

            // SALIDA
            return valorNumero;
        }

        #endregion

        #region MÉTODO DE PROCESAMIENTO
        
        static public bool ComprobarNumero(int valorNumero)
        {
            // CONSTANTES

            // VARIABLES
            bool esNumeroPar = true;

            // ENTRADA

            // PROCESO
            if (valorNumero % 2 != 0)
            {
                esNumeroPar = false;
            }
            
            //if (valorNumero % 2 == 0)
            //{
            //    esNumeroPar = true;
            //}
            //else
            //{
            //    esNumeroPar = false;
            //}

            // SALIDA
            return esNumeroPar;

        }

        #endregion

        #region MÉTODO DE SALIDA DE DATOS
        static public void MostrarResultado(int valorNumero, bool esPar)
        {
            if (esPar)
            {
                Console.WriteLine($"El número {valorNumero} es Par");
            }
            else
            {
                Console.WriteLine($"El número {valorNumero} es Impar");
            }
        }

        static void MostrarMensajeError(string mensaje)
        {
            Console.WriteLine(mensaje);

            Console.Write("Pulse Enter / Intro para continuar......");
            Console.ReadLine();      // Pausa para que el usuario lea el mensaje de error
            Console.Clear();        // Limpiar la pantalla
        }

        #endregion
    }
}
