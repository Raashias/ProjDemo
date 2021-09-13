using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, add, sub, mul, div;
            Console.Write("Enter a value:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter b value:");
            b = Convert.ToInt32(Console.ReadLine());
            add = a + b;
            Console.WriteLine("Addition result:" + add);
            sub = a - b;
            Console.WriteLine("Subtract result:" + sub);
            mul = a * b;
            Console.WriteLine("Multiplication result:" + mul);
            div = a / b;
            Console.WriteLine("Division result:" + div);
            Console.Read();






        }
    }
}
