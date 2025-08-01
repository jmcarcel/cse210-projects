public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }
    public void HideRandomsWords(int numberToHide)
    {

    }
    public string GetDisplayText()
    {
        
    }
    public bool IsCompletelyHidden()
    {
        return _words;
    }
}