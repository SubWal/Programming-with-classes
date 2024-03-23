using System.Collections.Concurrent;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;

public class Journal
{
    public List<Entry> Entries;

    public Journal()
    {
        Entries = new List<Entry>();
    }

    public Journal(string[] importString)
    {
        Entries = new List<Entry>();
        foreach (var _string in importString)
        {
            if (_string.Length >2){
            var Entry = new Entry(_string);
            Entries.Add(Entry);
            }
            else{
                break;
            }
        }

    }

    // public void AddEntry(string bestThing, string weekendPlan, String habit)
    // {
    //     var entry = new Entry(bestThing, weekendPlan, habit);
    //     Entries.Add(entry);
    // }

    public void AddEntry(Entry entry)
    {
        string[] _promts = ["What was the most intersting thing I did today? \n > ","What did I enjoyed doing the most today?\n > ","How much time did I spend time writing code today?\n > ","What was the most spritual part of my day today?\n > ","If I had one more chance to rewind the day today what other goals would I like to accomplish?\n > "];
    
    DateTime theCurrentTime = DateTime.Now;
    string dateText = $"Date: {theCurrentTime.ToShortDateString()}  >>>   ";
    
    Console.Write(_promts[0] );
        var thing = dateText + $"Prompt: {_promts[0] }" + Console.ReadLine();

    Console.Write(_promts[1]);
        var prompt = dateText + $"Prompt: {_promts[1]}" +   Console.ReadLine();

    Console.Write(_promts[2]);
        var response = dateText + $"Prompt: {_promts[2]}" + Console.ReadLine();
    
    Console.Write(_promts[3]);
        var emotion = dateText + $"Prompt: {_promts[3]}" + Console.ReadLine();


    Console.Write(_promts[4]);
        var today = dateText +$"Prompt: {_promts[4]}" +  Console.ReadLine();

        entry.SetEntry($"{thing}\n{prompt}\n{response}\n{emotion}\n{today}");

        Entries.Add(entry);
        
    

    }

    public void DisplayEntries()

    {
        if (Entries.Count == 0)
        {
            Console.WriteLine(" No entries in the journal");
            return;
        }
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        System.Console.WriteLine("\nEntry List\n" );
        // DateTime currentDateTime = DateTime.Now;
        // string dateText = currentDateTime.ToShortDateString();
        // System.Console.WriteLine("\nEntry List\n"+ currentDateTime);
        // DateTime theCurrentTime = DateTime.Now;
        // string dateText = theCurrentTime.ToShortDateString();
        foreach (var Entry in Entries)
        {
            Console.WriteLine(Entry.DisplayString() );
        }
        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey();
    }
       

    
   
//         AddEnpytry entry = new Entry();
//         entry.Name = 

//         System.Console.WriteLine("\n Press any key to continue...");
//         Console.ReadKey();
//             }

    public string[] Export()
    {
        var exportLines = new List<string>();
        foreach (var Entry in Entries)
        {
            exportLines.Add(Entry.Export());
        }
        return exportLines.ToArray();
    }
}