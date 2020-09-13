using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_1
{
    class House
    {
        public void DrawAHouse(Graphics graf, Pen pen, Brush brushHouse, Brush brushRoof, Brush brushWindow, int x, int y, int width, int height, int heightRoof)
        { 
            graf.DrawRectangle(pen, x, y, width, height);
            graf.FillRectangle(brushHouse, x, y, width, height);
            Point[] points = new Point[3];
            points[0].X = x; points[0].Y = y;
            points[1].X = width+x; points[1].Y = y;
            points[2].X = width; points[2].Y = heightRoof;
            graf.FillPolygon(brushRoof, points); //Fill Roof
            graf.DrawPolygon(pen, points); //Roof
            graf.FillRectangle(brushWindow, x / 2 + width / 2, height + height / 4, width / 2, y- height / 4);//Fill Door
            graf.DrawRectangle(pen, x/2+width/2, height+height/4, width/2, y-height / 4);  //Door
            graf.FillRectangle(brushWindow, width + width / 10, height / 2 + height / 3, width / 4, height / 4); //Fill Window
            graf.DrawRectangle(pen, width + width / 10, height / 2 + height / 3, width / 4, height / 4); //Window
            //graf.DrawLine(pen, width + width / 3, y+height / 2 , width+width / 3, y+height / 4);
        }
    }
}
