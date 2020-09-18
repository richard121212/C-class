using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace followthrougame
{
    class Player
    {
        public float x;
        public float y;
        public int size;
        public double meter;
        public Image birdImg1;
        public Image birdImg2;
        public Image birdImg3;
        public Image birdImg4;
        public Image birdImg5;
        public float gravityValue;
        public bool isAlive;

        public Player(int x, int y)
        {

            birdImg1 = new Bitmap("birdImg1.png");
            birdImg2 = new Bitmap("birdImg2.png");
            birdImg3 = new Bitmap("birdImg3.png");
            birdImg4 = new Bitmap("birdImg4.png");
            birdImg5 = new Bitmap("birdImg5.png");
            this.x = x;
            this.y = y;
            size = 25;
            gravityValue = 0.1f;
            meter = 0;
            isAlive = true;


        }
    }
}
