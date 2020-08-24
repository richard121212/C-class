using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace day13
{
    public partial class Form1 : Form
    {

        
        string textname = "Textadd.txt";
        List<Student> textstringa = new List<Student>();

       
        public Form1()
        {
           
            InitializeComponent();
            Class1.ReadStudentLst(textstringa, textname);
            for (int i = 0; i < textstringa.Count; i++)
            {
                listElements.Items.Add(
                 
                    textstringa[i].name + ","
                    + textstringa[i].lastName + ","
                    + textstringa[i].course );

            }
        }
       



        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            



        }

        private void button1_Click(object sender, EventArgs e)
        {

            

            listElements.Items.Add("Juris,Auzins,1");
            textstringa.Add(new Student("Juris", "Auzins", 1)) ;
            Class1.WriteStudentLst(textstringa, textname);
            




        }

        private void button2_Click(object sender, EventArgs e)
        {
            listElements.Items.Clear();
            Class1.Delite(textname);
            textstringa.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textstringa.Count > 0) 
            { 
            textstringa.RemoveAt(textstringa.Count-1);
            listElements.Items.Clear();

                for (int i = 0; i < textstringa.Count; i++)
                {
                    listElements.Items.Add(

                        textstringa[i].name + ","
                        + textstringa[i].lastName + ","
                        + textstringa[i].course);

                }
            }
            else
            {
               
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //Name input box

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length !=0|| textBox3.Text.Length != 0)
            {
                listElements.Items.Add(textBox2.Text + "," + textBox3.Text + "," + 
                    Convert.ToString(numericUpDown1.Value));
                textstringa.Add(new Student(textBox2.Text, textBox3.Text,
                    Convert.ToInt32(numericUpDown1.Value)));
                Class1.WriteStudentLst(textstringa, textname);


            }
            if(textBox2.Text.Length == 0 && textBox3.Text.Length == 0)
            {

            }
            else
            {

            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //lastname input box
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            //course input box3

        }
    }
}
