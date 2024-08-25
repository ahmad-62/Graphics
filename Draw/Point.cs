using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw
{
    public   class Point
    {
        public int x;
        public int y;
        public Point()
        {
            x = y = 10;
        }
        public Point (int x, int y)
        {
            this.x = x;
            this.y = y;

        }
    }
}
