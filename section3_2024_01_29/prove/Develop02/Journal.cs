public class Journal
{
    public List<Entry> entries;

    public Journal()
    {
        entries = new List<Entry>();
    }

    public Journal(string importString)
    {
        entries = new List<Entry>();
        foreach (var line in importString)
        {
            var Entry = new Entry(importString);
            entries.Add(Entry);
        }

    }

    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }

    public void Display()
    {

    }

    public string Export()
    {
        return "";
    }
}