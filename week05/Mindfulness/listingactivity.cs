public class ListingActivity : Activity
{
    //attributes
    private int _count;
    private List<string> _prompts;


    //constructor
    public ListingActivity()
    {
        Name = "Listing";
        Description = "This activity will ...";
        Duration = 50;

    }

    //behaviors or methods
    public void Run()
    {

    }

    public string GetRandomPrompt()
    {
        return "some string";
    }

    public List<string> GetListFromUser()
    {
        return _prompts; //note this is not the final returned value
    }
}
