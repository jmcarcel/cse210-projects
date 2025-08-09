
public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public static List<Comment> _comments = new List<Comment>();

    public Video()
    {
       
    }

    public int GetCommentsCount()
    {
        return _comments.Count;
    }
    public void AddComments(string person, string textcomment)
    {
        Comment newcomment = new Comment(person, textcomment);
        _comments.Add(newcomment);
    }
    public void DisplayVideo()
    {
        Console.WriteLine($"Title: {_title}\nAuthor: {_author}\nLength: {_length}secs");
        Console.WriteLine($"Number of comments: {GetCommentsCount()}");

        int count = 1;
        foreach (Comment comment in _comments)
        {
            System.Console.WriteLine($"Comments #{count}");
            comment.DisplayComment();
            count++;
        }
    }
  
}