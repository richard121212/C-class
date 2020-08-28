using System;
using System.Collections.Generic;
using System.IO;

namespace day13
{
    class Class1
    {

        public static void Delite(string a)
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

        public static void ReadAutoLst(List<Auto> b, String a)
        {
            String line;
            List<Auto> auto = new List<Auto>();
            try
            {
                StreamReader sr = new StreamReader(a);

                line = sr.ReadLine();

                while (line != null)
                {
                    String[] fromFile = line.Split(',');
                    auto.Add(new Auto(fromFile[0],
                        fromFile[1],
                        fromFile[2],
                        fromFile[3]));

                    line = sr.ReadLine();
                }

                sr.Close();
            }
            catch
            {
                Console.WriteLine("Neizdevas atvert failu!");
                Environment.Exit(0);
            }


        }
        public static void WriteAutoLst(List<Auto> b, String a)
        {
            try
            {
                StreamWriter sw = new StreamWriter(a);

                foreach (Auto st in b)
                {
                    sw.WriteLine(
                        st.autolable + ", "
                        + st.automodel + ", "
                        + st.autocolor + ", "
                        + st.autostatus);
                }


                sw.Close();
            }
            catch
            {
                Console.WriteLine("Neizdevas ierakstit faila!");
            }
        }
    }

}
