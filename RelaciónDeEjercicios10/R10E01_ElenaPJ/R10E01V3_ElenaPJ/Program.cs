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

            // ENTRADA
            // 1.- Captación / Lectura del Ancho de la Piscina
            ancho = LeerAncho();

            // 2.- Captación / Lectura del Largo de la Piscina
            largo = LeerLargo();

            // 3.- Captación / Lectura de la Profundidad de la Piscina

            // PROCESO
            // 1.- Calcular la Superficie de la Piscina

            // 2.- Comprobar la Superficie de la Piscina

            // 3.- Calcular el Volumen de la Piscina (si la superficie es válida)

            // SALIDA
            // 1.- Mostrar los datos de la Piscina y los datos calculados o error de superficie
        }

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
                Console.WriteLine("Introduzca el Ancho de la Piscina: ");
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
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                }

            } while (!esCorrecto);
            

            // SALIDA
            return valorAncho;
        }

        static public float LeerLargo()
        {
            // CONSTANTES

            // VARIABLES
            float valorLargo = 0f;

            // ENTRADA

            // PROCESO

            // SALIDA
            return valorLargo;
        }
    }
}
