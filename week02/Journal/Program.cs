using System;

class Program
{
    static void Main(string[] args)
    {
         string userEntry;
        int option = 0;
        Journal theJournal = new Journal();
        string filename = "";
        Console.WriteLine("Welcome to the journal program!");
        do
        {    
            Console.WriteLine("Please select one of the following options:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            userEntry = Console.ReadLine();
            option = Convert.ToInt32(userEntry);

            if (option == 1)
            { 
                PromptGenerator newPrompt = new PromptGenerator();
                string prompt = newPrompt.GetRandomPrompt();
                Console.WriteLine(prompt);
                Console.Write("> ");
                string response = Console.ReadLine();
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();

                Entry newEntry = new Entry();
                newEntry._date = dateText;
                newEntry._promptText = prompt;
                newEntry._entryText = response;

                theJournal.AddEntry(newEntry);  
            } 
            if (option == 2)
            {
                theJournal.DisplayAllEntries();
            }
            if (option == 3)
            {
                Console.WriteLine("Enter the filename to load from:");
                filename = Console.ReadLine();
                theJournal.LoadFromFile(filename);
            }
            if (option == 4)
            {
                Console.WriteLine("Enter the filename to save to:");
                filename = Console.ReadLine();
                theJournal.SaveToFile(filename);
            }  
            if (option == 5)
            {
                Console.WriteLine("Have a nice day. Come soon!");
                Environment.Exit(0);
            }
            if (option < 1 || option > 5)
            {
                Console.WriteLine("Invalid option. Please try again.");
            }
        } while (true);
    }
}