using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileCreationNew
{
    class FilehandlingNew
    {

        public void ReadParticularLine(int n)

        {
            FileStream ww = new FileStream(@"C:\Training\EuroTraining\C# Applications\FileCreationNew\FileCreationNew\Particular1.txt", FileMode.Create, FileAccess.Write);
            StreamWriter w = new StreamWriter(ww);
            Console.WriteLine("Enter the input strings:");
            for (int j = 0; j < n; j++ )
            {
                Console.WriteLine("Input line:");
                String b = Console.ReadLine();
                w.WriteLine(b);
            }
            w.Close();
            ww.Close();


            FileStream abc = new FileStream(@"C:\Training\EuroTraining\C# Applications\FileCreationNew\FileCreationNew\Particular1.txt", FileMode.Open, FileAccess.Read);
            StreamReader sww = new StreamReader(abc);
            Console.WriteLine("Input which line you want to display:");
            int z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The content of the line of the file Particular1.txt is");
            for (int i = 1 ; i <= n ; i++)
            {
                String Line = sww.ReadLine();
                if (i == z)
                {
                   Console.WriteLine(Line);
                }
            }
            sww.Close();
            abc.Close();   
        }

        public void CountLines()
        {
            FileStream p = new FileStream(@"C:\Training\EuroTraining\C# Applications\FileCreationNew\FileCreationNew\CountLine.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter ws = new StreamWriter(p);
            Console.WriteLine("Here is the content of the file.txt :");
            ws.WriteLine("Sita");
            ws.WriteLine("Gita");
            ws.WriteLine("Sheela");
            ws.WriteLine("Mala");
            ws.WriteLine("Kavya");
            ws.WriteLine("Navya");
            ws.Close();
            p.Close();

            FileStream bc = new FileStream(@"C:\Training\EuroTraining\C# Applications\FileCreationNew\FileCreationNew\CountLine.txt", FileMode.Open, FileAccess.Read);
            StreamReader dd = new StreamReader(bc);
            Console.WriteLine("The number of lines in the file.txt is :");
            int count = 0;
            while (dd.Peek() > 0)
            {
                Console.WriteLine(dd.ReadLine());
                count++;
            }
            dd.Close();
            bc.Close();

            Console.WriteLine("Count is: ");
            Console.WriteLine(count);

        }
    }
}
