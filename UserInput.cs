using System;
using Arithmatic;

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