using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw
{
    public class Picture
    {
        private Shape []shapes;
        public Picture(Shape[]shapes ) {
        this.shapes = shapes;
        
        }
        public void Drawshapes()
        {
            foreach ( Shape shape in shapes )
            {
                shape.Draw();
            }
        }
    }
}
