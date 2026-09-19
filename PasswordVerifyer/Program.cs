using System;
using System.Text.RegularExpressions;

class PasswordChecker
{
    public static void Main(string[] args)
    {
        string input;
        string pattern = @"[A-Z]\w+\d+@";

        Console.WriteLine("Please enter your password for verification checks");
        input = Console.ReadLine();

        Match match = Regex.Match(input, pattern);

        if (match.Success)
        {
            Console.WriteLine("Your password has passed the verification");
        }
        else
        {
            Console.WriteLine("Please ensure your password contains a number, one Uppercase letter and a special character");
        }
    }
}