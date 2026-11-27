namespace R14E01_ElenaPJ
{
    internal class Program
    {
        // Realizar un programa que realice la conversión de grados Celsius a Fahrenheit y muestre una tabla(con encabezamiento) para valores de grados Celsius comprendidos entre –100 y 100 con un incremento de 20.
        static void Main(string[] args)
        {
            // CONSTANTES
            const float VALOR_INICIAL = -100;
            const float VALOR_FINAL = 100;
            const int TAMANO = (int)(VALOR_FINAL - VALOR_INICIAL) + 1;

            // VARIABLES
            float[] celsius = new float[TAMANO];
            float[] fahrenheit = new float[TAMANO];
            string lista = "";

            // ENTRADA
            // Encabezamiento del programa
            Console.WriteLine("==========================================");
            Console.WriteLine("CONVERSOR DE TEMPERATURAS (°C A °F)");
            Console.WriteLine("Rango: -200 °C a 1500 °C");
            Console.WriteLine("==========================================\n");

            // PROCESO
            // Calculo de Celsius a Fahrenheit
            for (int i = 0; i < TAMANO; i++)
            {
                celsius[i] = VALOR_INICIAL + i;
                fahrenheit[i] = (celsius[i] * 9f / 5f) + 32;        // Conversión de Celsius a fahrenheit
                lista += $"{celsius[i]}ºC \t\t {fahrenheit[i]:F2}ºF|n";         // Concatenación de la lista
            }

            // SALIDA
            // Mostrar resultados
            Console.WriteLine("CELSIUS ---------> FAHRENHEIT");
            Console.WriteLine(lista);
        }
    }
}
