using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graf = e.Graphics;
            DrawForm(graf);
        }

        private void DrawForm(Graphics graf) {

            graf.Clear(SystemColors.Control);
            int width = this.ClientSize.Width;
            int height = this.ClientSize.Height;

            Brush brush = new SolidBrush(Color.LightBlue);
            Background background = new Background();
            background.Sky(graf, brush, 0, 0, width, height);

            House house = new House();
            Pen pen = new Pen(Color.Brown, 5);
            Brush brushHouse = new SolidBrush(Color.FromArgb(241, 18, 68));
            Brush brushRoof = new SolidBrush(Color.FromArgb(153, 13, 247));
            Brush brushWindow = new SolidBrush(Color.Black);
            house.DrawAHouse(graf, pen, brushHouse, brushRoof, brushWindow, width/15, height/3,width/7, height/2, height/20);

            House house1 = new House();
            pen = new Pen(Color.DarkBlue, 5);
            brushHouse = new SolidBrush(Color.Purple);
            brushRoof = new SolidBrush(Color.BlueViolet);
            house1.DrawAHouse(graf, pen, brushHouse, brushRoof, brushWindow, width/3-width/10, height / 3, width / 3, height / 2, height / 20);

            Sun sun = new Sun();
            pen = new Pen(Color.Orange, 6);
            brush = new SolidBrush(Color.Yellow);
            sun.DrawASun(graf, pen, brush, width - width / 7, height / 20, width / 10, 10);

            pen = new Pen(Color.DarkGreen, 3);
            brush = new SolidBrush(Color.Green);
            brushHouse = new SolidBrush(Color.Brown);

            Tree tree = new Tree();
            tree.DrawTree(graf, brush, brushHouse, width / 2 + width / 3, height / 2 + height / 20, width / 25, height / 2, width / 7);

            background.Land(graf, pen, brush, 0, height / 2 + height / 3, width, height, 30, height / 2 + height / 4 + height / 20);


            Brush textBrush = new SolidBrush(Color.Black);
            String text = "(фото в цвете)";
            Font arialFont = new Font("Arial", height/25);
            graf.DrawString(text, arialFont, textBrush, width / 20, height - height / 10);

            textBrush = new SolidBrush(Color.DarkBlue);
            text = "Город Воронеж";
            arialFont = new Font("Calibri", height/20);
            graf.DrawString(text, arialFont, textBrush, width / 2,  height / 10);

            textBrush = new SolidBrush(Color.Red);
            text = "Магнит";
            graf.DrawString(text, arialFont, textBrush, width / 3, height / 3);

            pen.Dispose();
            brush.Dispose();
            brushHouse.Dispose();
            brushRoof.Dispose();
            brushWindow.Dispose();
            textBrush.Dispose();
        }
       

        private void Form1_Resize(object sender, EventArgs e)
        {
            Graphics graf = CreateGraphics();
            DrawForm(graf);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
              Invalidate();
        }

  
        private void Form1_SizeChanged(object sender, EventArgs e)
        {

        }

    }
}
