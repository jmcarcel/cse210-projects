public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }
    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
         if (_isHidden)
        {
            char[] characters = _text.ToCharArray();

            // Replace each character with undescore
            for (int i = 0; i < characters.Length; i++)
            {
                characters[i] = '_';
            }

            return new string(characters);
        }
        else
        {
            return _text;
        }
    }
}