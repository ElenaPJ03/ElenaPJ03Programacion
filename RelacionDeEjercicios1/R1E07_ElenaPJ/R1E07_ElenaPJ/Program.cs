namespace R1E07_ElenaPJ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CONTABLES

            // VARIABLES
            string nombre;
            string apellidos;
            int edad;
            // ENTRADA
            Console.WriteLine("Introduce tu nombre ");
            Console.Write("Nombre: " );
            nombre = Console.ReadLine();

            Console.Write("Introduce tus apellidos: ");
            apellidos = Console.ReadLine();

            Console.Write("Introduce tu edad: ");
            edad = int.Parse(Console.ReadLine());

            Console.WriteLine("Los datos introducidos son: ");
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Apellidos: " + apellidos);
            Console.WriteLine("Edad: " + edad);

            // PROCESO

            // SALIDA
        }
    }
}
