public class Activity
{
    // attributes
    private string _name;
    private string _description;
    private int _duration;

    //behavior or methods     
    public void DisplayStartingMessage()
    {

    }
    public void DisplayEndingMessage()
    {

    }
    public void ShowSpinner(int seconds)
    {

    }
    public void ShowCountDown(int second)
    {

    }


//public getter setter methods for properties
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public string Description
    {
        get { return _description; }
        set { _description = value; }
    }
    public int Duration
    {
        get { return _duration; }
        set { _duration = value; }
    }


}