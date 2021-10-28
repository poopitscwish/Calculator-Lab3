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
            Calculate();
        }
        private void Calculate()
        {
            try
            {
                Complex z1 = new Complex(double.Parse(real1.Text), double.Parse(imagine1.Text));
                Complex z2 = new Complex(double.Parse(real2.Text), double.Parse(imagine2.Text));
                Complex result = new Complex();
                bool equal = false;
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
                        answer.Text = "Что-то не так";
                        return;
                }
                if (!equal)
                    answer.Text = Complex.Answer(result);
                else
                    answer.Text = Complex.Equal(z1, z2);
            }
            catch (SystemException)
            {
                answer.Text = "Что-то не так";
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
    }
}
