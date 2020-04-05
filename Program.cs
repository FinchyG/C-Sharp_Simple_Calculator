using System;

namespace Simple_Calculator
{
    abstract class Arithmatic
    {
        public int Adder(int x, int y)
        {
            return x + y;
        }
        public int Subtracter(int x, int y)
        {
            return x - y;
        }
        public int Multiplier(int x, int y)
        {
            return x * y;
        }
        public int Divider(int x, int y)
        {
            return x / y;
        }
    }

    class Addition : Arithmatic
    {
        public string AnswerStatement()
        {
            return "The sum of the two numbers is:";
        }

    }

    class Subtraction : Arithmatic
    {
        public string AnswerStatement()
        {
            return "The difference of the two numbers is:";
        }

    }

    class Multiplication : Arithmatic
    {
        public string AnswerStatement()
        {
            return "The product of the two numbers is:";
        }

    }

    class Division : Arithmatic
    {
        public string AnswerStatement()
        {
            return "The quotient of the two numbers is:";
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Addition add = new Addition();
            Subtraction subtract = new Subtraction();
            Multiplication multiply = new Multiplication();
            Division divide = new Division();

            Console.WriteLine("{0} {1}", add.AnswerStatement(),add.Adder(5,5));
            Console.WriteLine("{0} {1}", subtract.AnswerStatement(), subtract.Subtracter(5, 5));
            Console.WriteLine("{0} {1}", multiply.AnswerStatement(), multiply.Multiplier(5, 5));
            Console.WriteLine("{0} {1}", divide.AnswerStatement(), divide.Divider(5, 5));
        }
    }
}
