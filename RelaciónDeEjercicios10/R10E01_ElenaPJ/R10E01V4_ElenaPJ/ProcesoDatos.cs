using System;
using System.Collections.Generic;
using System.Text;

namespace R10E01V4_ElenaPJ
{
    public static class ProcesoDatos
    {
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
    }
}
