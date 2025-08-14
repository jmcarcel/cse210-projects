public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected string _points;

    public Goal(string names, string description, string points)
    {
        _shortName = names;
        _description = description;
        _points = points;
    }
    public string GetName()
    {
        return _shortName;
    }
    public virtual int GetPoints()
    {
        return int.Parse(_points);
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailsString()
    {
        string isComplete = IsComplete() ? "X" : " ";
        return $"[{isComplete}] {_shortName}({_description})";
    }
    public abstract string GetStringRepresentation();
}