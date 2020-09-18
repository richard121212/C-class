using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace followthrougame
{
    public partial class Form1 : Form
    {

        Player bird;
        TheWall house;
        clouds clouds1;
        clouds clouds2;
        Beckmoveitems font1;
        Beckmoveitems font2;
        Scoredata score;
        float gravity;
        int newhightscore = 0;
        private float _tick;
        private float _tick1;
        private float _tick2;
        bool cloudpicture1;
        int showhouse1;
        int showbird1;
        bool gamestarton = false;

        public Form1()
        {
            InitializeComponent();
            gamestartiterface();
            timer1.Interval = 10;
            timer1.Tick += new EventHandler(update);
            Init();
            Invalidate();

        }


        public void gamestartiterface()
        {

            var music1 = new System.Media.SoundPlayer();
            music1.SoundLocation = "C:\\Users\\37126\\Desktop\\flappybirb\\Feelings.wav";
            music1.PlayLooping();

            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            circularButton1.Visible = false;


        }




        public void Init()
        {
            clouds1 = new clouds(600, 400);
            clouds2 = new clouds(700, 20);
            font1 = new Beckmoveitems(0, 0);
            font2 = new Beckmoveitems(font1.sizeX, 0);
            bird = new Player(200, 200);
            showbird1 = 1;
            showhouse1 = 1;

            house = new TheWall(400, 1500);

            score = new Scoredata();
            gravity = 0;
            label2.Text = "Highest Score: " + Convert.ToString(score.inthigtscore);
            timer1.Start();



        }

        private void update(object sender, EventArgs e)
        {
            Movefont();
            MoveClouds();

            if (gamestarton)
            {
                if (Collide(bird, house) || Collide(bird, house))
                {
                    bird.isAlive = false;
                    bird.gravityValue = 0;
                    int meterint = Convert.ToInt32(Math.Truncate(bird.meter));

                    if (newhightscore < meterint)
                    {
                        newhightscore = meterint;
                        label3.Text = "Your Score: " + Convert.ToString(newhightscore);

                    }
                    if (newhightscore > score.inthigtscore)
                    {
                        Write(newhightscore);

                    }

                    timer1.Stop();
                    Init();
                }

                if (bird.gravityValue != 0.1f)
                {
                    bird.gravityValue += 0.0045f;

                }


                gravity += bird.gravityValue;
                bird.y += gravity;



                if (bird.isAlive)
                {
                    bird.meter += 0.05;

                    label1.Text = "m = " + Convert.ToString(Math.Truncate(bird.meter));
                    MoveWalls();
                }

            }

            Invalidate();

        }

        private void MoveWalls()
        {
            house.x -= 2;

            CreateNewWall();
        }

        private void MoveClouds()
        {
            Random r = new Random();
            int c1;
            int c2;
            c1 = r.Next(1, 3);
            c2 = r.Next(1, 4);
            clouds2.x -= c1;
            clouds1.x -= c2;
            CreateNewClouds();

        }

        private void CreateNewClouds()
        {
            Random r = new Random();
            int y1;
            y1 = r.Next(12, 500);

            if (clouds1.x < -500)
            {

                clouds1 = new clouds(600, y1);

            }
            if (clouds2.x < -500)
            {
                clouds2 = new clouds(600, y1);

            }
        }

        private void Movefont()
        {
            font1.x -= 1;
            font2.x -= 1;
            CreateNewfont();

        }

        private void CreateNewfont()
        {
            if (font1.x == -471)
            {
                font2 = new Beckmoveitems(600, 0);
            }
            if (font2.x == -471)
            {
                font1 = new Beckmoveitems(600, 0);
            }


        }


        private void CreateNewWall()
        {
            if (house.x < bird.x - 500)
            {
                Random r = new Random();
                int y1;
                int y2;
                y1 = r.Next(160, 500);
                y2 = r.Next(600, 800);
                house = new TheWall(y2, y1);

            }
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {

            Graphics graphics = e.Graphics;
            graphics.DrawImage(font1.fontImg, font1.x, font1.y, font1.sizeX, font1.sizeY);
            graphics.DrawImage(font2.fontImg, font2.x, font2.y, font2.sizeX, font2.sizeY);

            if (cloudpicture1)
            {
                graphics.DrawImage(clouds1.cloudImg, clouds1.x, clouds1.y, clouds1.sizeX, clouds1.sizeY);
                graphics.DrawImage(clouds2.cloudImg, clouds2.x, clouds2.y, clouds2.sizeX, clouds2.sizeY);

            }
            if (cloudpicture1 == false)
            {
                graphics.DrawImage(clouds1.cloudImg2, clouds1.x, clouds1.y, clouds1.sizeX, clouds1.sizeY);
                graphics.DrawImage(clouds2.cloudImg2, clouds2.x, clouds2.y, clouds2.sizeX, clouds2.sizeY);

            }


            if (gamestarton)
            {
                if (showbird1 == 1 || showbird1 == 5)
                {
                    graphics.DrawImage(bird.birdImg1, bird.x, bird.y, bird.size, bird.size);

                }
                if (showbird1 == 2 || showbird1 == 4)
                {
                    graphics.DrawImage(bird.birdImg2, bird.x, bird.y, bird.size, bird.size);

                }
                if (showbird1 == 3 )
                {
                    graphics.DrawImage(bird.birdImg3, bird.x, bird.y, bird.size, bird.size);

                }
                if (showbird1 == 6 || showbird1 == 8)
                {
                    graphics.DrawImage(bird.birdImg4, bird.x, bird.y, bird.size, bird.size);

                }
                if (showbird1 == 7)
                {
                    graphics.DrawImage(bird.birdImg5, bird.x, bird.y, bird.size, bird.size);

                }


                if (showhouse1 == 1)
                {
                    graphics.DrawImage(house.houseImg9, house.x, house.y, house.sizeX, house.sizeY);

                }
                if (showhouse1 == 2)
                {
                    graphics.DrawImage(house.houseImg8, house.x, house.y, house.sizeX, house.sizeY);

                }
                if (showhouse1 == 3)
                {
                    graphics.DrawImage(house.houseImg7, house.x, house.y, house.sizeX, house.sizeY);

                }
                if (showhouse1 == 4)
                {
                    graphics.DrawImage(house.houseImg6, house.x, house.y, house.sizeX, house.sizeY);

                }
                if (showhouse1 == 5)
                {
                    graphics.DrawImage(house.houseImg5, house.x, house.y, house.sizeX, house.sizeY);

                }
                if (showhouse1 == 6)
                {
                    graphics.DrawImage(house.houseImg4, house.x, house.y, house.sizeX, house.sizeY);

                }
                if (showhouse1 == 7)
                {
                    graphics.DrawImage(house.houseImg3, house.x, house.y, house.sizeX, house.sizeY);

                }
                if (showhouse1 == 8)
                {
                    graphics.DrawImage(house.houseImg2, house.x, house.y, house.sizeX, house.sizeY);

                }
                if (showhouse1 == 9)
                {
                    graphics.DrawImage(house.houseImg1, house.x, house.y, house.sizeX, house.sizeY);

                }

            }

        }



        private bool Collide(Player bird, TheWall house)
        {
            PointF delta = new PointF();
            delta.X = (bird.x + bird.size / 2) - (house.x + (house.sizeX) / 2);
            delta.Y = (bird.y + bird.size / 2) - (house.y + (house.sizeY) / 2);

            if (Math.Abs(delta.X) <= bird.size / 2 + (house.sizeX) / 2-35
                && Math.Abs(delta.Y) <= bird.size / 2 + (house.sizeY) / 2
                || bird.y > 600
                ) 
            {
                
                    return true;
                

                    
            }
                
                
            
                

            


            return false;
        }

        public void Write(int b)
        {
            try
            {
                StreamWriter sw = new StreamWriter(score.a);
                sw.WriteLine("Highest Score: " + b);
                sw.Close();
            }
            catch
            {
                Console.WriteLine("");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            button2.Visible = false;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            circularButton1.Visible = true;
            gamestarton = true;

        }

        private void circularButton1_Click_1(object sender, EventArgs e)
        {
            _tick = 0;
            if (bird.isAlive)
            {
                gravity = 0;
                if (bird.y >= 20)
                {
                    bird.gravityValue = -0.05f;
                    bird.gravityValue = -0.13f;
                }

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _tick1 += 0.5f;
            _tick2 += 0.5f;

            if (_tick2 == 6)
            {
                showhouse1 = 1;

            }
            if (_tick2 == 12)
            {
                showhouse1 = 2;


            }
            if (_tick2 == 18)
            {
                showhouse1 = 3;


            }
            if (_tick2 == 24)
            {
                showhouse1 = 4;


            }
            if (_tick2 == 30)
            {
                showhouse1 = 5;


            }
            if (_tick2 == 36)
            {
                showhouse1 = 6;


            }
            if (_tick2 == 42)
            {
                showhouse1 = 7;


            }
            if (_tick2 == 48)
            {
                showhouse1 = 8;


            }
            if (_tick2 == 52)
            {
                showhouse1 = 9;
                _tick2 = 0;


            }


            if (_tick1 == 12)
            {
                cloudpicture1 = false;

            }
            if (_tick1 == 24)
            {
                cloudpicture1 = true;
                _tick1 = 0;

            }


            _tick += 0.5f;
            if (_tick == 3)
            {
                showbird1 = 1;

            }

            if (_tick == 6)
            {
                showbird1 = 2;

            }

            if (_tick == 9)
            {
                showbird1 = 3;
            }

            if (_tick == 12)
            {
                showbird1 = 4;
            }

            if (_tick == 15)
            {
                showbird1 = 5;
                
            }

            if (_tick == 18)
            {
                showbird1 = 6;
            }

            if (_tick == 21)
            {
                showbird1 = 7;
            }
            if (_tick == 24)
            {
                showbird1 = 8;
                _tick = 0;
            }
            


        }
    }
}

