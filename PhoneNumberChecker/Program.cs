using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a cell phone number:");
        string phoneNumber = Console.ReadLine();

        if (IsValidCellPhoneNumber(phoneNumber))
        {
            Console.WriteLine("Valid cell phone number.");
        }
        else
        {
            Console.WriteLine("Invalid cell phone number.");
        }
    }

    static bool IsValidCellPhoneNumber(string phoneNumber)
    {
        // Remove any non-numeric characters
        phoneNumber = new string(phoneNumber.Where(char.IsDigit).ToArray());

        // Check if the length is valid (excluding country code)
        if (phoneNumber.Length != 10)
            return false;

        // Check if the first digit is a valid country code 
        if (!phoneNumber.StartsWith("0"))
            return false;

        // If all conditions are met, return true
        return true;
    }
}
