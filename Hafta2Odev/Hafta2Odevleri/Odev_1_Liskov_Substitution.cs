using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta2Odevleri
{
    public class Shape
    {
        public virtual double Area()
        {
            return 0;
        }
    }

    public class Rectangle : Shape
    {
        public double Width { get; set; } = 10;
        public double Height { get; set; } = 20;

        public override double Area()
        {
            return Width * Height;
        }
    }

    public class Square : Rectangle
    {
        public override double Area()
        {
            return Width * Width;
        }
    }
}
