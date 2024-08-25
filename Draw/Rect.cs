using ClassLibraryForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw
{
    public class Rect : Shape
    {
        public Point start;
        public int width;
        public int height;
        public Rect()
        {
            start = new Point();
            width = 0;
            height = 0;
            this.color = Color.White;


        }
        public Rect(int x1, int y1, int w, int h, Color color)
        {
            start = new Point(x1, y1);
            width = w;
            height = h;
            this.color = color;


        }
        public override void Draw()
        {
            DrawingClass.DrawRectangle(color, start.x,start.y,width,height);
        }
    }
}
