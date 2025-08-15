using System.Reflection.Metadata.Ecma335;

public class Square : Shape
{
    private double _side;
    public Square(string color, double side) : base(color)
    {
        _side = side;
    }
    public override double GetArea()
    {
        double side = _side * 2; 
        return side;
    }
}