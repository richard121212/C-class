using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace followthrougame
{
    class TheWall
    {
        public int x;
        public int y;

        public int sizeX;
        public int sizeY;

        public Image houseImg1;
        public Image houseImg2;
        public Image houseImg3;
        public Image houseImg4;
        public Image houseImg5;
        public Image houseImg6;
        public Image houseImg7;
        public Image houseImg8;
        public Image houseImg9;

        public TheWall(int x, int y, bool isRotatedImage = false)
        {
            /*
            houseImg1 = new Bitmap("C:\\Users\\37126\\Desktop\\flappybirb\\house\\house1.png");
            houseImg2 = new Bitmap("C:\\Users\\37126\\Desktop\\flappybirb\\house\\house2.png");
            houseImg3 = new Bitmap("C:\\Users\\37126\\Desktop\\flappybirb\\house\\house3.png");
            houseImg4 = new Bitmap("C:\\Users\\37126\\Desktop\\flappybirb\\house\\house4.png");
            houseImg5 = new Bitmap("C:\\Users\\37126\\Desktop\\flappybirb\\house\\house5.png");
            houseImg6 = new Bitmap("C:\\Users\\37126\\Desktop\\flappybirb\\house\\house6.png");
            houseImg7 = new Bitmap("C:\\Users\\37126\\Desktop\\flappybirb\\house\\house7.png");
            houseImg8 = new Bitmap("C:\\Users\\37126\\Desktop\\flappybirb\\house\\house8.png");
            houseImg9 = new Bitmap("C:\\Users\\37126\\Desktop\\flappybirb\\house\\house9.png");
            */

            houseImg1 = new Bitmap("houseImg1.png");
            houseImg2 = new Bitmap("houseImg2.png");
            houseImg3 = new Bitmap("houseImg3.png");
            houseImg4 = new Bitmap("houseImg4.png");
            houseImg5 = new Bitmap("houseImg5.png");
            houseImg6 = new Bitmap("houseImg6.png");
            houseImg7 = new Bitmap("houseImg7.png");
            houseImg8 = new Bitmap("houseImg8.png");
            houseImg9 = new Bitmap("houseImg9.png");

            this.x = x;
            this.y = y;
            sizeX = 192;
            sizeY = 400;

        }
    }
}
