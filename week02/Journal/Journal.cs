using System.Dynamic;
using System.IO;

public class Journal
{
       public List<Entry> _entries = new List<Entry>();
    string fileName = "myfilename.txt";

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        Console.WriteLine();
        Console.WriteLine("Journal Display");
        Console.WriteLine();
        
        foreach (Entry ent in _entries)
        {
            ent.Display();
        }

    }
    public void SaveToFile(string file)
    {
        // code here 
    }
    public void LoadFromFile()
    {
        // code goes here :)
    }

}