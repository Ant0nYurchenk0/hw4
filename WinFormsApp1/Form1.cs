using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double side1, side2, angle;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.side1 = Convert.ToDouble(textBox1.Text);
            }
            catch
            {
                textBox4.Text = "INVALID SIDE VALUE";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.side2 = Convert.ToDouble(textBox2.Text);
            }
            catch
            {
                textBox4.Text = "INVALID SIDE VALUE";
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.angle = Convert.ToDouble(textBox3.Text);
                if (Math.Abs(this.angle) > 360)
                    throw new Exception();
            }
            catch
            {
                textBox4.Text = "INVALID ANGLE VALUE";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                IsoscelesTriangle itr = new IsoscelesTriangle(this.side1, this.side2, this.angle);
                textBox4.Text = "Perimeter of the isosceles triangle: " + Convert.ToString(itr.GetPerimeter());
            }
            catch { 
                try
                {
                    RightTriangle itr = new RightTriangle(this.side1, this.side2, this.angle);
                    textBox4.Text = "Perimeter of the right triangle: " + Convert.ToString(itr.GetPerimeter());
                }
                catch
                {
                    MessageBox.Show("Values do not correspond to either type of triangles");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                IsoscelesTriangle itr = new IsoscelesTriangle(this.side1, this.side2, this.angle);
                textBox4.Text = "Square of the isosceles triangle: " + Convert.ToString(itr.GetSquare());
            }
            catch
            {
                try
                {
                    RightTriangle itr = new RightTriangle(this.side1, this.side2, this.angle);
                    textBox4.Text = "Square of the right triangle: " + Convert.ToString(itr.GetSquare());
                }
                catch
                {
                    MessageBox.Show("Values do not correspond to either type of triangles");
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
