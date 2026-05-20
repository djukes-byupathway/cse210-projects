public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    Scripture(Reference Reference, string text)
    {
        _reference = Reference;
        List<string> listwords = text.Split(' ').ToList();

        foreach (var word in listwords)
        {
            job.Display();
        }

    public void HideRandomWOrds(int numberToHide)
    {
        
    }
    public string GetDisplayText()
    {
        string txtReference = _reference.GetDisplayText();

        return txtReference;
    }

    public bool isCompletelyHidden()
    {
        bool isHidden = false;

        return isHidden;
    }

}