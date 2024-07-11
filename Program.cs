using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 0;
            int number2 = 1;
            int number;
            Console.WriteLine("Enter the range of Fibonacci numbers you want ");
            int range = Convert.ToInt32(Console.ReadLine());
            Console.Write("The Fibonacci sequence will be : ");
            Console.Write(number1 + " " + number2 + " ");
            for (int i = 2; i < range; i++)
            {
                number = number1 + number2;
                number1 = number2;
                number2 = number;
                Console.Write(number + " ");
            }
        }
    }
}