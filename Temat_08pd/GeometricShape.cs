using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temat_08pd
{
    abstract internal class GeometricShape
    {
        public GeometricShape()
        {

        }
        public abstract double ShapeArea();
        public abstract double ShapePerimeter();
        public abstract void Show();
    }
}
