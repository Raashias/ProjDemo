using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MobileLib;

namespace MyFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Mobile objmobile = new Mobile();
            objmobile.MobileModels("Android");
            //Networking
            //Networking obj = new Networking();
            //Console.WriteLine("Mobile Network Performance");
            //Console.WriteLine("**************************");
            //Console.WriteLine("Source\t\t Destination\t   Date\t\t\t  call-status\t");
            //obj.ReadFile();

            //Filehandling functions
            //Console.WriteLine(obj.ReadFile());
            //FileStream fs = new FileStream(@"C:\Training\EuroTraining\ProjDemo\t.txt", FileMode.OpenOrCreate, FileAccess.Write);
            //StreamWriter sw = new StreamWriter(fs);
            //sw.WriteLine("Course Details:");
            //sw.WriteLine("***************");
            //Console.WriteLine("Enter the Number of Courses: ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //sw.WriteLine("Number of courses: " + a);
            //for (int i = 0; i < a; i++)
            //{
            //    Console.WriteLine("Enter the the reg No:");
            //    int b = Convert.ToInt32(Console.ReadLine());
            //    sw.WriteLine("Reg No: " + b);
            //    Console.WriteLine("Enter the course:");
            //    string c = Console.ReadLine();
            //    sw.WriteLine("Course: " + c);
            //    Console.WriteLine("Enter course Title:");
            //    string d = Console.ReadLine();
            //    sw.WriteLine("Course Title: " + d);
            //}
            //sw.Close();
            //fs.Close();



            //Arithmetic Operations

            /*int a, b, add, sub, mul, div;
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
            Console.WriteLine("Division result:" + div);*/
            Console.Read();






        }
    }
}
