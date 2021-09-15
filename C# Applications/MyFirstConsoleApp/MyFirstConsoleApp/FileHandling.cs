using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyFirstConsoleApp
{
    class FileHandling
    {

        public string WriteFile()
        {
            FileStream fs = new FileStream(@"C:\Training\EuroTraining\ProjDemo\temp.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("Course Details:");
            sw.WriteLine("***************");
            Console.WriteLine("Enter the Number of Courses: ");
            int a = Convert.ToInt32(Console.ReadLine());
            sw.WriteLine("Number of courses: " + a);
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("Enter the the reg No:");
                int b = Convert.ToInt32(Console.ReadLine());
                sw.WriteLine("Reg No: " + b);
                Console.WriteLine("Enter the course:");
                string c = Console.ReadLine();
                sw.WriteLine("Course: " + c);
                Console.WriteLine("Enter course Title:");
                string d = Console.ReadLine();
                sw.WriteLine("Course Title: " + d);
            }
            sw.Close();
            fs.Close();
            return "Done";




        }


        }
}
