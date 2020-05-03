using System;
using Arithmatic;

namespace Simple_Calculator
{
    class Addition : Arithmatic.Arithmatic
    {
        public decimal Adder(decimal x, decimal y)
        {
            return x + y;
        }
    }

    class Subtraction : Arithmatic.Arithmatic
    {
        public decimal Subtracter(decimal x, decimal y)
        {
            return x - y;
        }
     }

    class Multiplication : Arithmatic.Arithmatic
    {
        public decimal Multiplier(decimal x, decimal y)
        {
            return x * y;
        }
    }

    class Division : Arithmatic.Arithmatic
    {
        public decimal Divider(decimal x, decimal y)
        {
            return Math.Round(x / y,2);
        }
    }

    class UserInput : Arithmatic.Arithmatic
    {
        public string calculationChoice;
        public string validatedCalculationChoice;
        public string userNumStr;
        public decimal userNumdecimal;
        public decimal num1;
        public decimal num2;

        public decimal NumberValidator(string userString)
        {
            while (!decimal.TryParse(userString, out decimal x))
            {
                Console.WriteLine("You must input a whole number:");
                userString = Console.ReadLine();
            }

            return userNumdecimal = Convert.ToDecimal(userString);
        }

        public string ChoiceValidator(string choice)
        {
            while (!(choice == "a" | choice == "s" | choice == "m" | choice == "d"))
            {
                Console.WriteLine("You must choose either add(a), subtract(s), multiply(m) or divide(d):");
                choice = Console.ReadLine();
            }

            return validatedCalculationChoice = choice;
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
            UserInput usip = new UserInput();

            Console.WriteLine("Welcome to Simple Calculator.");

            bool endProgram = false;

            while(!endProgram)
            {
                Console.WriteLine("Do you want to add(a), subtract(s), multiply(m) or divide(d)?");
                usip.calculationChoice = Console.ReadLine();
                usip.validatedCalculationChoice = usip.ChoiceValidator(usip.calculationChoice);
                Console.WriteLine(usip.validatedCalculationChoice);

                Console.WriteLine("Please input your first whole number:");
                usip.userNumStr = Console.ReadLine();
                usip.num1 = usip.NumberValidator(usip.userNumStr);

                Console.WriteLine("Please input your second whole number:");
                usip.userNumStr = Console.ReadLine();
                usip.num2 = usip.NumberValidator(usip.userNumStr);

                switch (usip.validatedCalculationChoice)
                {
                    case "a":
                        Console.WriteLine("{0} {1}", add.AnswerStatement("sum"), add.Adder(usip.num1, usip.num2));
                        break;
                    case "s":
                        Console.WriteLine("{0} {1}", subtract.AnswerStatement("difference"), subtract.Subtracter(usip.num1, usip.num2));
                        break;
                    case "m":
                        Console.WriteLine("{0} {1}", multiply.AnswerStatement("product"), multiply.Multiplier(usip.num1, usip.num2));
                        break;
                    case "d":
                        Console.WriteLine("{0} {1}", divide.AnswerStatement("quotient (rounded to two decimal places"),
                                            divide.Divider(usip.num1, usip.num2));
                        break;
                }

                Console.WriteLine("Press q to quit program or any other key to do another calculation:");
                string keyPress = Console.ReadLine();

                if(keyPress == "q")
                {
                    endProgram = true;
                }
            }
        }
    }
}
