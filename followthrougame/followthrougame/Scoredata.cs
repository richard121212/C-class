using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace followthrougame
{
    class Scoredata
    {
        public string a;
        public int inthigtscore;


        public Scoredata()
        {
            //a = "C:/Users/37126/Desktop/flappybirb/New Text Document.txt";
            a = "New Text Document.txt";
            inthigtscore = Read();

        }

        public int Read()
        {
            int i = 0;

            String line;

            try
            {
                StreamReader sr = new StreamReader(a);

                line = sr.ReadLine();

                if (line != null)
                {
                    i = Convert.ToInt32(line.TrimStart(
                    'H', 'i', 'g', 'h', 'e', 's', 't', ' ',
                    'S', 'c', 'o', 'r', 'e', ':'));
                }


                sr.Close();
                return i;

            }
            catch
            {

                return i;
            }
        }








    }
}
