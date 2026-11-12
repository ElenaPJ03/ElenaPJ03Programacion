namespace R11E4_ElenaPJ
{
    internal class Program
    {
        // Realizar un programa que realice la conversión de grados Celsius a Fahrenheit. Muestre los datos introducidos y resultados por pantalla. No se podrán convertir ºC inferiores a -273 ni superiores a 500.
        static void Main(string[] args)
        {
            // CONSTANTES

            // VARIABLES
            //float conversion = 0;
            string listaDatos = "";

            // ENTRADA

            // PROCESO
            // Calculamos la conversión de los grados
            listaDatos = ConversionGrados();

            // SALIDA
            // Mostramos los resultados en una lista
            MostrarLista(listaDatos);
        }

        #region MÉTODO DE ENTRADA DE DATOS

        #endregion

        #region MÉTODOS DE PROCESAMIENTO
        static public string ConversionGrados()
        {
            // CONSTANTES
            const float VALOR_INICIAL = -273;       
            const float VALOR_FINAL = 500;

            // VARIABLES
            float celsius = 0;
            float fahrenheit = 0;

            string lista = "";

            // ENTRADA

            // PROCESO
            for (celsius = VALOR_INICIAL; celsius <= VALOR_FINAL; celsius++)
            {
                fahrenheit = (celsius * 9 / 5) + 32;                        // Conversión de celsius a fahrenheit
                lista += $"{celsius}°C \t\t {fahrenheit:F2}°F\n";           // Concatenación de la lista 
            }
            // SALIDA
            return lista;
        }
        #endregion

        #region MÉTODOS DE SALIDA DE DATOS
        static void MostrarLista(string lista)
        {
            Console.WriteLine("CELSIUS -------> FAHRENHEIT");
            Console.WriteLine(lista);
        }
        #endregion
    }
}
