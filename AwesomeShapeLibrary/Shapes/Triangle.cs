using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AwesomeShapeLibrary.Interfaces;

namespace AwesomeShapeLibrary.Shapes
{
    public class Triangle : IShape
    {
        float sideA;
        float sideB;
        float sideC;

        public Triangle(float sideA, float sideB, float sideC)
        {
            if (IsTriangle(sideA,sideB,sideC))
            {
                this.sideA = sideA;
                this.sideB = sideB;
                this.sideC = sideC;
            }
            else
            {
                throw new ArgumentException("Wrong size sides");
            }
        }

        private static bool IsTriangle(float sideA, float sideB, float sideC)
        {
            if (sideA + sideB < sideC) return false;
            if (sideA + sideC < sideB) return false;
            if (sideB + sideC < sideA) return false;

            return true;
        }
        public bool IsRightTriangle()
        {
            var sides = new float[] { sideA, sideB, sideC };
            Array.Sort(sides);
            return Math.Abs(Math.Pow(sides[2], 2) - Math.Pow(sides[1], 2) - Math.Pow(sides[0], 2)) < 0.1;
        }
        public double CalculateArea()
        {
            float halfP = (sideA + sideB + sideC) / 2;

            float area = MathF.Sqrt(halfP * (halfP - sideA) * (halfP - sideB) * (halfP - sideC));

            return area;
        }
    }
}
