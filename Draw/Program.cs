using ClassLibraryForms;
using System.Drawing;

namespace Draw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DrawingClass.StartDraw(800, 600, "my graphics");

            Rect rect = new Rect(5,5,50,50,Color.White);
            Line l=new Line(70,140,70,140,Color.AliceBlue);
            Circle circle = new Circle(70,25,30,Color.Blue);
            Shape[] shapes = {rect,l,circle};   
            Picture picture=new Picture(shapes);
            picture.Drawshapes();
            DrawingClass.EndDraw();
        }
    }
}
