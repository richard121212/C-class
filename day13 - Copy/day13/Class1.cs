using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace day13
{
    class Class1
    {
        public static void Write(List<string> lst, string a)
        {
            try
            {
                StreamWriter sw = new StreamWriter(a);
                for (int i = 0; i < lst.Count; i++)
                {
                    sw.WriteLine(lst[i]);
                }

                sw.Close();
            }
            catch
            {
                Console.WriteLine("Neizdevas ierakstit faila!");
            }
        }
        public static void Read(List<string> b, string a)
        {
            String line;
            try
            {
                StreamReader sr = new StreamReader(a);
                line = sr.ReadLine();
                while (line != null)
                {
                    line = sr.ReadLine();
                    b.Add(line);
                }
                sr.Close();

                
            }
            catch
            {
                Console.WriteLine("Neizdevas atvert failu!");
                
            }


        }
        public static void Delite( string a)
        {
            try
            {
                StreamWriter sw = new StreamWriter(a);
                sw.Flush();
                sw.Close();
            }
            catch
            {
                Console.WriteLine("Neizdevas izdzest failu!");
            }
        }
        public static void delitelastelement(List<string> b, string a)
        {
            String line;
            try
            {
                StreamReader sr = new StreamReader(a);
                line = sr.ReadLine();
                while (line != null)
                {
                    line = sr.ReadLine();
                    b.Add(line);
                }
                sr.Close();


            }
            catch
            {
                Console.WriteLine("Neizdevas atvert failu!");

            }
        }
    }

}
