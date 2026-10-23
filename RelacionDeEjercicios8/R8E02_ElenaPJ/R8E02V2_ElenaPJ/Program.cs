namespace R8E02V2_ElenaPJ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CONSTANTES
            const int VALOR_INICIAL = 100;         // Las constantes las he definido tipo float ya que los ºC y ºF pueden contener decimales
            const int VALOR_FINAL = -100;
            const int DECREMENTO = 20;

            // VARIABLES
            int celsius = VALOR_INICIAL;            // Las variables las he definido tipo float ya que los ºC y ºF pueden contener decimales
            int fahrenheit;
            string lista = "";

            // ENTRADA

            // PROCESO
            // Hacemos un bucle tipo do/while
            do
            {
                fahrenheit = (celsius * 9 / 5) + 32;                     // Conersión de celsius a fahrenheit
                lista += $"{celsius}°C \t\t {fahrenheit:F2}°F\n";       // Concatenación de la lista
                celsius -= DECREMENTO;                                  // Incrementación de los datos
            } while (celsius >= VALOR_FINAL);

            // SALIDA
            // Mostramos el resultado de la lista
            Console.WriteLine("CELSIUS -------> FAHRENHEIT");
            Console.WriteLine(lista);
        }
    }
}
