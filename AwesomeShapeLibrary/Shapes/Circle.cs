using AwesomeShapeLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeShapeLibrary.Shapes
{
    public class Circle : IShape
    {
        float radius;
        public Circle(float radius)
        {
            this.radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(radius,2);
        }
    }
}
