namespace PRACT_01_ElenaPJ
{
    internal class Program
    {
        /*Programa que permita elaborar el presupuesto para la celebración de un Evento Corporativo para una empresa y que aplique una reducción del precio
            según el número de comensales que vayan a asistir a dicho evento.
        */
        static void Main(string[] args)
        {
            // CONSTANTES
            const double PRECIO_MIN = 35.50;        // Precio minimo y maximo establecido por persona
            const double PRECIO_MAX = 125;

            const byte MIN_PERSONAS = 20;           // Numero de personas minimo y maximo que pueden asistir al evento
            const byte MAX_PERSONAS = 120;

            const byte NUM_COMENSALES1 = 40;        // Numero de comensales a tener en cuenta para el descuento
            const byte NUM_COMENSALES2 = 80;

            const byte DESCUENTO_MENU1 = 3;         // Descuentos a tener en cuenta si se cumple la condicion
            const byte DESCUENTO_MENU2 = 6;

            // VARIABLES
            string nombreEmpresa = "";
            string nombreEvento = "";
            byte numeroComensales = 0;
            double precio = 0;
            float importe = 0;
            double descuento = 0;
            double importeFinal = 0;

            string entrada = "";        // Variable auxiliar para ayudarnos a leer datos

            bool esCorrecto = true;     // Centinela para validar la entrada del usuario
            byte codigoError = 0;       // Código de error para validar la entrada del usuario
            /*
            ERROR 1: El precio que has introducido es menor de lo establecido
            ERROR 2: El precio que has introducido es mayor de lo establecido
            ERROR 3: El numero de comensales que has introducido es menor de lo establecido
            ERROR 4: El numero de comensales que has introducido es mayor de lo establecido
            */

            // ENTRADA
            // Bienvenida del programa
            Console.WriteLine("Bienvenido al programa. ");

            // Solicitamos al usuario el nombre de la empresa, su nombre y el nombre del evento
            Console.Write("¿Cuál es el nombre de la Empresa? ");
            nombreEmpresa = Console.ReadLine();
            Console.Write("¿Cuál es el nombre del Evento? ");
            nombreEvento = Console.ReadLine();

            // Solicitamos al usuario el precio del menú
            Console.Write("¿Cuál es el precio de tu menú? ");
            entrada = Console.ReadLine();       
            esCorrecto = double.TryParse(entrada, out precio);     

            // Validamos que el precio no sea menor o mayor de lo establecido.
            if (precio < PRECIO_MIN)
            {
                esCorrecto = false;
                codigoError = 1;
            }
            if (precio > PRECIO_MAX)
            {
                esCorrecto = false;
                codigoError = 2;
            }

            // Solicitamos el número de comensales
            Console.Write("¿Cuál es el número de comensales? ");
            entrada = Console.ReadLine();
            esCorrecto = byte.TryParse(entrada, out numeroComensales);

            // Validamos que el numero de comensales no sea menos o mayor de lo establecido
            if (numeroComensales < MIN_PERSONAS)
            {
                esCorrecto = false;
                codigoError = 3;
            }
            if (numeroComensales  > MAX_PERSONAS)
            {
                esCorrecto = false;
                codigoError = 4;
            }


            // PROCESO
            // Calculo del presupuesto
            if (esCorrecto)
            {
                importe = (float)((double)precio * numeroComensales);       // float(double)precio --> para que podamos operar con distintos tipos de variables
                importeFinal = importe - descuento;
            }
            if (numeroComensales < NUM_COMENSALES1)
            {
                descuento = importeFinal - DESCUENTO_MENU1;
            }
            if (numeroComensales > NUM_COMENSALES2)
            {
                descuento = importeFinal - DESCUENTO_MENU2;
            }


            // SALIDA
            // Mostramos la presentación de los resultados
            if (esCorrecto)     //Si todo va bien...
            {
                Console.WriteLine($"PRESUPUESTO DE EVENTO:  {nombreEvento}");
                Console.WriteLine($"Empresa:                {nombreEmpresa}");
                Console.WriteLine("************************************************************************************");
                Console.WriteLine($"\t\t Precio por Persona :  {precio}\t Número de Comensales:   {numeroComensales}");
                Console.WriteLine($"\t\t Importe :             {importe}");
                Console.WriteLine($"\t\t Descuento :           {descuento}");
                Console.WriteLine($"\t\t Importe Final :       {importeFinal}");
                Console.WriteLine("************************************************************************************");
            }
            if (!esCorrecto)    // Si hay algun error...
            {
                switch (codigoError)    
                {
                    case 1:
                        Console.WriteLine("ERROR 1: El precio que has introducido es menor de lo establecido. ");
                        break;
                    case 2:
                        Console.WriteLine("ERROR 2: El precio que has introducido es mayor de lo establecido. ");
                        break;
                    case 3:
                        Console.WriteLine("ERROR 3: El número de comensales que has introducido es menor de lo establecido. ");
                        break;
                    case 4:
                        Console.WriteLine("ERROR 4: El número de comensales que has introducido es mayor de lo establecido. ");
                        break;
                }
            }

        }
    }
}
