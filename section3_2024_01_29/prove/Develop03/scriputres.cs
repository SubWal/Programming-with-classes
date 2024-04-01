using System.Reflection;

class Scripture{
    private Reference _reference;
     private List<Word> _words = new List<Word>(); 
    public Scripture(Reference reference, string text){
        List<string> wordArray = text.Split(" ").ToList();
        foreach (string word in wordArray){
            _words.Add(new Word(word));
        }
        _reference = reference;
    }



    public void HideRandomWords(int numberToHide)
    {
        Random randomNumber = new();
        int index = randomNumber.Next(_words.Count);
        for (int i = 0; i < numberToHide; i ++)
        {
            index = randomNumber.Next(_words.Count);
            _words[index].Hide();
        }
    }

    public string GetDisplayText()
    {
        string mainString = " ";
        foreach (Word item in _words)
        {
            mainString += item.GetDisplayText();
            mainString += " ";
        }
        return mainString;
    }

    public bool IsCompletelyHidden(){

        foreach (Word item in _words)
        {
            bool itemHidden = item.IsHidden();
            if (itemHidden == false)
            {
                return false;
            }
        }
            System.Environment.Exit(1);
            Console.WriteLine("Goodbye....");
            return true;
        


    }
}

