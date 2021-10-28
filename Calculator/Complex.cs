using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Complex
    {
        private double real;
        private double imagine;

        public Complex()
        {
            this.real = 0;
            this.imagine = 0;
        }
        public Complex(double r, double im)
        {
            this.real = r;
            this.imagine = im;
        }
        
        public void SetComplex(double a, double b)
        {
            real = a;
            imagine = b;
        }

        public static Complex operator+(Complex a, Complex b)
        {
            Complex result = new Complex();
            result.real = a.real + b.real;
            result.imagine = a.imagine + b.imagine;
            return result;
        }
        public static Complex operator -(Complex a, Complex b)
        {
            Complex result = new Complex();
            result.real = a.real - b.real;
            result.imagine = a.imagine - b.imagine;
            return result;
        }
        public static Complex operator *(Complex a, Complex b)
        {
            Complex result = new Complex();
            result.real = a.real * b.real - a.imagine*b.imagine;
            result.imagine = a.imagine * b.real + a.real * b.imagine;
            return result;
        }
        public static Complex operator /(Complex a, Complex b)
        {
            Complex result = new Complex();
            result.real = (a.real * b.real + a.imagine * b.imagine) /
                        (Math.Pow(b.real, 2) + Math.Pow(b.imagine, 2));
            
            result.imagine = (a.imagine * b.real - a.real * b.imagine) /
                        (Math.Pow(b.real, 2) + Math.Pow(b.imagine, 2));
            return result;
        }

        public static string Equal(Complex a, Complex b)
        {
            string message = "";
            double gip1 = 0;
            double gip2 = 0;
            gip1 = Math.Sqrt(Math.Pow(a.real, 2) + Math.Pow(a.imagine, 2));
            gip2 = Math.Sqrt(Math.Pow(b.real, 2) + Math.Pow(b.imagine, 2));
            if (gip1 != gip2)
                if (gip1 > gip2)
                {
                    message = "Вектор первого числа больше второго";
                }
                else
                    message = "Вектор второго числа больше первого";
            else
                message = "Векторы равны";
            return message;
        }

        public static string Answer(Complex ans)
        {
            string sign = "+";
            if(ans.imagine<0)
            {
                sign = "";
            }
            return String.Format("{0}{1}{2}i", Math.Round(ans.real,3), sign, Math.Round(ans.imagine, 3));
        }
    }
}
