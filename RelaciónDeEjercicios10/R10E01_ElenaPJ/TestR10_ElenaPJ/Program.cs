using R10E1V5_ElenaPJ;
using System.Diagnostics;

namespace R10E1V5_ElenaPJ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CONSTANTES

            // VARIABLES
            byte opcion = 0;

            
            do
            {
                // ENTRADA
                // Presentar menú para seleccionar el componente a probar
                Console.Clear();
                Console.WriteLine("Prueba de componentes del gestor de piscinas");
                Console.WriteLine("0 - salir ");
                Console.WriteLine("1 - ancho ");
                Console.WriteLine("2 - largo ");
                Console.WriteLine("3 - profundidad ");
                Console.WriteLine("Seleccione componente: ");

                opcion = Convert.ToByte(Console.ReadLine());

                // PROCESO
                // Ejecutar la prueba del componente seleccionado
                switch (opcion)
                {
                    case 1:
                        EntradaDatos.LeerAncho();
                        Debug.WriteLine("Pruebas sobre el ancho finalizadas.");
                        break;
                    case 2:
                        EntradaDatos.LeerLargo();
                        Debug.WriteLine("Pruebas sobre el largo finalizadas.");
                        break;
                    case 3:
                        EntradaDatos.LeerProfundidad();
                        Debug.WriteLine("Pruebas sobre la profundidad finalizadas.");
                        break;
                }
            } while (opcion != 0);


            // SALIDA
            Debug.WriteLine("Pruebas finalizadas.");

            
        }
    }
}
