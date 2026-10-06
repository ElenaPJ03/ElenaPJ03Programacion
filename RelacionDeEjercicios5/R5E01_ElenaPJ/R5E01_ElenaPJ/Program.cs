namespace R5E01_ElenaPJ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CONSTANTES

            // VARIABLES
            float largo, ancho, superficie;

            string cadenaAuxiliar;

            // ENTRADA
            // Solicitar al usuario el largo y ancho de la piscina
            Console.Write("Introduce el largo de la piscina: ");
            cadenaAuxiliar = Console.ReadLine();
            largo = Convert.ToSingle(cadenaAuxiliar);

            Console.Write("Introduce el ancho de la piscina: ");
            cadenaAuxiliar = Console.ReadLine();
            ancho = Convert.ToSingle(cadenaAuxiliar);

            // PROCESO
            // Calcular la superficie de la piscina
            superficie = largo * ancho;

            // SALIDA
            // Mostrar la superficie de la piscina y si las medidas son adecuadas
            if (largo > 10 && ancho > 6)
            {
                Console.WriteLine("La piscina puede tener de maximo 10m de largo y 6m de ancho, introduce otras");
            }
            else
            {
                Console.WriteLine("La piscina tiene medidas adecuadas.");
            }

            if (superficie > 4)
            {
                Console.WriteLine("La superficie de la piscina es: " + superficie + " m2");
            }
            else
            {
                Console.WriteLine("La superficie de la piscina es demasiado pequeña, introduce otras medidas.");
            }
        }
    }
}
