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
        public ComplexNumbers(int realNumber, int imaginaryNumber)
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

        public override string ToString()
        {
            return $"{realNumber} + {imaginaryNumber}i";
        }
    }
}
