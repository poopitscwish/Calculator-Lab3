using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Calculate();
        }
        private void Calculate()
        {
            try
            {
                Complex z1 = new Complex(double.Parse(real1.Text), double.Parse(imagine1.Text));
                Complex z2 = new Complex(double.Parse(real2.Text), double.Parse(imagine2.Text));
                Complex result = new Complex();
                bool equal = false;
                byte wrongSign = 0;
                switch(operation.Text)
                {
                    case "+":
                        result = z1 + z2;
                        break;
                    case "-":
                        result = z1 - z2;
                        break;
                    case "*":
                        result = z1 * z2;
                        break;
                    case "/":
                        result = z1 / z2;
                        break;
                    case "<,>,=?":
                        equal = true;
                        break;
                    default:
                        wrongSign = 1;
                        break;
                }             
                if (wrongSign == 1)
                    answer.Text = "Несуществующий знак";
                else if (!equal)
                    answer.Text = Complex.Answer(result);
                else
                    answer.Text = Complex.Equal(z1, z2);
            }
            catch (FormatException)
            {
                answer.Text = "Не числовое значение!";
            }
        }
        private void real1_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void imagine1_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void real2_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void imagine2_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void operation_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void operation_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }
    }
}
