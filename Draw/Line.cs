using ClassLibraryForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw
{
    public class Line : Shape
    {
        public Point Start;
        public Point End;
        public Line ()
            {
            Start = new Point ();
            End = new Point ();
            color = Color.White;
            }
        public Line(int x1,int x2,int y1,int y2,Color color)
        {
            Start = new Point (x1,y1);
            End = new Point (x2,y2);
            this.color= color;
        }
   

        public override void Draw()
        {
DrawingClass.DrawLine(color, Start.x,Start.y,End.x, End.y);
        }
    }
}
