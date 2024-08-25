using ClassLibraryForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw
{
    public class Circle:Shape
    {

        public Point centre;
        public int radius;
        public Circle()
        {
            centre = new Point();
            radius = 10;
            this.color=Color.White;
        }
        public Circle(int x,int y, int radius,Color color)
        {
            centre=new Point(x,y);
            this.radius = radius;
            this.color = color;
        }
        public override void Draw()
        {
            DrawingClass.DrawCircle(color,centre.x,centre.y,radius,true);
        }
    }
}
