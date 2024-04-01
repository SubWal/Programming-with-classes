
using System;

using System.Diagnostics.CodeAnalysis;
using System.IO.Compression;
using System.Runtime.CompilerServices;

class Word{
    private string _text;
    private bool _isHidden;
    

    public Word(string text)
    {
        _text = text;
        _isHidden = IsHidden();
    }


public void Hide()
{
    if (!IsHidden())
    {
        _text = new string('_', _text.Length);

    }
}

public void Show()
{
    Console.Write($"{_text}");
}

public bool IsHidden()
{
    if (_text.Contains("_"))
    {
        return true;

    }
    else{
        return false;
    }
}

public string GetDisplayText()
{
    return _text;
}

}

class Program
{
    static void Main(string[] args)
    {

    
        Reference reference1 = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture1 = new Scripture(reference1, " In all thy ways acknowledge him, and he shall direct thy paths.");

        Reference reference2 = new Reference("1Nephi", 2, 2, 4);
        Scripture scripture2 = new Scripture(reference2, @"
   And it came to pass that the Lord commanded my father, even in a dream, that he should take his family and depart into the wilderness.
 And it came to pass that he was obedient unto the word of the Lord, wherefore he did as the Lord commanded him.

And it came to pass that he departed into the wilderness. And he left his house, and the land of his inheritance, and his gold, and his silver, and his precious things, and took nothing with him, save it were his family, and provisions, and tents, and departed into the wilderness.
");
   
    Console.WriteLine("--------------------------------------------------------------------------");
    Console.WriteLine("Welcome to the Scripture memorizing programme. Press Enter to continue and 'quit' to exit. \n Have Fun!" );


   
        while (Console.ReadLine() != "quit"){
            Console.Clear();
            Console.WriteLine("Press enter to continue or type 'quit' to finish: \n");
            Console.Write($"{reference2.GetDisplayText()} ");
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine(scripture2.GetDisplayText());
            scripture2.IsCompletelyHidden();
            scripture2.HideRandomWords(3);
        }
        
    Console.WriteLine("----------------------------------------------------------------------");

    }

}