using Microsoft.VisualBasic;

public class Entry
{
    public string response;
    public string prompt;
    public string date;

    public Entry(string response, string prompt)
    {
        this.response = response;
        this.prompt = prompt;
    }


    public Entry(string import)
    {
        var parts = import.Split("|");
        this.response = parts[0];
        this.prompt = parts[0];

    } 

    public string Export()
    {
        return $"{response} {prompt}";
    }

    public string DisplayString()
    {
        return $"{response} {prompt}";
    }

  
}