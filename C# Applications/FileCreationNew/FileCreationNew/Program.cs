using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileCreationNew
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Input number of lines to write in the file: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            FilehandlingNew obj = new FilehandlingNew();
            //obj.ReadParticularLine(n);
            obj.CountLines();

            

                //FileCreate and Read
                //FileStream d = new FileStream(@"C:\Training\EuroTraining\C# Applications\FileCreationNew\FileCreationNew\Mytext.txt", FileMode.OpenOrCreate, FileAccess.Write);
                //StreamWriter sw = new StreamWriter(d);
                //sw.WriteLine("Hello and Welcome");
                //sw.WriteLine("It is the first content");
                //sw.WriteLine("of the text file mytext.txt");
                //sw.Close();
                //d.Close();

            

                //FileStream e = new FileStream(@"C:\Training\EuroTraining\C# Applications\FileCreationNew\FileCreationNew\Mytext.txt", FileMode.Open, FileAccess.Read);
                //StreamReader swe = new StreamReader(e);
                //Console.WriteLine("Here is the content of the file mytest.txt :");
                //while (swe.Peek() > 0)
                //{
                //    string line = swe.ReadLine();
                //    Console.WriteLine(line);

                //}
                //swe.Close();
                //e.Close();


                //Filecreate and Write
                //FileStream c = new FileStream(@"C:\Training\EuroTraining\C# Applications\FileCreationNew\FileCreationNew\Myt.txt", FileMode.Create, FileAccess.Write);
                //StreamWriter sw = new StreamWriter(c);
                //sw.WriteLine("Welcome to Eurofins");
                //sw.WriteLine("These are your modules");
                //sw.WriteLine("C#, C++, Java");
                //sw.Close();
                //c.Close();
                //Console.WriteLine("A file created with content name Myt.txt");



                //FileOpen/Create
                //FileStream b = new FileStream(@"C:\Training\EuroTraining\C# Applications\FileCreationNew\FileCreationNew\Mytest.txt", FileMode.OpenOrCreate);
                //Console.WriteLine("A file created with name mytest.txt");

                //File Deletion
                //FileStream a = new FileStream(@"C:\Training\EuroTraining\C# Applications\FileCreationNew\FileCreationNew\Myt.txt",FileMode.Create);
                //File.Delete(@"C:\Training\EuroTraining\C# Applications\FileCreationNew\FileCreationNew\Myt.txt");
                //Console.WriteLine("The file Myt got deleted successfully");
                //FileCreation
                //FileStream Creation = File.Create(@"C:\Training\EuroTraining\C# Applications\FileCreationNew\FileCreationNew\Mytest.txt");

                Console.Read();
        
        }
    }
}
