using System;
using System.Collections.Generic;
using System.Text;

namespace Triangles
{
    abstract class Triangle
    {
        protected double side1, side2, side3, angle;

        public virtual double GetPerimeter()
        {
            return this.side1 + this.side2 + this.side3;
        }
        public virtual double GetSquare()
        {
            double s = this.GetPerimeter() / 2;
            return Math.Pow(s * (s - this.side1) * (s - this.side2) * (s - this.side3), 0.5);
        }
    }
    class IsoscelesTriangle : Triangle
    {
        public IsoscelesTriangle(double side1, double side2, double angle)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.angle = angle;
            this.side3 = Math.Pow(Math.Pow(this.side1, 2) + Math.Pow(this.side2, 2) - 2*this.side1*this.side2*Math.Cos(this.angle * Math.PI / 180.0), 0.5);
            this.CheckCorrect();
        }
        void CheckCorrect()
        {
            if (this.side1 + this.side2 < this.side3 ||
                this.side1 + this.side3 < this.side2 ||
                this.side2 + this.side3 < this.side1 ||
                this.side1 < 0 || this.side2 < 0 || this.side3 < 0)
            {
                throw new ArgumentException("Side lengths do not correspond to a triangle");
            }
            if (this.side1 != this.side2 && this.side2 != this.side3 && this.side1 != this.side3)
            {
                throw new ArgumentException("Side lengths do not correspond to an iscosceles triangle");
            }
        }
    }
    class RightTriangle : Triangle
    {
        public RightTriangle(double side1, double side2, double angle)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.angle = angle;
            this.side3 = Math.Pow(Math.Pow(this.side1, 2) + Math.Pow(this.side2, 2) - 2 * this.side1 * this.side2 * Math.Cos(this.angle * Math.PI / 180.0), 0.5);
            this.CheckCorrect();
        }
        void CheckCorrect()
        {
            if (this.side1 + this.side2 < this.side3 ||
                this.side1 + this.side3 < this.side2 ||
                this.side2 + this.side3 < this.side1 ||
                this.side1 < 0 || this.side2 < 0 || this.side3 < 0)
            {
                throw new ArgumentException("Side lengths do not correspond to a triangle");
            }
            if (Math.Pow(this.side1, 2) + Math.Pow(this.side2, 2) != Math.Pow(this.side3, 2) &&
                Math.Pow(this.side2, 2) + Math.Pow(this.side3, 2) != Math.Pow(this.side1, 2) &&
                Math.Pow(this.side1, 2) + Math.Pow(this.side3, 2) != Math.Pow(this.side2, 2))
            {
                throw new ArgumentException("Side lengths do not correspond to a right triangle");
            }
        }
    }
}
