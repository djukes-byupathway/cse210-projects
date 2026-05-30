using System.Dynamic;
using System.Reflection.PortableExecutable;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string txtWord)
    {
        _text = txtWord;
        Show();
    }

    public void Hide()
    {
        _isHidden = true;
    }
    public void Show()
    {
        _isHidden = false;
    }

    public bool isHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        string txtReturn = "";
        if (isHidden())
        {
            foreach (char _char in _text)
            {
                txtReturn = $"{txtReturn}_";
            }
        }
        else
        {
            txtReturn = _text;
        }

        return txtReturn;
    }
}