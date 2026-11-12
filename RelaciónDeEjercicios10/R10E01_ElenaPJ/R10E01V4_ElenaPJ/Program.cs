namespace R10E01V4_ElenaPJ
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
            ancho = EntradaDatos.LeerAncho();

            // 2.- Captación / Lectura del Largo de la Piscina
            largo = EntradaDatos.LeerLargo();

            // 3.- Captación / Lectura de la Profundidad de la Piscina
            profundidad = EntradaDatos.LeerProfundidad();

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
