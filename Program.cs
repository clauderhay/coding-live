using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        //OPENFILE FUNC
        Console.WriteLine("Enter file path: ");
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

        Console.ReadLine();
     
    }

    // Open File from a user
    static void OpenFile( string filePath)
    {
        // Opening the file
        using (FileStream fs = File.Open(filePath, FileMode.Open))
        {
            Console.Write("File opened successfully.");
        }
    }

}