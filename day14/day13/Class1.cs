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
       
        public static void  ReadStudentLst(List<Student> b, String a)
        {
            String line;
            List<Student> students = new List<Student>();
            try
            {
                StreamReader sr = new StreamReader(a);

                line = sr.ReadLine();

                while (line != null)
                {
                    String[] fromFile = line.Split(',');
                    students.Add(new Student(fromFile[0], fromFile[1], Convert.ToInt32(fromFile[2])));

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
        public static void WriteStudentLst(List<Student> b, String a)
        {
            try
            {
                StreamWriter sw = new StreamWriter(a);

                foreach (Student st in b)
                {
                    sw.WriteLine(st.name + "," + st.lastName + "," + st.course);
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
