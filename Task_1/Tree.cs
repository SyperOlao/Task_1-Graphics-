using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Tree
    {
        public void DrawTree(Graphics graf, Brush brushList, Brush brush, int x, int y, int width, int height, int diametr)
        {
            graf.FillRectangle(brush, x, y, width, height);
            graf.FillEllipse(brushList, x- diametr / 3, y - diametr / 2, diametr, diametr);
        }
    }
}
