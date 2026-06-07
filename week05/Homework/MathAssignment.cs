public class MathAssignment : Assignment
{
    // attributes
    private string _textBookSection;
    private string _problems;

    public MathAssignment(string name, string topic, string section, string problems): base( name,  topic)
    {
        _textBookSection = section;
        _problems = problems;
    }
    
    public string GetHomeworkList()
    {
        return $"Section {_textBookSection} Problems {_problems}";
    }
}