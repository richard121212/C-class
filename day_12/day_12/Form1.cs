using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day_12
{
    public partial class Form1 : Form
    {
        int count=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Poga nospiesta";
            count++;
            label2.Text = Convert.ToString(count) ;



        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
