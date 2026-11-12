using System;
using System.Collections.Generic;
using System.Text;

namespace R10E01V4_ElenaPJ
{
    public static class SalidaResultados
    {
        #region MÉTODOS DE SALIDA DE RESULTADOS

        static public void MostrarMensajeError(string mensaje)
        {
            Console.WriteLine(mensaje);

            Console.Write("Pulse Enter / Intro para continuar......");
            Console.ReadLine();      // Pausa para que el usuario lea el mensaje de error
            Console.Clear();        // Limpiar la pantalla
        }

        static public void MostrarDatosEntrada(float ancho, float largo, float profundidad)
        {
            Console.WriteLine("\n ------- RESULTADOS ------- ");
            Console.WriteLine($"Ancho: {ancho} metros.");
            Console.WriteLine($"Largo: {largo} metros.");
            Console.WriteLine($"Profundidad: {profundidad} metros.");
        }

        static public void MostrarDatosCalculados(float superficie, float volumen)
        {
            Console.WriteLine($"Superficie: {superficie} metros cuadrados.");
            Console.WriteLine($"Volumen: {volumen} metros cúbicos.");
        }

        #endregion
    }
}
