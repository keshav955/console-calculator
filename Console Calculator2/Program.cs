using System;

namespace Console_Calculator2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Console Calculator in C# \n------------------------");

            Calculator cal = new Calculator();
            cal.Getinput();
            cal.Option();
            cal.Display(cal.result);
        }
    }

    class Calculator
    {
        public float result = 0;
        int num1;
        int num2;
        string calculate;

        public void Getinput()
        {
            Console.Write("Type a number, and then press Enter: ");
            try
            {
                num1 = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Please enter a valid number ");
                Getinput();
                return;
            }
            Console.Write("Type another number, and then press Enter: ");
            try
            {
                num2 = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Please enter a valid number ");
                Getinput();
                return;
            }

        }

        public void Option()
        {
            Console.WriteLine("Choose an operator from the Following list:\n        A - Add \n        S - Subtract \n        D - Divide \n        M - Multiply \n");
            Console.Write("Your Option ? ");
            calculate = Console.ReadLine().ToUpper();

            if (calculate == "A")
            {
                result = Add(num1, num2);
            }
            else if (calculate.Equals("S"))
            {
                result = Sub(num1, num2);
            }
            else if (calculate.Equals("M"))
            {
                result = Mul(num1, num2);
            }
            else if (calculate.Equals("D"))
            {
                result = Div(num1, num2);
            }
            else
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Please Choose from the specified operations");
                Console.WriteLine("------------------------------------");
                Option();
                return;
            }
        }


        public void Display(float result)
        {
            Console.WriteLine("Your Result: {0}", result);
            Console.WriteLine("------------------------------------");
        }

        int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        int Sub(int num1, int num2)
        {
            return num1 - num2;
        }
        int Mul(int num1, int num2)
        {
            return num1 * num2;
        }
        int Div(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}
