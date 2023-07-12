using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipleO
{
    public class Rectangle : ShapeWithSurface
    {
        public int Height { set; get; }
        public int Width { set; get; }

        public override int Surface => Height * Width;
    }
}
