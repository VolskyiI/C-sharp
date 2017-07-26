using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_7
{
    class ComplexNumber
    {
        //Завдання #1
        public ComplexNumber(int real, int imaginary)
        {
            this.Real = real;
            this.Imaginary = imaginary;
        }

        public int Real { get; set; }
        public int Imaginary { get ; set ; }
        //Завдання #2
        public static ComplexNumber operator +(ComplexNumber x, ComplexNumber y)
        {
            int newreal = x.Real + y.Real;
            int newimaginary = x.Imaginary + y.Imaginary;
            return new ComplexNumber(newreal, newimaginary);
        }
        public static ComplexNumber operator -(ComplexNumber x, ComplexNumber y)
        {
            int newreal = x.Real - y.Real;
            int newimaginary = x.Imaginary - y.Imaginary;
            return new ComplexNumber(newreal, newimaginary);
        }


        public static bool operator <(ComplexNumber x, ComplexNumber y)
        {
            return (x.Real * x.Imaginary) < (y.Real * y.Imaginary) ? true : false;
        }
        public static bool operator >(ComplexNumber x, ComplexNumber y)
        {
            return (x.Real * x.Imaginary) > (y.Real * y.Imaginary) ? true : false;
        }


        public override int GetHashCode()
        {
            int prime = 12;
            int result = 1;

            result = result * prime + Real.GetHashCode();
            result = result * prime + Imaginary.GetHashCode();

            return result;
        }

        public override bool Equals(Object comp)
        {
            if (comp == null)
            {
                return false;
            }

            ComplexNumber compNum = comp as ComplexNumber;

            return (this.Real==(compNum.Real) && this.Imaginary==(compNum.Imaginary));

        }

        public static bool operator ==(ComplexNumber x, ComplexNumber y)
        {
            return (x.Real.Equals(y.Real) && x.Imaginary.Equals(y.Imaginary)) ? true : false;
        }
        public static bool operator !=(ComplexNumber x, ComplexNumber y)
        {
            return (x.Real.Equals(y.Real) && x.Imaginary.Equals(y.Imaginary)) ? false : true;
        }


        //Завдання #3
        public static explicit operator ComplexNumber(string str)
        {
            int x=0, y=1;
            for (int i = 0; i < str.Length; i++)
            {
                if (x==0 && Char.IsDigit(str[i]))
                {
                    x = Convert.ToInt32(Char.GetNumericValue(str[i]));
                }
                if (x != 0 && Char.IsDigit(str[i]))
                {
                    y = Convert.ToInt32(Char.GetNumericValue(str[i]));
                }
            }

            return new ComplexNumber(x,y) ;
        }

        public static implicit operator string(ComplexNumber x)
        {
            return x.Real + "+i*" + x.Imaginary;
        }
        //Завдання #4
        public override string ToString()
        {
            return   Real + "+i*" + Imaginary;
        }
    }

}

