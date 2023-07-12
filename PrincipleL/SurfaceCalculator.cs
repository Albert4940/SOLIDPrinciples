using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipleL
{
    public class SurfaceCalculator
    {
        public int ComputeAllSizes(IEnumerable<ShapeWithSurface> shapes)
        {
            int result = 0;
            foreach(var shape in shapes)
            {
                result += shape.Surface;
            }
            return result;
        }

        public int ComputeSurface(ShapeWithSurface shape)
        {
            return shape.GetSurface();
        }
        /*private int ComputeSize(Shape shape)
        {
            if(shape is Square s)
            {
                return s.SideSize * s.SideSize;
            }
            else if(shape is Rectangle r)
            {
                return r.Height + r.Width;
            }
            throw new InvalidOperationException();
        }*/
    }
}
