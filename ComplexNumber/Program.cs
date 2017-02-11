using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Press 1 to add two complex numbers.\n");
                Console.WriteLine("Press 2 to multiply two complex numbers.\n");
                Console.WriteLine("Press 3 to subtract two complex numbers.\n");
                Console.WriteLine("Press 4 to divide two complex numbers.\n");
                Console.WriteLine("Press any other number to exit.\n");
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                if (choice >= 5 || choice < 1)
                {
                    Console.WriteLine("\nYour choice is to Exit!");
                    Console.ReadLine();
                    return;
                }

                Console.WriteLine("Enter a and b where a + bi is the first complex number.");
                Console.Write("a = ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("b = ");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter c and d where c + di is the second complex number.");
                Console.Write("c = ");
                double c = double.Parse(Console.ReadLine());
                Console.Write("d = ");
                double d = double.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        ComplexNumbers number1 = new ComplexNumbers(a, b);
                        Console.WriteLine("First complex number: {0}", number1);
                        ComplexNumbers number2 = new ComplexNumbers(c, d);
                        Console.WriteLine("Second complex number: {0}", number2);
                        ComplexNumbers result = new ComplexNumbers();
                        result = number1 + number2;
                        try
                        {
                            Console.WriteLine("Sum of two complex numbers = {0}" +
                                                        "\nReal part: {1}, complex part: {2}\n----------------------------", result, result[0], result[2]);
                        }
                        catch(IndexOutOfRangeException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case 2:
                        ComplexNumbers number3 = new ComplexNumbers(a, b);
                        Console.WriteLine("First complex number: {0}", number3);
                        ComplexNumbers number4 = new ComplexNumbers(c, d);
                        Console.WriteLine("Second complex number: {0}", number4);
                        ComplexNumbers result1 = new ComplexNumbers();
                        result1 = number3 * number4;
                        try
                        {
                            Console.WriteLine("Multiplication of two complex numbers = {0}" +
                           "\nReal part: {1}, complex part: {2}\n----------------------------", result1, result1[0], result1[1]);
                        }
                        catch (IndexOutOfRangeException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case 3:
                        ComplexNumbers number5 = new ComplexNumbers(a, b);
                        Console.WriteLine("First complex number: {0}", number5);
                        ComplexNumbers number6 = new ComplexNumbers(c, d);
                        Console.WriteLine("Second complex number: {0}", number6);
                        ComplexNumbers result2 = new ComplexNumbers();
                        result2 = number5 - number6;
                        try
                        {
                            Console.WriteLine("Difference of two complex numbers = {0}" +
                           "\nReal part: {1}, complex part: {2}\n----------------------------", result2, result2[0], result2[1]);
                        }
                        catch (IndexOutOfRangeException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case 4:
                        ComplexNumbers number7 = new ComplexNumbers(6, 3);
                        Console.WriteLine("First complex number: {0}", number7);
                        ComplexNumbers number8 = new ComplexNumbers(5, 2);
                        Console.WriteLine("Second complex number: {0}", number8);
                        ComplexNumbers result3 = new ComplexNumbers();
                        result3 = number7 / number8;
                        Console.WriteLine("After dividing: {0}", result3);
                        break;

                }
            }
        }
    }
}

