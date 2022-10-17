using System;

namespace L11_MXPM_1049321
{
    class Program
    {
        static void Main(string[] args)
        {
            int moneda;
            double cantidad;
            Console.WriteLine("Ingrese una opción divisas");
            Console.WriteLine("Opción 1 para ingresar libras");
            Console.WriteLine("Opción 2 para ingresar yenes");
            Console.WriteLine("Opción 3 para ingresar dolares");

            moneda = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("¿Qué cantidad quiere convertir?");
            Console.WriteLine("-------");
            cantidad = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("-------");

            conversionMoneda(moneda, cantidad);
        }
        static void conversionMoneda(int tipo, double cantidad1)
        {
            //CONVERSION DE LIBRAS//
            if (tipo == 1)
            {
                cantidad1 = cantidad1 * 1.22;
                Console.WriteLine("Su cantidad de libras a euros es  " + cantidad1);
            }
            //CONVERSION DE YENES//
            else
            {
                cantidad1 = cantidad1 * 0.009;
                Console.WriteLine("Su cantidad en yenes es de " + cantidad1);
                //CONVERSION DE DOLARES
                cantidad1 = cantidad1 * 0.75;
                Console.WriteLine("Su cantidad en dolares es de " + cantidad1);
            }
        }
    }
}

