using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyFirstConsoleApp
{
    class Networking
    {
        public String ReadFile()
        {
            FileStream a = new FileStream(@"C:\Training\EuroTraining\C# Applications\MyFirstConsoleApp\Network.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(a);
            while (sr.Peek() > 0)
            {
                string line = sr.ReadLine();
                if (line.Contains(":"))
                {
                    string[] ids = line.Split(':');

                    for (int j = ids.Length - 1; j > 0; j--)
                    {
                        Console.Write(ids[j]);
                        Console.Write("\t");


                    }


                }
                else
                    Console.WriteLine();
                
                   

            }
                a.Close();

                return "Read success";
            }
        }
}

