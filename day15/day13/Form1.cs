using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace day13
{
    public partial class Form1 : Form
    {


        string textname = "C:/Users/37126/Desktop/Text.txt";
        List<Auto> textstringa = new List<Auto>();
        int count = 0;


        public Form1()
        {
            InitializeComponent();
            Class1.ReadAutoLst(textstringa, textname);
            for (int i = 0; i < textstringa.Count; i++)
            {
                listElements.Items.Add(

                    textstringa[i].autolable + ", "
                    + textstringa[i].automodel + ", "
                    + textstringa[i].autocolor + ", "
                    + textstringa[i].autostatus);


            }
            
        }

        

        private void button1_Click(object sender, EventArgs e)
        {


            listElements.Items.Add("Volkswagen, Golf, Black, available");
            textstringa.Add(new Auto("Volkswagen", "Golf", "Black", "available"));
            Class1.WriteAutoLst(textstringa, textname);

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
                textstringa.RemoveAt(textstringa.Count - 1);
                listElements.Items.Clear();

                for (int i = 0; i < textstringa.Count; i++)
                {
                    listElements.Items.Add(

                        textstringa[i].autolable + ", "
                        + textstringa[i].automodel + ", "
                        + textstringa[i].autocolor + ", "
                        + textstringa[i].autostatus);
                    

                }
            }
            else
            {

            }

        }

       

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length != 0 ||
                textBox3.Text.Length != 0 ||
                textBox1.Text.Length != 0 ||
                textBox4.Text.Length != 0)
            {
                listElements.Items.Add(textBox2.Text + ", "
                    + textBox3.Text + ", "
                    + textBox1.Text + ", "
                    + textBox4.Text);

                textstringa.Add(new Auto(textBox2.Text,
                    textBox3.Text,
                    textBox1.Text,
                    textBox4.Text));

                Class1.WriteAutoLst(textstringa, textname);
                
            }

            else
            {

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //button for statuschange : sold or available

            if (count % 2 == 0)
            {
                textBox4.Text = "available";
                count++;

            }
            else
            {
                textBox4.Text = "sold";
                count++;
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //available car list
        }
        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {
            //status sold or available
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //model
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //color
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //Lable

        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //sold list
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            //show available button
            List<Auto> available = new List<Auto>();
            for (int i = 0; i < textstringa.Count; i++)
            {
                if(textstringa[i].autostatus== "available")
                {
                    available.Add(textstringa[i]);
                }
                else
                {

                }

            }
            String jsonString = JsonConvert.SerializeObject(available);
            listBox1.Items.Add(jsonString);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            List<Auto> sold = new List<Auto>();
            for (int i = 0; i < textstringa.Count; i++)
            {
                if (textstringa[i].autostatus == "sold")
                {
                    sold.Add( textstringa[i]);

                }
                else
                {

                }

            }
            String jsonString = JsonConvert.SerializeObject(sold);
            listBox2.Items.Add(jsonString);
        }
    }
}
