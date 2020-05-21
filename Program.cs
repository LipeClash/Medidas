using System;

namespace Medidas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Equivalência entre medidas");

            Double X = 250;
            Double Y = 100;
            Double Resultadodemedidas1 = X * Y;
            Console.WriteLine($"{X} * {Y} = {Resultadodemedidas1}");

            /*25000 cm e equivalente a = 250 metros  */

            Console.WriteLine("");

            Double A = 0.25;
            Double B = 1000;
            Double Resultadodemedidas2 = A * B;
            Console.WriteLine($"{A} * {B} = {Resultadodemedidas2} ");

            /* 0,25 equivale a = 250 metros */

             Console.WriteLine("--- Equivalência ---");
             Console.WriteLine("25000 cm");
             Console.WriteLine("250 m");
             Console.WriteLine("0,25 km");


            
        }
    }
}
