using System;
using System.Collections.Generic;
using System.Text;

namespace R10E01V4_ElenaPJ
{
    public static class EntradaDatos
    {
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
                        SalidaResultados.MostrarMensajeError("ERROR: No es un valor numérico o está fuera del rango.");
                        break;
                    case 2:
                        SalidaResultados.MostrarMensajeError($"ERROR: El Ancho inferior a {ANCHO_MIN} metros.");
                        break;
                    case 3:
                        SalidaResultados.MostrarMensajeError($"ERROR: El Ancho superior a {ANCHO_MAX} metros.");
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
                        SalidaResultados.MostrarMensajeError("ERROR: No es un valor numérico o está fuera del rango.");
                        break;
                    case 2:
                        SalidaResultados.MostrarMensajeError($"ERROR: El Largo inferior a {LARGO_MIN} metros.");
                        break;
                    case 3:
                        SalidaResultados.MostrarMensajeError($"ERROR: El Largo superior a {LARGO_MAX} metros.");
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
                        SalidaResultados.MostrarMensajeError("ERROR: No es un valor numérico o está fuera del rango.");
                        break;
                    case 2:
                        SalidaResultados.MostrarMensajeError($"ERROR: La Profundidad inferior a {PROFUNDIDAD_MIN} metros.");
                        break;
                    case 3:
                        SalidaResultados.MostrarMensajeError($"ERROR: La Profundidad superior a {PROFUNDIDAD_MAX} metros.");
                        break;
                }

            } while (!esCorrecto);

            // SALIDA
            return valorProfundidad;
        }

        #endregion
    }
}
