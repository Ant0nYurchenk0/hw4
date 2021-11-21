using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangle
{
    public class Triangle
    {
        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public virtual void ChangeSides(double a, double b, double c)
        {
            this.ChangeSideA(a);
            this.ChangeSideB(b);
            this.ChangeSideC(c);
            if (!this.CheckIfTriangle())
            {
                throw new ArgumentException("The side lenghts do not correspond with a triangle");
            }
        }
        public double GetPerimeter()
        {
            return (this.a + this.b + this.c);
        }

        protected double a, b, c;
        protected void ChangeSideA(double NewSide)
        {
            this.a = NewSide;
        }
        protected void ChangeSideB(double NewSide)
        {
            this.b = NewSide;
        }
        protected void ChangeSideC(double NewSide)
        {
            this.c = NewSide;
        }
        protected bool CheckIfTriangle()
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
    }
    public class EquilateralTriangle : Triangle
    {
        public EquilateralTriangle(double a) : base(a, a, a)
        {
            return;
        }
        public override void ChangeSides(double a, double b, double c)
        {
            if (a!=b || a != c)
            {
                throw new DataMisalignedException("Sides of an equilateral triangle must be equal");
            }
            this.ChangeSideA(a);
            this.ChangeSideB(b);
            this.ChangeSideC(c);
            if (!this.CheckIfTriangle())
            {
                throw new ArgumentException("The side lenghts do not correspond with a triangle");
            }
        }
        public double GetSquare()
        {
            double height = Math.Pow(Math.Pow(this.a, 2) - Math.Pow(this.a / 2, 2), 0.5);
            return this.a * height / 2;
        }
    }
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
