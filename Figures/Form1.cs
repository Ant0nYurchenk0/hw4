using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figures
{
    public partial class Form1 : Form
    {
        double var1, var2, var3;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem)
            {
                case "Circle":
                    Circle circle = new Circle(var1);
                    textBox4.Text = Convert.ToString(circle.GetPerimeter());
                    break;
                case "Triangle":
                    Triangle triangle = new Triangle(var1, var2, var3);
                    textBox4.Text = Convert.ToString(triangle.GetPerimeter());
                    break;
                case "Rectangle":
                    Rectangle Rectangle = new Rectangle(var1, var2);
                    textBox4.Text = Convert.ToString(Rectangle.GetPerimeter());
                    break;
                case "Square":
                    Square Square = new Square(var1);
                    textBox4.Text = Convert.ToString(Square.GetPerimeter());
                    break;
                case "Diamond":
                    Diamond Diamond = new Diamond(var1, var2, var3);
                    textBox4.Text = Convert.ToString(Diamond.GetPerimeter());
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                switch (comboBox1.SelectedItem)
                {
                    case "Circle":
                        Circle circle = new Circle(var1);
                        textBox4.Text = Convert.ToString(circle.GetSquare());
                        break;
                    case "Triangle":
                        Triangle triangle = new Triangle(var1, var2, var3);
                        textBox4.Text = Convert.ToString(triangle.GetSquare());
                        break;
                    case "Rectangle":
                        Rectangle Rectangle = new Rectangle(var1, var2);
                        textBox4.Text = Convert.ToString(Rectangle.GetSquare());
                        break;
                    case "Square":
                        Square Square = new Square(var1);
                        textBox4.Text = Convert.ToString(Square.GetSquare());
                        break;
                    case "Diamond":
                        Diamond Diamond = new Diamond(var1, var2, var3);
                        textBox4.Text = Convert.ToString(Diamond.GetSquare());
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.var1 = Convert.ToDouble(textBox1.Text);
            }
            catch
            {
                textBox4.Text = "INCORRECT SIDE VALUE";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                switch (comboBox1.SelectedItem)
                {
                    case "Circle":
                        textBox1.ReadOnly = false;
                        textBox1.Text = "Enter the radius";
                        textBox2.ReadOnly = true;
                        textBox3.ReadOnly = true;
                        break;
                    case "Triangle":
                        textBox1.ReadOnly = false;
                        textBox1.Text = "Enter the first side";
                        textBox2.ReadOnly = false;
                        textBox2.Text = "Enter the second side";
                        textBox3.ReadOnly = false;
                        textBox3.Text = "Enter the third side";
                        break;
                    case "Rectangle":
                        textBox1.ReadOnly = false;
                        textBox1.Text = "Enter the first side";
                        textBox2.ReadOnly = false;
                        textBox2.Text = "Enter the second side";
                        textBox3.ReadOnly = true;
                        break;
                    case "Square":
                        textBox1.ReadOnly = false;
                        textBox1.Text = "Enter the side";
                        textBox2.ReadOnly = true;
                        textBox3.ReadOnly = true;
                        break;
                    case "Diamond":
                        textBox1.ReadOnly = false;
                        textBox1.Text = "Enter the first diagonal";
                        textBox2.ReadOnly = false;
                        textBox2.Text = "Enter the second diagonal";
                        textBox3.ReadOnly = false;
                        textBox3.Text = "Enter the side";
                        break;
                    default:
                        textBox1.ReadOnly = true;
                        textBox2.ReadOnly = true;
                        textBox3.ReadOnly = true;
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.var2 = Convert.ToDouble(textBox2.Text);
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
                this.var3 = Convert.ToDouble(textBox3.Text);
            }
            catch
            {
                textBox4.Text = "INCORRECT SIDE VALUE";
            }
        }
    }
}
