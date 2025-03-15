using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade porcentage? ");
        double grade = double.Parse(Console.ReadLine());
        string letter = "";
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine($"You got a {letter}");
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations, you passed!");
        }
        if (grade < 70)
        {
            Console.WriteLine("Sorry. The best for next time!.");
        }
    }
}