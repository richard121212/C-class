using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace followthrougame
{
    class Beckmoveitems
    {
        public int x;
        public int y;

        public int sizeX;
        public int sizeY;

        public Image fontImg;

        public Beckmoveitems(int x, int y, bool isRotatedImage = false)
        {
            //fontImg = new Bitmap("C:\\Users\\37126\\Desktop\\flappybirb\\fontmove.png");
            fontImg = new Bitmap("fontmove.png");
            this.x = x;
            this.y = y;
            sizeX = 1071;
            sizeY = 600;
            
        }
    }
}

