namespace R3E04_ElenaPJ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CONSTANTES

            // VARIABLES
            int numero1, numero2, cociente, resto;
            string cadenaAuxiliar;

            // ENTRADA
            //Pedimos al usuario que introduzca dos números enteros
            Console.Write("Introduce el primer número: ");
            cadenaAuxiliar = Console.ReadLine();
            numero1 = Convert.ToInt32(cadenaAuxiliar);

            Console.Write("Introduce el segundo número: ");
            cadenaAuxiliar = Console.ReadLine();
            numero2 = Convert.ToInt32(cadenaAuxiliar);

            // PROCESO
            cociente = numero1 / numero2;   //Calculamos el cociente de una división
            resto = numero1 % numero2;      //Calculamos el resto de una división

            // SALIDA
            Console.WriteLine("La división del " + numero1 + " entre " + numero2 + " proporciona ");
            Console.WriteLine("Cociente: " + cociente);
            Console.WriteLine("Resto: " + resto);
        }
    }
}
