﻿using System;

namespace Simple_Calculator
{
    abstract class Arithmatic
    {
                
    }

    class Addition : Arithmatic
    {
        public int Adder(int x, int y)
        {
            return x + y;
        }
        public string AnswerStatement()
        {
            return "The sum of the two numbers is:";
        }

    }

    class Subtraction : Arithmatic
    {
        public int Subtracter(int x, int y)
        {
            return x - y;
        }
        public string AnswerStatement()
        {
            return "The difference of the two numbers is:";
        }

    }

    class Multiplication : Arithmatic
    {
        public int Multiplier(int x, int y)
        {
            return x * y;
        }
        public string AnswerStatement()
        {
            return "The product of the two numbers is:";
        }

    }

    class Division : Arithmatic
    {
        public int Divider(int x, int y)
        {
            return x / y;
        }
        public string AnswerStatement()
        {
            return "The quotient of the two numbers is:";
        }

    }

    class UserInput : Arithmatic
    {
        int num1;
        int num2;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Addition add = new Addition();
            Subtraction subtract = new Subtraction();
            Multiplication multiply = new Multiplication();
            Division divide = new Division();

            Console.WriteLine("Welcome to Simple Calculator.");


            Console.WriteLine("{0} {1}", add.AnswerStatement(),add.Adder(5,5));
            Console.WriteLine("{0} {1}", subtract.AnswerStatement(), subtract.Subtracter(5, 5));
            Console.WriteLine("{0} {1}", multiply.AnswerStatement(), multiply.Multiplier(5, 5));
            Console.WriteLine("{0} {1}", divide.AnswerStatement(), divide.Divider(5, 5));
        }
    }
}
