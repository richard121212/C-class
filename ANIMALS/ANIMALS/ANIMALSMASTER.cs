using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANIMALS
{
    class CLIENTS
    {
        public String c_name;
        public String c_lastname;


        public CLIENTS(String c_name, String c_lastname)
        {
            this.c_name = c_name;
            this.c_lastname = c_lastname;
        }

        public CLIENTS()
        {
            this.c_name = "";
            this.c_lastname = "";
        }
    }
}
