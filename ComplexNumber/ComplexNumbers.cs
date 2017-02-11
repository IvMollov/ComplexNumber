using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumber
{
    class ComplexNumbers
    {
        private double realNumber;
        private double imaginaryNumber;

        public ComplexNumbers()
        {

        }
        public ComplexNumbers(double realNumber, double imaginaryNumber)
        {
            this.realNumber = realNumber;
            this.imaginaryNumber = imaginaryNumber;
        }

        public double RealNumber
        {
            get { return this.realNumber; }
            set { this.realNumber = value; }
        }
        public double ImaginaryNumber
        {
            get { return this.imaginaryNumber; }
            set { this.imaginaryNumber = value; }
        }

        public double this[int index]
        {
            get
            {
                if (index == 0)
                {
                    return this.realNumber;
                }
                else if (index == 1)
                {
                    return this.imaginaryNumber;
                }
                else
                {
                    throw new IndexOutOfRangeException("Index out of range!");
                }
            }
        }

        public static ComplexNumbers operator +(ComplexNumbers number1, ComplexNumbers number2)
        {
           
            ComplexNumbers complNmb = new ComplexNumbers();
            complNmb.realNumber = number1.realNumber + number2.realNumber;
            complNmb.imaginaryNumber = number1.imaginaryNumber + number2.imaginaryNumber;
            return complNmb;
        }

        public static ComplexNumbers operator -(ComplexNumbers number1, ComplexNumbers number2)
        {
            ComplexNumbers complNmb = new ComplexNumbers();
            complNmb.realNumber = number1.realNumber - number2.realNumber;
            complNmb.imaginaryNumber = number1.imaginaryNumber - number2.imaginaryNumber;
            return complNmb;
        }

        public static ComplexNumbers operator /(ComplexNumbers number1, ComplexNumbers number2)
        {
            ComplexNumbers complNmb = new ComplexNumbers();
            complNmb.realNumber = ((number1.realNumber * number2.realNumber) - (-number1.imaginaryNumber * number2.imaginaryNumber));
            complNmb.imaginaryNumber = ((number1.realNumber * number2.imaginaryNumber) + (-number1.imaginaryNumber * number2.realNumber));
            return complNmb;
        }

        public static ComplexNumbers operator *(ComplexNumbers number1, ComplexNumbers number2)
        {
            ComplexNumbers complNmb = new ComplexNumbers();
            complNmb.realNumber = ((number1.realNumber * number2.realNumber) - (number1.imaginaryNumber * number2.imaginaryNumber));
            complNmb.imaginaryNumber = ((number1.realNumber * number2.imaginaryNumber) + (number1.imaginaryNumber * number2.realNumber));
            return complNmb;
        }

        public static implicit operator ComplexNumbers(double number)
        {
            return new ComplexNumbers(number, number);
        }

        public static explicit operator double(ComplexNumbers number)
        {
            double value;
            return value = number.realNumber + number.imaginaryNumber;
        }
        public override string ToString()
        {
            return $"{realNumber} + {imaginaryNumber}i";
        }
    }
}
