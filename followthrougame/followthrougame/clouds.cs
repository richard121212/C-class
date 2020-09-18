using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace followthrougame
{
    class clouds
    {
        public int x;
        public int y;
        public int sizeX;
        public int sizeY;
        public Image cloudImg;
        public Image cloudImg2;

        public clouds(int x, int y, bool isRotatedImage = false)
        {
            //cloudImg = new Bitmap("C:\\Users\\37126\\Desktop\\flappybirb\\cloudpng\\cloud.png");
            //cloudImg2 = new Bitmap("C:\\Users\\37126\\Desktop\\flappybirb\\cloudpng\\cloud9.png");

            cloudImg = new Bitmap("cloud.png");
            cloudImg2 = new Bitmap("cloud9.png");
            this.x = x;
            this.y = y;
            sizeX = 300;
            sizeY = 147;

        }
    }
}

