using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        //OPENFILE FUNC
        /*Console.WriteLine("Enter file path: ");
        string filePath = Console.ReadLine();

        try
        {
            OpenFile(filePath);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Something went wrong: {ex.Message}");
        }
        */

        //VALIDNUM FUNC
        try
        {
            int number = GetValidNumber();
            Console.WriteLine("The number entered is: " + number);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalud input");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Something went wrong: {ex.Message}");
        }

        Console.ReadLine();

    }

    // Open File from a user
    static void OpenFile(string filePath)
    {
        // Opening the file
        using (FileStream fs = File.Open(filePath, FileMode.Open))
        {
            Console.Write("File opened successfully.");
        }
    }

    // Integer 0-1000
    static int GetValidNumber()
    {
        Console.Write("Enter a valid number: ");
        string input = Console.ReadLine();
        int num = Convert.ToInt32(input);

        if (num < 0 || num > 1000)
        {
            throw new ArgumentOutOfRangeException("Must be between 0 and 1000");
        }

        return num;
    }


}