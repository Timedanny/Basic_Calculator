using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter another number ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(num1 + num2);
            
        }
    }
}
