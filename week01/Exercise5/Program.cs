using System;

class Program
{
    static void Main(string[] args)
    {
         DisplayWelcome();
        string name = PromptUserName("");
        int number = PromptUserNumber(0);
        int square = SquareNumber(number);
        DisplayResult(name, square);
    }
        static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName(string name)
        {
            Console.Write($"Please enter your name: ");
            string username = Console.ReadLine();
            return username;
        }
        static int PromptUserNumber(int number)
        {
            Console.Write($"Please enter your favorite number: ");
            number = int.Parse(Console.ReadLine());
            return number;
        }
        static int SquareNumber(int number)
        {
            int SquareN = number * number;
            return SquareN;
        }
        static void DisplayResult(string name, int number)
        {
            Console.WriteLine($"{name}, the square of your number is: {number}");
        }
    // 
}