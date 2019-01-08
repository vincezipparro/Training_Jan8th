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

            do
            {
                Console.WriteLine("Enter two numbers to add, subtract, multiply, and divide:");
                string nums = Console.ReadLine();
                string[] input = nums.Split(' ');
                if (input.Count() <= 1)
                {
                    Console.WriteLine("There is no space between your numbers\n");
                }
                else
                {
                    var add = a.add(Convert.ToInt32(input[0]), Convert.ToInt32(input[1]));
                    var subtract = s.subtract(Convert.ToInt32(input[0]), Convert.ToInt32(input[1]));
                    var multiply = m.multiply(Convert.ToInt32(input[0]), Convert.ToInt32(input[1]));
                    var divide = d.divide(Convert.ToInt32(input[0]), Convert.ToInt32(input[1]));
                    Console.WriteLine("Addition Result: " + add);
                    Console.WriteLine("Subtraction Result: " + subtract);
                    Console.WriteLine("Multiplication Result: " + multiply);
                    Console.WriteLine("Division Result: " + divide);

                    Console.ReadKey();
                }

            } while (true);

        }
    }
}
