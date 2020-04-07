using System;

namespace Simple_Calculator
{
    abstract class Arithmatic
    {
        public string AnswerStatement(string resultName)
        {
            return $"The {resultName} of the two numbers is:";
        }                
    }

    class Addition : Arithmatic
    {
        public int Adder(int x, int y)
        {
            return x + y;
        }

    }

    class Subtraction : Arithmatic
    {
        public int Subtracter(int x, int y)
        {
            return x - y;
        }
        
    }

    class Multiplication : Arithmatic
    {
        public int Multiplier(int x, int y)
        {
            return x * y;
        }
       
    }

    class Division : Arithmatic
    {
        public int Divider(int x, int y)
        {
            return x / y;
        }
        
    }

    class UserInput : Arithmatic
    {
        public int num1;
        public int num2;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Addition add = new Addition();
            Subtraction subtract = new Subtraction();
            Multiplication multiply = new Multiplication();
            Division divide = new Division();
            UserInput usip = new UserInput();

            Console.WriteLine("Welcome to Simple Calculator.");

            Console.WriteLine("Please input your first whole number:");
            usip.num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please input your second whole number:");
            usip.num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} {1}", add.AnswerStatement("sum"),add.Adder(usip.num1, usip.num2));
            Console.WriteLine("{0} {1}", subtract.AnswerStatement("difference"), subtract.Subtracter(usip.num1, usip.num2));
            Console.WriteLine("{0} {1}", multiply.AnswerStatement("product"), multiply.Multiplier(usip.num1, usip.num2));
            Console.WriteLine("{0} {1}", divide.AnswerStatement("quotient"), divide.Divider(usip.num1, usip.num2));
        }
    }
}
