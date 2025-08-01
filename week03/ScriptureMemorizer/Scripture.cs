public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>()
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