namespace R10E1V5_ElenaPJ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CONSTANTES
            const float ANCHO_MIN = 2.5f;
            const float ANCHO_MAX = 10.25f;

            const float LARGO_MIN = 2.5f;
            const float LARGO_MAX = 20.5f;

            const float PROFUNDIDAD_MIN = 0.5f;
            const float PROFUNDIDAD_MAX = 5.75f;

            // VARIABLES
            float ancho = 0f;
            float largo = 0f;
            float profundidad = 0f;
            float superficie = 0f;
            bool superficieCorrecta = true;
            float volumen = 0f;

            // ENTRADA
            // 1.- Captación / Lectura del Ancho de la Piscina
            //ancho = EntradaDatos.LeerAncho();

            // V5: Lectura de la Medida mediante un método General a reutilizar con el resto de medidas
            ancho = EntradaDatos.LeerMedida("Ancho", ANCHO_MIN, ANCHO_MAX);

            // 2.- Captación / Lectura del Largo de la Piscina
            //largo = EntradaDatos.LeerLargo();

            // V5
            largo = EntradaDatos.LeerMedida("Largo", LARGO_MIN, LARGO_MAX);

            // 3.- Captación / Lectura de la Profundidad de la Piscina
            //profundidad = EntradaDatos.LeerProfundidad();

            // V3
            profundidad = EntradaDatos.LeerMedida("Profundidad", PROFUNDIDAD_MIN, PROFUNDIDAD_MAX);

            // PROCESO
            // 1.- Calcular la Superficie de la Piscina
            superficie = ProcesoDatos.CalcularSuperficie(ancho, largo);

            // 2.- Comprobar la Superficie de la Piscina
            superficieCorrecta = ProcesoDatos.ComprobarSuperficie(superficie);

            // 3.- Calcular el Volumen de la Piscina (si la superficie es válida)
            if (superficieCorrecta)
            {
                volumen = ProcesoDatos.CalcularVolumen(superficie, profundidad);
            }

            // SALIDA
            // 1.- Mostrar los datos de la Piscina y los datos calculados o error de superficie
            if (superficieCorrecta)
            {
                // 1 Método - Todos los argumentos (ancho, largo, profundidad, superficie y volumen)

                // 1 Método - Los datos de entrada (ancho, largo, profundidad) 1 Método - Los datos calculados (superficie y volumen)
                SalidaResultados.MostrarDatosEntrada(ancho, largo, profundidad);
                SalidaResultados.MostrarDatosCalculados(superficie, volumen);
            }
            else
            {
                // Mensaje de Error
                SalidaResultados.MostrarMensajeError("La Superficie no cumple con los requisitos.");
            }
        }
    }
}
