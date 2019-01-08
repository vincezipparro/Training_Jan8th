using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Jan8th
{
    class Program
    {

        public static void Main(string[] args)
        {
            Addition a = new Addition();
            Subtract s = new Subtract();
            Multiply m = new Multiply();
            Divide d = new Divide();
           
       
            var add = a.add(8, 9);
            var subtract = s.subtract(10, 9);
            var multiply = m.multiply(12, 12);
            var divide = d.divide(21, 3);

            Console.WriteLine(add);
            Console.WriteLine(subtract);
            Console.WriteLine(multiply);
            Console.WriteLine(divide);
            Console.ReadKey();
            

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
