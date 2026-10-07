namespace R5E05_ElenaPJ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear un programa que dada la longitud de los 3 lados, determine si es un triangulo equilátero, isósceles o escaleno.
            // CONSTANTES

            // VARIABLES
            int lado1 = 0, lado2 = 0, lado3 = 0;
            bool esCorrecto = false;        // Variable para controlar si la entrada es correcta
            string cadenaAuxiliar = "";
            byte codigoError = 0;       // 0 = Sin errores, 1 = Lados menores o iguales a 0, 2 = Lados decimales

            // ENTRADA
            // Solicitar al usuario que introduzca el primer lado
            Console.Write("Intruduce el valor del primer lado: ");
            cadenaAuxiliar = Console.ReadLine();
            esCorrecto = Int32.TryParse(cadenaAuxiliar, out lado1);

            // Solicitar al usuario que introduzca el segundo lado
            Console.Write("Intruduce el valor del segundo lado: ");
            cadenaAuxiliar = Console.ReadLine();
            esCorrecto = Int32.TryParse(cadenaAuxiliar, out lado2);

            // Solicitar al usuario que introduzca el tercer lado
            Console.Write("Intruduce el valor del tercer lado: ");
            cadenaAuxiliar = Console.ReadLine();
            esCorrecto = Int32.TryParse(cadenaAuxiliar, out lado3);

            // Validar que los lados sean mayores que 0
            if (lado1 <= 0 || lado2 <= 0 || lado3 <= 0)
            {
                codigoError = 1;
            }

            // Validar que los lados no sean decimales
            if (lado1 % 1 != 0 || lado2 % 1 != 0 || lado3 % 1 != 0)
            {
                codigoError = 2;
            }

            // PROCESO

            // SALIDA
            if (codigoError == 0)
            {
                if (lado1 == lado2 && lado2 == lado3)
                {
                    Console.WriteLine("El triangulo es equilátero");
                }
                else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
                {
                    Console.WriteLine("El triangulo es isósceles");
                }
                else if (lado1 != lado2 && lado1 != lado3 && lado2 != lado3)
                {
                    Console.WriteLine("El triangulo es escaleno");
                }
            }

            switch (codigoError)
            {
                case 1:
                    Console.WriteLine("Error: Los lados deben ser mayores que 0");
                    break;
                case 2:
                    Console.WriteLine("Error: Los lados no pueden ser decimales");
                    break;
            }
        }
    }
}
