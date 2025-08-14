public class SimpleGoal : Goal
{
    private bool _isComplete = false;

    public SimpleGoal(string names, string description, string points) : base(names, description, points)
    { }

    public override void RecordEvent()
    {
        _isComplete = true;
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public void SetIsComplete(bool isComplete)
    {
        _isComplete = isComplete;
    }
    public override string GetStringRepresentation()
    {
        return $"Simple goal: {_shortName}, {_description}, {_points}, {_isComplete}";
    }
}