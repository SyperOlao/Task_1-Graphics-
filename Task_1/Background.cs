using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_1
{
    class Background
    {
        public void Land(Graphics graf, Pen pen, Brush br, int x, int y, int width, int height, int amountOfGrass, int heightOfGrass)
        {
            graf.FillRectangle(br, x, y, width, height);
            graf.DrawRectangle(pen, x, y, width, height);
            int lenght = (width - x)/amountOfGrass;
            int temp = 0;
            for (int i = 0; i < amountOfGrass; i++)
            {
                temp += lenght;
                graf.DrawLine(pen, temp, y, temp, heightOfGrass);
            }
        }
        public void Sky (Graphics graf, Brush sky, int x, int y, int width, int height)
        {
            graf.FillRectangle(sky, x, y, width, height);
        }
    }
}
