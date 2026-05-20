using System.Dynamic;

public class Word
{
    private string _text;
    private bool _isHidden;

    public void Hide()
    {
        _isHidden = false;
    }
    public void Show()
    {
        _isHidden = true;
    }

    public bool isHidden()
    {
        return _isHidden;
    }
    public string GetDisplayText()
    {
        return _text;
    }
}