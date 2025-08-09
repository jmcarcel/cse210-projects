
public class Comment
{
    public string _person = "";
    public string _textComment = "";

    public Comment(string person, string textcomment)
    {
        _person = person;
        _textComment = textcomment;
    }
    public void DisplayComment()
    {
        Console.WriteLine($"{_person}: {_textComment}");
        Console.WriteLine();
    }
}