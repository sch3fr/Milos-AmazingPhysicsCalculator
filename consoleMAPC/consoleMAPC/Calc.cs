using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleMAPC
{
    internal class Calc
    {
        public static void Multiply(string zadani1, string zadani2, string vyslednaVelicina)
        {
            Console.WriteLine("Zadejte " + zadani1);
            double firstInput = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Zadejte " + zadani2);
            double secondInput = Convert.ToDouble(Console.ReadLine());
            double result = firstInput * secondInput;
            Console.WriteLine("\nVýsledek je {0} {1}", result, vyslednaVelicina);
            Console.WriteLine("Stiskem jakéhokoliv tlačítka se vrátíte hlavního do menu.");
            Console.ReadKey();
        }
        public static void Devide(string zadani1, string zadani2, string vyslednaVelicina)
        {
            Console.WriteLine("Zadejte " + zadani1);
            double firstInput = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Zadejte " + zadani2);
            double secondInput = Convert.ToDouble(Console.ReadLine());
            double result = firstInput / secondInput;
            Console.WriteLine("\nVýsledek je {0} {1}", result, vyslednaVelicina);
            Console.WriteLine("Stiskem jakéhokoliv tlačítka se vrátíte hlavního do menu.");
            Console.ReadKey();
        }
    }
}
