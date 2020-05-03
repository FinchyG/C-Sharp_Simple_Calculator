using System;
using Arithmatic;

class UserInput : Arithmatic.Arithmatic
{
    public string calculationChoice { get; set; }
    public string validatedCalculationChoice { get; set; }
    public string userNumStr { get; set; }
    public decimal userNumdecimal { get; set; }
    public decimal num1 { get; set; }
    public decimal num2 { get; set; }

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
        choice = choice.ToLower();

        while (!(choice == "a" | choice == "s" | choice == "m" | choice == "d"))
        {
            Console.WriteLine("You must choose either add(a), subtract(s), multiply(m) or divide(d):");
            choice = Console.ReadLine();
        }

        return validatedCalculationChoice = choice;
    }
}