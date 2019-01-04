using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamDots_inclass1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, answer = 0;

            Console.Write("Enter the first number: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            num2 = int.Parse(Console.ReadLine());

            answer = num1 + num2;

            Console.WriteLine("The Sum: "+answer);

            Console.ReadLine();
        }
    }
}
