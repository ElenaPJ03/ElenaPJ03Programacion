namespace R10E01V3_ElenaPJ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CONSTANTES

            // VARIABLES
            float ancho = 0f;
            float largo = 0f;
            float profundidad = 0f;
            float superficie = 0f;
            bool superficieCorrecta = true;
            float volumen = 0f;

            // ENTRADA
            // 1.- Captación / Lectura del Ancho de la Piscina
            ancho = LeerAncho();

            // 2.- Captación / Lectura del Largo de la Piscina
            largo = LeerLargo();

            // 3.- Captación / Lectura de la Profundidad de la Piscina
            profundidad = LeerProfundidad();

            // PROCESO
            // 1.- Calcular la Superficie de la Piscina
            superficie = CalcularSuperficie(ancho, largo);

            // 2.- Comprobar la Superficie de la Piscina
            superficieCorrecta = ComprobarSuperficie(superficie);

            // 3.- Calcular el Volumen de la Piscina (si la superficie es válida)
            if (superficieCorrecta)
            {
                volumen = CalcularVolumen(superficie, profundidad);
            }

            // SALIDA
            // 1.- Mostrar los datos de la Piscina y los datos calculados o error de superficie
            if (superficieCorrecta)
            {
                // 1 Método - Todos los argumentos (ancho, largo, profundidad, superficie y volumen)

                // 1 Método - Los datos de entrada (ancho, largo, profundidad) 1 Método - Los datos calculados (superficie y volumen)
                MostrarDatosEntrada(ancho, largo, profundidad);
                MostrarDatosCalculados(superficie, volumen);
            }
            else
            {
                // Mensaje de Error
                MostrarMensajeError("La Superficie no cumple con los requisitos.");
            }
        }

        #region MÉTODOS DE ENTRADA DE DATOS
        static public float LeerAncho()
        {
            // CONSTANTES
            const float ANCHO_MIN = 2.5f;
            const float ANCHO_MAX = 10.25f;

            // VARIABLES
            float valorAncho = 0f;

            string cadena = "";

            // Detección e Idenficación de Errores
            bool esCorrecto = true;
            byte codError = 0;      // 0-> No hay error
                                    // 1-> No es un valor numérco o está fuera del rango de float
                                    // 2-> Ancho inferior al mínimo
                                    // 3-> Ancho superior al máximo

            do
            {
                codError = 0;       // Preparamos el identificador de errores en cada iteración / repetición

                // ENTRADA - Solicitud empleando la Interfaz de Usuario
                Console.Write("Introduzca el Ancho de la Piscina: ");
                cadena = Console.ReadLine();

                // PROCESO - Validación
                esCorrecto = Single.TryParse(cadena, out valorAncho);       // int -> Int32

                if (esCorrecto)
                {
                    // Ancho es Inferior al Mínimo
                    if (valorAncho < ANCHO_MIN)
                    {
                        esCorrecto = false;
                        codError = 2;
                    }

                    // Ancho es Superior al Máximo
                    if (valorAncho > ANCHO_MAX)
                    {
                        esCorrecto = false;
                        codError = 3;
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
                        MostrarMensajeError("ERROR: No es un valor numérico o está fuera del rango.");
                        break;
                    case 2:
                        MostrarMensajeError($"ERROR: El Ancho inferior a {ANCHO_MIN} metros.");
                        break;
                    case 3:
                        MostrarMensajeError($"ERROR: El Ancho superior a {ANCHO_MAX} metros.");
                        break;
                }

            } while (!esCorrecto);
            

            // SALIDA
            return valorAncho;
        }

        static public float LeerLargo()
        {
            // CONSTANTES
            const float LARGO_MIN = 2.5f;
            const float LARGO_MAX = 20.5f;

            // VARIABLES
            float valorLargo = 0f;

            string cadena = "";

            // Detección e Idenficación de Errores
            bool esCorrecto = true;
            byte codError = 0;      // 0-> No hay error
                                    // 1-> No es un valor numérco o está fuera del rango de float
                                    // 2-> Largo inferior al mínimo
                                    // 3-> Largo superior al máximo

            do
            {
                codError = 0;       // Preparamos el identificador de errores en cada iteración / repetición

                // ENTRADA - Solicitud empleando la Interfaz de Usuario
                Console.Write("Introduzca el Largo de la Piscina: ");
                cadena = Console.ReadLine();

                // PROCESO - Validación
                esCorrecto = Single.TryParse(cadena, out valorLargo);       // int -> Int32

                if (esCorrecto)
                {
                    // Largo es Inferior al Mínimo
                    if (valorLargo < LARGO_MIN)
                    {
                        esCorrecto = false;
                        codError = 2;
                    }

                    // Largo es Superior al Máximo
                    if (valorLargo > LARGO_MAX)
                    {
                        esCorrecto = false;
                        codError = 3;
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
                        MostrarMensajeError("ERROR: No es un valor numérico o está fuera del rango.");
                        break;
                    case 2:
                        MostrarMensajeError($"ERROR: El Largo inferior a {LARGO_MIN} metros.");
                        break;
                    case 3:
                        MostrarMensajeError($"ERROR: El Largo superior a {LARGO_MAX} metros.");
                        break;
                }

            } while (!esCorrecto);

            // SALIDA
            return valorLargo;
        }

        static public float LeerProfundidad()
        {
            // CONSTANTES
            const float PROFUNDIDAD_MIN = 0.5f;
            const float PROFUNDIDAD_MAX = 5.75f;

            // VARIABLES
            float valorProfundidad = 0f;

            string cadena = "";

            // Detección e Idenficación de Errores
            bool esCorrecto = true;
            byte codError = 0;      // 0-> No hay error
                                    // 1-> No es un valor numérco o está fuera del rango de float
                                    // 2-> Largo inferior al mínimo
                                    // 3-> Largo superior al máximo

            do
            {
                codError = 0;       // Preparamos el identificador de errores en cada iteración / repetición

                // ENTRADA - Solicitud empleando la Interfaz de Usuario
                Console.Write("Introduzca la profundidad de la Piscina: ");
                cadena = Console.ReadLine();

                // PROCESO - Validación
                esCorrecto = Single.TryParse(cadena, out valorProfundidad);       // int -> Int32

                if (esCorrecto)
                {
                    // Profundidad es Inferior al Mínimo
                    if (valorProfundidad < PROFUNDIDAD_MIN)
                    {
                        esCorrecto = false;
                        codError = 2;
                    }

                    // Profundidad es Superior al Máximo
                    if (valorProfundidad > PROFUNDIDAD_MAX)
                    {
                        esCorrecto = false;
                        codError = 3;
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
                        MostrarMensajeError("ERROR: No es un valor numérico o está fuera del rango.");
                        break;
                    case 2:
                        MostrarMensajeError($"ERROR: La Profundidad inferior a {PROFUNDIDAD_MIN} metros.");
                        break;
                    case 3:
                        MostrarMensajeError($"ERROR: La Profundidad superior a {PROFUNDIDAD_MAX} metros.");
                        break;
                }

            } while (!esCorrecto);

            // SALIDA
            return valorProfundidad;
        }

        #endregion

        #region MÉTODOS DE PROCESAMIENTO
        static public float CalcularSuperficie(float base1, float altura)
        {
            // CONSTANTES
            const float SUPERFICIE_MIN = 6f;

            // VARIABLES
            float area = 0f;

            // ENTRADA

            // PROCESO
            area = base1 * altura;

            // SALIDA
            return area;
        }

        static public bool ComprobarSuperficie(float area)
        {
            // CONSTANTES
            const float SUPERFICIE_MIN = 6f;

            // VARIABLES
            bool superficieValida = true;

            // ENTRADA

            // PROCESO
            //if (area > SUPERFICIE_MIN)
            //{
            //    superficieValida = true;
            //}
            //else
            //{
            //    superficieValida = false;
            //}

            superficieValida = area > SUPERFICIE_MIN;       // Si el area es mayor que la superficie mínima, la superficie es válida. En caso contrario, no lo es.

            // SALIDA
            return superficieValida;
        }

        static public float CalcularVolumen(float area, float hondo)
        {
            // CONSTANTES

            // VARIABLES

            // ENTRADA

            // PROCESO

            // SALIDA
            return area * hondo;
        }

        #endregion

        #region MÉTODOS DE SALIDA DE RESULTADOS

        static public void MostrarMensajeError(string mensaje)
        {
            Console.WriteLine(mensaje);

            Console.Write("Pulse Enter / Intro para continuar......");
            Console.ReadLine();      // Pausa para que el usuario lea el mensaje de error
            Console.Clear();        // Limpiar la pantalla
        }

        static public void MostrarDatosEntrada(float ancho, float largo, float profundidad)
        {
            Console.WriteLine("\n ------- RESULTADOS ------- ");
            Console.WriteLine($"Ancho: {ancho} metros.");
            Console.WriteLine($"Largo: {largo} metros.");
            Console.WriteLine($"Profundidad: {profundidad} metros.");
        }

        static public void MostrarDatosCalculados(float superficie, float volumen)
        {
            Console.WriteLine($"Superficie: {superficie} metros cuadrados.");
            Console.WriteLine($"Volumen: {volumen} metros cúbicos.");
        }

        #endregion
    }
}
