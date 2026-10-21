namespace R7E05V4_ElenaPJ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CONSTANTES

            // VARIABLES
            int valorInicial = 0;
            int valorFinal = 0;
            int contador = 0;
            int numeroImpares = 0;
            string listaImpares = "";

            string cadena = "";
            bool esCorrecto = true;
            byte codigoError = 0;
            /*
             0 -> No hay error
             1 -> El valor inicial no es un valor numérico o está fuera de rango
             2 -> El valor final no es un valor numérico o está fuera de rango 
             */

            // ENTRADA
            // 1.- Introducción del Valor Inicial
            do
            {
                // Se establece el criterio de que el usuario no se va a equivocar
                esCorrecto = true;
                codigoError = 0;

                Console.Write("Introduzca el valor inicial: ");
                cadena = Console.ReadLine();
                esCorrecto = Int32.TryParse(cadena, out valorInicial);

                if (!esCorrecto)
                {
                    codigoError = 1;
                }
            } while (!esCorrecto);

            // Retroalimentación
            switch (codigoError)
            {
                case 1:
                    Console.WriteLine("ERROR: Ha introducido para el valor inicial un dato que no es un número o es excesivamente grande");
                    break;
            }

            // 2.- Introducción del Valor Inicial
            do
            {
                // Se establece el criterio de que el usuario no se va a equivocar
                esCorrecto = true;
                codigoError = 0;

                Console.Write("Introduzca el valor final: ");
                cadena = Console.ReadLine();
                esCorrecto = Int32.TryParse(cadena, out valorFinal);

                if (!esCorrecto)
                {
                    codigoError = 2;
                }
            } while (!esCorrecto);

            // Retroalimentación
            switch (codigoError)
            {
                case 1:
                    Console.WriteLine("ERROR: Ha introducido para el valor final un dato que no es un número o es excesivamente grande");
                    break;
            }

            // PROCESO
            contador = valorInicial;

            while(contador <= valorFinal)
            {
                if (contador % 2 != 0)
                {
                    listaImpares += $"{contador}\t";
                    numeroImpares++;
                }

                contador++;
            }

            // SALIDA
            

        }
    }
}
