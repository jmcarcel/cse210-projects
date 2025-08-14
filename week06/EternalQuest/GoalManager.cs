
public class GoalManager
{
    public List<Goal> _goals = new List<Goal>();
    public int _score = 0;

    public GoalManager()
    {
        
    }

    public void Start()
    {
        do
        {
            DisplayPlayerInfo();
        }
        while (true);
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine();
        Console.WriteLine($"You have {_score} points.");
        Console.WriteLine();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");

        Console.Write("Select a choice from a menu: ");
        string userSelection = Console.ReadLine();
        int choice = Convert.ToInt32(userSelection);

        if (choice == 1)
        {
            CreateGoal();
            DisplayPlayerInfo();
        }
        if (choice == 2)
        {
            ListGoalDetails();
        }
        if (choice == 3)
        {
            SaveGoals();
        }
        if (choice == 4)
        {
            LoadGoals();
        }
        if (choice == 5)
        {
            ListGoalNames();
            RecordEvent();
            DisplayPlayerInfo();
        }
        if (choice == 6)
        {
            Environment.Exit(0);
        }
        if (choice < 1 || choice > 6)
        {
            Console.WriteLine("Invalid option. Please try again");
        }
    }

    public void ListGoalNames()
    {
        Console.WriteLine("The goals are:");
        int i = 0;
        foreach (var goal in _goals)
        {
            i++;
            Console.WriteLine($"{i}. {goal.GetName()}");
        }
    }
    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");
        int i = 0;
        foreach (var goal in _goals)
        {
            i++;
            Console.WriteLine($"{i}. {goal.GetDetailsString()}");
        }
        Console.WriteLine();
    }

    public void CreateGoal()
    {
        Console.WriteLine("The type of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.Write("Wich type of goal would you like to create? ");
        string userSelection = Console.ReadLine();
        int type = Convert.ToInt32(userSelection);

        Console.Write("What is the name of your goal? ");
        string goalName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string goalDescription = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        string goalPoints = Console.ReadLine();

        if (type == 1)
        {
            var simpleGoal = new SimpleGoal(goalName, goalDescription, goalPoints);
            _goals.Add(simpleGoal);
        }
        else if (type == 2)
        {
            var eternalGoal = new EternalGoal(goalName, goalDescription, goalPoints);
            _goals.Add(eternalGoal);
        }
        else if (type == 3)
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            string goalTarget = Console.ReadLine();
            Console.Write("What is the bonus for accomplishing it that many times? ");
            string goalBonus = Console.ReadLine();
            var checklistGoal = new ChecklistGoal(goalName, goalDescription, goalPoints, Convert.ToInt32(goalTarget), Convert.ToInt32(goalBonus));
            _goals.Add(checklistGoal);
        }
        else if (type < 1 || type > 3)
        {
            Console.WriteLine("Invalid option. Please try again.");
        }
    }
    public void RecordEvent()
    {
        Console.Write("Wich goal did you accomplish? ");
        string option = Console.ReadLine();
        int index = Convert.ToInt32(option) - 1;

        var goal = _goals[index];
        goal.RecordEvent();
        int points = goal.GetPoints();
        Console.WriteLine($"Congratulations! You have earned {points} points!");
        _score = _score + points;
        Console.WriteLine($"You now have {_score} points.");
        Console.WriteLine();
    }
    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }
    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
            string fileName = Console.ReadLine();
            string[] lines = File.ReadAllLines(fileName);
            _score = int.Parse(lines[0]);
            _goals = new List<Goal>();
            string[] goalList = lines.Skip(1).ToArray();
        foreach (string goalLine in goalList)
        {
            string[] goal = goalLine.Split(":");
            string type = goal[0];
            string[] values = goal[1].Split(",");
            if (type == "SimpleGoal")
            {
                SimpleGoal simpleGoal = new SimpleGoal(values[0], values[1], values[2]);
                simpleGoal.SetIsComplete(bool.Parse(values[3]));
                _goals.Add(simpleGoal);
            }
            else if (type == "EternalGoal")
            {
                _goals.Add(new EternalGoal(values[0], values[1], values[2]));
            }
            else if (type == "ChecklistGoal")
            {
                ChecklistGoal checklistGoal = new ChecklistGoal(values[0], values[1], values[2], int.Parse(values[4]), int.Parse(values[3]));
                checklistGoal.SetAmountCompleted(int.Parse(values[4]));
                _goals.Add(checklistGoal);
            };
            
        }
    }
}