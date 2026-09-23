namespace R3E02_ElenaPJ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CONSTANTES

            // VARIABLES
            int numero1;
            int numero2;
            int suma;
            string cadenaAuxiliar;

            // ENTRADA

            // PROCESO

            // SALIDA
            //Solicitamos el primer número
            Console.Write("Introduce un número: ");
            //Convertimos la variable numero1 para que pueda almacenar el valor introducido por el usuario
            cadenaAuxiliar = Console.ReadLine();
            numero1 = Convert.ToInt32(cadenaAuxiliar);

            //Solicitamos el segundo número
            Console.Write("Introduce otro número: ");
            //Convertimos la variable numero2 para que pueda almacenar el valor introducido por el usuario
            cadenaAuxiliar = Console.ReadLine();
            numero2 = Convert.ToInt32(cadenaAuxiliar);

            //Realizamos la suma de los dos números
            suma = numero1 + numero2;

            //Mostramos el resultado de la suma
            Console.Write("El resultado de la suma es: " + suma);
        }
    }
}
