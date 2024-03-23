using Microsoft.VisualBasic;

public class Entry
{
    public string response;
    public string prompt;
    public string emotion;
    public string thing;
    public string today;

    public Entry(string response, string prompt, string thing, string emotion, string today)
    {
        this.response = response;
        this.prompt = prompt;
        this.thing = thing;
        this.emotion = emotion;
        this.today = today;
    }

    public Entry(string import){
        var parts = import.Split("\n");
        this.thing = parts[0];
        this.prompt = parts[1]; 
        this.response =  parts[2];
        this.emotion =  parts[3];
        this.today = parts[4];
        
    }


    public void SetEntry(string import)
    {
        var parts = import.Split("\n");
        this.thing = parts[0] + parts[1];
        this.prompt = parts[2] +parts[3];
        this.response =  parts[4] +parts[5];
        this.emotion =  parts[6] + parts[7];
        this.today = parts[8] +parts[9];
    } 


    public string Export()
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        return  $" {thing}\n{prompt}\n{response}\n{emotion}\n{today} |";
    }

    public string DisplayString()
    {
        return $"{thing}\n{prompt}\n{response}\n{emotion}\n{today}\n |";
    }

  
}