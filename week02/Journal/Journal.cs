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
    public void SaveToFile(string fileName)
    {
        // code here 

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry ent in _entries)
            {
                string fileLine = $"{ent._date}~|~{ent._promptText}~|~{ent._entryText};";
                outputFile.WriteLine(fileLine);
            }
            
        }

    }
    public void LoadFromFile(string fileName)
    {
        // first clear out the list by creating a new one and pointing it to that
        _entries = new List<Entry>();

        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            Entry newEnt = new Entry();
            string[] parts = line.Split("~|~");

            newEnt._date = parts[0];
            newEnt._promptText = parts[1];
            newEnt._entryText = parts[2];

            AddEntry(newEnt);
        }
    }

}