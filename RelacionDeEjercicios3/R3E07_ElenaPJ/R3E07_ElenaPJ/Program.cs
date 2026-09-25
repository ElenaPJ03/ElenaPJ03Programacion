namespace R3E07_ElenaPJ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CONSTANTES

            // VARIABLES
            byte edad;
            bool esMayorEdad;

            string cadenaAuxiliar;

            // ENTRADA
            //Solicitar al usuario que introduzca su edad
            Console.Write("Introduce tu edad: ");
            cadenaAuxiliar = Console.ReadLine();
            edad = Convert.ToByte(cadenaAuxiliar);

            // PROCESO
            //Calcular si el usuario es mayor de edad
            esMayorEdad = edad >= 18;

            // SALIDA
            //Mostrar al usuario su edad y si es mayor de edad
            Console.WriteLine("El usuario con " + edad + " años");
            Console.Write("Mayor de edad: " + esMayorEdad);
        }
    }
}
