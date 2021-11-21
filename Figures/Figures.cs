using System;
using System.Collections.Generic;
using System.Text;

namespace Figures
{
    public abstract class Figure
    {
        public virtual double GetSquare() { return 0; }
        public virtual double GetPerimeter() { return 0; }
    }
    public class Triangle : Figure
    {
        double a, b, c;
        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || b <= 0)
            {
                throw new ArgumentException("Sides must be positive");
            }
            this.a = a;
            this.b = b;
            this.c = c;
            if (!this.CheckIfTriangle())
            {
                throw new ArgumentException("Side lenghts do not correspont to a triangle");
            }
        }
        private bool CheckIfTriangle()
        {
            if (this.a + this.b < this.c)
                return false;
            if (this.a + this.c < this.b)
                return false;
            if (this.c + this.b < this.a)
                return false;
            if (this.a < 0 || this.b < 0 || this.c < 0)
                return false;
            return true;
        }
        public override double GetPerimeter()
        {
            return this.a + this.b + this.c;
        }
        public override double GetSquare()
        {
            double s = this.GetPerimeter() / 2;
            double square = Math.Pow(s * (s - this.a) * (s - this.b) * (s - this.c), 0.5);
            return square;
        }
    }
    public class Circle : Figure
    {
        double radius;
        public Circle(double r)
        {
            if (r <= 0)
            {
                throw new ArgumentException("Sides must be positive");
            }
            this.radius = r;
        }
        public override double GetPerimeter()
        {
            return 2 * Math.PI * this.radius;
        }
        public override double GetSquare()
        {
            return Math.PI * Math.Pow(this.radius, 2);
        }
    }
    public class Rectangle : Figure
    {
        double a, b;
        public Rectangle(double a, double b)
        {
            if (a <= 0 || b <= 0)
            {
                throw new ArgumentException("Sides must be positive");
            }
            this.a = a;
            this.b = b;
        }
        public override double GetPerimeter()
        {
            return 2*(this.a + this.b);
        }
        public override double GetSquare()
        {
            return this.a * this.b;
        }
    }
    public class Square : Figure
    {
        double side;
        public Square(double side)
        {
            if (side <= 0 )
            {
                throw new ArgumentException("Sides must be positive");
            }
            this.side = side;
        }
        public override double GetPerimeter()
        {
            return 4 * this.side;
        }
        public override double GetSquare()
        {
            return Math.Pow(this.side, 2);
        }
    }
    public class Diamond: Figure
    {
        double a, b, s;
        public Diamond(double a, double b, double s)
        {
            if (a <= 0 || b <= 0 || s <= 0)
            {
                throw new ArgumentException("Sides must be positive");
            }
            this.a = a;
            this.b = b;
            this.s = s;
            if (!this.CheckIfDiamond())
            {
                throw new ArgumentException("Side lenghts do not correspont to a diamond");
            }
        }
        private bool CheckIfDiamond()
        {
            if (Math.Pow(this.a / 2, 2) + Math.Pow(this.b / 2, 2) == Math.Pow(this.s, 2))
            {
                return true;
            }
            return false;
        }
        public override double GetPerimeter()
        {
            return 4 * s;
        }
        public override double GetSquare()
        {
            return a * b / 2;
        }
    }
}
