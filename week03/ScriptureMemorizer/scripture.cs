public class Scripture
{
    private Reference _reference;
    private List<Word> _words = [];

    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;
        List<string> listwords = text.Split(' ').ToList();

        foreach (var word in listwords)
        {
            var myWord = new Word(word);
            _words.Add(myWord);
        }
    } //end constructor

    public void HideRandomWords(int numberToHide)
    {
        //loop a number of times equal to the param
        for (int i = 0; i < numberToHide; i++)
        {
            //grab only the word objects that are not hidden
            var candidates = _words.Where(x => !x.isHidden()).ToList();

            if (candidates.Count == 0)
            { return; }
            //get a random number based on the words not hidden 
            Random random = new Random();
            int randomIndex = random.Next(candidates.Count);
            //hide the object selected
            candidates[randomIndex].Hide();
        }
    } //end hide random words

    public string GetDisplayText()
    {
        string txtReference = _reference.GetDisplayText();
        string txtWords = "";
        //loop through all words in array to get the display text for all of the scripture
        foreach (var word in _words)
        {
            txtWords = $"{txtWords} {word.GetDisplayText()}";
        }

        string txtReturn = $"{txtReference}{txtWords}";

        return txtReturn;
    } //end get display text

    public bool isCompletelyHidden()
    {
        // initialize return variable
        var isHidden = false;
        //get word objects that are not hidden
        var candidates = _words.Where(x => !x.isHidden()).ToList();
        //if all words are hidden set return to true else return false
        if (candidates.Count == 0)
        { isHidden = true; }
        else { isHidden = false; }
        return isHidden;
    } // end is completely hidden

}