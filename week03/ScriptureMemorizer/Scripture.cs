public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        foreach (string word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }
    public void HideRandomsWords(int numberToHide)
    {
        foreach (Word word in _words)
        {
            if (numberToHide <= 0) break;
            if (!word.IsHidden() && new Random().Next(2) == 0) 
            {
                word.Hide();
                numberToHide--;
            }
        }
    }
    public string GetDisplayText()
    {
        return $"{_reference.GetDisplayText()} {string.Join(" ", _words.Select(w => w.GetDisplayText()))}";
    }
    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }
}