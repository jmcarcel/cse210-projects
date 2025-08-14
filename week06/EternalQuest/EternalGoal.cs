public class EternalGoal : Goal
{
    public EternalGoal(string names, string description, string points) : base(names, description, points)
    { }

    public override void RecordEvent()
    {
    }
    public override bool IsComplete()
    {
        return true;
    }
    public override string GetDetailsString()
    {
        return $"[ ] {_shortName} ({_description})";
    }

    public override string GetStringRepresentation()
    {
        return $"Eternal Goal: {_shortName}, {_description}, {_points}";
    }
}