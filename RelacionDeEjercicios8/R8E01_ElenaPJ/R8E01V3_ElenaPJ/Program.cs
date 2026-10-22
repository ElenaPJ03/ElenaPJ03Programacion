namespace R8E01V3_ElenaPJ
{
    internal class Program
    {
        // Realizar un programa que realice la conversión de grados Celsius a Fahrenheit y muestre una tabla (con encabezamiento) para valores de grados Celsius comprendidos entre -100 y 100 con un incremento de 20

        static void Main(string[] args)
        {
            // CONSTANTES
            const float VALOR_INICIAL = -100;       // Las constantes las he definido tipo float ya que los ºC y ºF pueden contener decimales
            const float VALOR_FINAL = 100;
            const float INCREMENTO = 20;

            // VARIABLES
            float celsius;                          // Las variables las he definido tipo float ya que los ºC y ºF pueden contener decimales
            float fahrenheit;
            string lista = "";

            // ENTRADA

            // PROCESO
            // Hacemos un bucle tipo for
            for (celsius = VALOR_INICIAL; celsius <= VALOR_FINAL; celsius += INCREMENTO)
            {
                fahrenheit = (celsius * 9 / 5) + 32;                        // Conersión de celsius a fahrenheit
                lista += $"{celsius}°C \t\t {fahrenheit:F2}°F\n";           // Concatenación de la lista            
            }
           
            // SALIDA
            // Mostramos el resultado de la lista
            Console.WriteLine("CELSIUS -------> FAHRENHEIT");
            Console.WriteLine(lista);
        }
    }
}
