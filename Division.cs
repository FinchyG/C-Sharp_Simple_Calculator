using System;
using Arithmatic;

class Division : Arithmatic.Arithmatic
{
    public decimal Divider(decimal x, decimal y)
    {
        return Math.Round(x / y, 2);
    }
}