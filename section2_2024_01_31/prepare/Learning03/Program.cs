namespace learning03;

using System;

class Program
{
    static void Main(string[] args)
    {
        var journal = new Journal();

        var entry = new Entry();
        entry.prompt = "prompt1";
        entry.date = DateTime.Now.ToShortDateString();
        entry.content = "This is the content1";
        journal.AddEntry(entry);

        entry = new Entry();
        entry.prompt = "prompt2";
        entry.date = DateTime.Now.ToShortDateString();
        entry.content = "This is the content2";
        journal.AddEntry(entry);

        var journalText = Export(journal);

        Console.Clear();
        System.Console.WriteLine("Journal Entries: \n=========================");
        System.Console.WriteLine(journalText);



        // A more encapsulated approach
        var journalBetter = new JournalBetter();

        journalBetter.AddEntry(new EntryBetter("prompt1", "This is the content1"));
        journalBetter.AddEntry(new EntryBetter("prompt2", "This is the content2"));

        var journalBetterText = journalBetter.Export();

        System.Console.WriteLine("journalBetter Entries: \n=========================");
        System.Console.WriteLine(journalBetterText);
    }

    static string Export(Journal journal) {
        string finalExport = "";
        foreach (var entry in journal.entries) {
            finalExport += $"{entry.date}{entry.DELIMETER}{entry.prompt}{entry.DELIMETER}{entry.content}" + "\n";
        }
        return finalExport;
    }
}
