using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ANIMALS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();
          
            List<ANIMALS> a = new List<ANIMALS>();
            a = con.adlist();

            foreach (ANIMALS animal in a)
            {
                
                if (animal.a_status == "SOLD")
                {
                    listBox2.Items.Add(animal.a_name + ", " + animal.a_status);

                }
                else 
                {
                    listBox1.Items.Add(animal.a_name + ", " + animal.a_status);

                }
                
            }



        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
