using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_1
{
    class Sun
    {
        public void DrawASun(Graphics graf, Pen pen, Brush brushSun, int x, int y, int diametr, int amountOfLines)
        {
            graf.FillEllipse(brushSun, x, y, diametr, diametr);
            graf.DrawEllipse(pen, x, y, diametr, diametr);

            double da = 2 * Math.PI / amountOfLines;

            for (int i = 0; i < amountOfLines; i++)
            {
                int dx1, dx2, dy1, dy2;
                dx1 = (int)(x+ diametr / 2 + diametr /2* Math.Cos(da * i));
                dy1 = (int)(y+diametr /2 + diametr /2* Math.Sin(da * i));
                dx2 = (int)(x+diametr /2 + diametr  * Math.Cos(da * i));
                dy2 = (int)(y+ diametr / 2 + diametr * Math.Sin(da * i));
                graf.DrawLine(pen, dx1, dy1, dx2, dy2);
            }
        }
    }
}
