namespace learning03;

public class Entry {
    public readonly string DELIMETER = "~";

    public string prompt;
    public string content;
    public string date;
}

/// //////////////////////////////////////////////////////////
 
public class EntryBetter {
    private readonly string DELIMETER = "~";

    private string _prompt;
    private string _content;
    private string _date;

    public EntryBetter(string prompt, string content) {
        _prompt = prompt;
        this._content = content;
        this._date = DateTime.Now.ToShortDateString();
    }

    public string Export() {
        return $"{_date}{DELIMETER}{_prompt}{DELIMETER}{_content}";
    }
}