using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangle
{
    public partial class Form1 : Form
    {
        private Triangle Triangle;
        private EquilateralTriangle EquilateralTriangle;
        private double side1;
        private double side2;
        private double side3;
        public Form1()
        {
            InitializeComponent();
            this.side1 = 0;
            this.side2 = 0;
            this.side3 = 0;
            this.Triangle = new Triangle(side1, side2, side3);
            this.EquilateralTriangle = new EquilateralTriangle(side1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Triangle.ChangeSides(this.side1, this.side2, this.side3);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
                textBox4.Text = "";
            }
            textBox4.Text = Convert.ToString(Triangle.GetPerimeter());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.EquilateralTriangle.ChangeSides(this.side1, this.side2, this.side3);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                textBox4.Text = "";
            }
            textBox4.Text = Convert.ToString(EquilateralTriangle.GetSquare());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox1.ForeColor = Color.Black;
                this.side1 = Convert.ToDouble(textBox1.Text);
            }
            catch
            {
                textBox4.ForeColor = Color.Red;
                textBox4.Text = "INCORRECT SIDE VALUE";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox1.ForeColor = Color.Black;
                this.side2 = Convert.ToDouble(textBox2.Text);
            }
            catch
            {
                textBox4.Text = "INCORRECT SIDE VALUE";
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox3.ForeColor = Color.Black;
                this.side3 = Convert.ToDouble(textBox3.Text);
            }
            catch
            {
                textBox4.Text = "INCORRECT SIDE VALUE";
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
