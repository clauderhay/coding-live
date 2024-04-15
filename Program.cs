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
        /*try
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
        }*/

        /*int[] numbers = { 2, 4, 6, 8 };
        double average = CalculateAverage(numbers);
        Console.WriteLine("Average is: " + average);

        int[] newArray = new int[0];
        try
        {
            double newArrayAverage = CalculateAverage(newArray);
            Console.WriteLine("Average of new array: " + newArrayAverage);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }*/

        /*Console.WriteLine("Enger a number: ");
        string input = Console.ReadLine();

        int result = ConvertStringToInt(input);
        if(result != int.MinValue)
        {
            Console.WriteLine("Converted successfully: " + result);
        }
        else
        {
            Console.WriteLine("Failed. Enter a valid int");
        }*/

        /*List<int> numbers = ReadIntegers();

        Console.WriteLine("Entered numbers: ");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }*/

        Console.WriteLine("Enter numerator: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter denominator: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int result = DivideNumbers(num1, num2);
        Console.WriteLine("Result of division: " + result);


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

    // Average of array
    static double CalculateAverage(int[] numbers)
    {
        if (numbers.Length == 0)
        {
            throw new ArgumentException("Array is empty.");
        }

        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        return (double)sum / numbers.Length;
    }

    // String to Int
    static int ConvertStringToInt(string input)
    {
        try
        {
            return int.Parse(input);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid. Enter a valid integer.");
        }

        return int.MinValue;
    }

    // List of int
    static List<int> ReadIntegers()
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter integers (type 'end' when done): ");

        while (true)
        {
            
            string input = Console.ReadLine();

            if (input.ToLower() == "end")
                break;

            try
            {
                int num = Convert.ToInt32(input);
                numbers.Add(num);
            }
            catch (Exception)
            {
                Console.WriteLine("Error! Invalid input.");
            }
        }

        return numbers;
    }

    // Divide two Numbers
    static int DivideNumbers(int num1, int num2)
    {
        if (num2 == 0)
        {
            throw new DivideByZeroException();
        }
        return num1 / num2;
    }


}