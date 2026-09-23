namespace R3E01_ElenaPJ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CONSTANTES

            // VARIABLES

            // ENTRADA
            string nombre;
            string apellido1;
            string apellido2;

            // PROCESO

            // SALIDA
            //Solicitar al usuario que introduzca su nombre y apellidos
            Console.Write("Introduce tu nombre y apellidos: ");
            nombre = Console.ReadLine();
            apellido1 = Console.ReadLine();
            apellido2 = Console.ReadLine();

            // Mostrar por pantalla el nombre y apellidos introducidos
            Console.WriteLine("Los datos introducidos son: " + apellido1 + " " + apellido2 + ", " + nombre);

        }
    }
}
