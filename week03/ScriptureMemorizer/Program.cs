using System;

class Program
{
    static void Main(string[] args)
    {
        // Create scripture with reference and text
        Reference reference = new Reference("John", 3, 16);
        string text = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
        Scripture scripture = new Scripture(reference, text);

        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        Console.WriteLine();

        // Display complete scripture
        Console.WriteLine(scripture.GetDisplayText());

        Console.WriteLine();

        while (!scripture.IsCompletelyHidden())
        {
            Console.WriteLine("Press enter to continue or type 'quit' to finish the program.");
            string userinput = Console.ReadLine();
            if (userinput.ToLower() == "quit")
            {
                break;
            }
            scripture.HideRandomsWords(3);
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText()); 
        }
    }
}