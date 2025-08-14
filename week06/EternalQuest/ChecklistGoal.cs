public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string names, string description, string points, int target, int bonus) : base(names, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public void SetAmountCompleted(int amountCompleted)
    {
        _amountCompleted = amountCompleted;
    }
    public override void RecordEvent()
    {
        _amountCompleted++;
    }
    public override int GetPoints()
    {
        if (IsComplete())
        {
            return int.Parse(_points) + _bonus;
        }
        return int.Parse(_points);
    }
    public override bool IsComplete()
    {
        return (_amountCompleted >= _target);
    }
    public override string GetDetailsString() 
    {
        string isComplete = IsComplete() ? "X" : " ";
        return $"[{isComplete}] {_shortName} ({_description}) -- Currently completed. {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation() 
    { 
        return $"ChecklistGoal:{_shortName},{_description},{_points},{_bonus},{_target},{_amountCompleted}";
    }

}