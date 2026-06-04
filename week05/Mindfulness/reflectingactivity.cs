public class ReflectingActivity : Activity
{
    //attributes or properties
    private List<string> _prompts;
    private List<string> _questions;

    //constructor
    public ReflectingActivity()
    {
        Name = "Reflecting";
        Description = "This activity will help you reflect on times...";
        Duration = 50;

    }


    //behavior or methods
    public void Run()
    {


    }

    public string GetRandomPrompt()
    {
        return "random prompt";
    }

    public string GetRandomQuestion()
    {
        return "Random Question";
    }

    public void DisplayPrompt()
    {

    }
    public void DisplayQuestions()
    {

    }

}