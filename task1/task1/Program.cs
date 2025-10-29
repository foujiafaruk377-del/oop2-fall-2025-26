using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        
            { Console.WriteLine("Enter first number : ");
            double num1 = Convert.ToDouble(Console.ReadLine())

                Console.WriteLine("Enter second number : ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter third number: ");
            double num3 = Convert.ToDouble(Console.ReadLine());

            double average = (num1 + num2 + num3) / 3.0;
            Console.wrieteline($ "Average score : {average}");
         

        }
    }
}
