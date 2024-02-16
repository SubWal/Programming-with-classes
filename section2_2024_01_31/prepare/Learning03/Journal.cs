namespace learning03;

public class Journal {
    public List<Entry> entries = new List<Entry>();

    public void AddEntry(Entry entry) {
        entries.Add(entry);
    }
}

/// //////////////////////////////////////////////////////////
 
public class JournalBetter {
    private List<EntryBetter> _entries = new List<EntryBetter>();

    public void AddEntry(EntryBetter entry) {
        _entries.Add(entry);
    }

    public string Export() {
        string finalExport = "";
        foreach (var entry in _entries) {
            finalExport += entry.Export() + "\n";
        }
        return finalExport;
    }
}