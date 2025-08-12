using System;
using Mindfulness;
using Microsoft.VisualBasic.FileIO;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        Console.WriteLine();
        int option = 0;
        do
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine();
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine();
            Console.Write("Select a choice from the menu: ");

            string userInput = Console.ReadLine();
            option = Convert.ToInt32(userInput);

            if (option == 1)
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
            }
            if (option == 2)
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.Run();
            }
            if (option == 3)
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();
            }
            if (option == 4)
            {
                Environment.Exit(0);
            }
            if (option < 1 || option > 4)
            {
                Console.WriteLine("Invalid option. Please try again.");
            }
        } while (true);
    }
}