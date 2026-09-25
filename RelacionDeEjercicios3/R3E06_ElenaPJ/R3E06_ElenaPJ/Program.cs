namespace R3E06_ElenaPJ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CONSTANTES

            // VARIABLES
            int ancho, alto;
            int superficieEntera;
            float superficieDecimal;

            string cadenaAuxiliar;

            // ENTRADA
            // 1.- Captar ancho
            Console.Write("Introduce el ancho del triángulo: ");
            cadenaAuxiliar = Console.ReadLine();
            ancho = Convert.ToInt32(cadenaAuxiliar);

            // 2.- Captar alto
            Console.Write("Introduce el alto del triángulo: ");
            cadenaAuxiliar = Console.ReadLine();
            alto = Convert.ToInt32(cadenaAuxiliar);

            // PROCESO
            superficieEntera = (ancho * alto) / 2;
            superficieDecimal = (ancho * alto) / 2;

            //Conversión explícita de uno de los operandos de la división empleando CASTING
            superficieDecimal = (float)(ancho * alto) / 2;

            // SALIDA
            Console.WriteLine("El triángulo cuya base es " + ancho + " metros y altura es de " + alto + " metros.");
            Console.WriteLine("Tiene una superficie de " + superficieEntera + " metros cuadrados.");

            // Versión de salida PARAMETRIZADA
            Console.WriteLine($"\n\n\tEl triángulo cuya base es {ancho} metros y altura es de {alto} metros.");
            Console.WriteLine($"\tTiene una superficie de {superficieDecimal} metros cuadrados.");
        }
    }
}
