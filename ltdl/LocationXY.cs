using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ltdl
{
    internal class LocationXY
    {
        public int x1, y1, x2, y2,w;
        public LocationXY(int x1, int y1, int x2, int y2,int w)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            this.w = w;
        }
        public override bool Equals(object obj)
        {
            if (obj is LocationXY other)
            {
                return x1 == other.x1 && y1 == other.y1 && x2 == other.x2 && y2 == other.y2 && w ==other.w;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(x1, y1, x2, y2,w);
        }
    }

}
