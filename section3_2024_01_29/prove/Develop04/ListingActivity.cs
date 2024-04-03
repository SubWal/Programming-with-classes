using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;


using System;
using System.Runtime.CompilerServices;
public class Activity
{
    protected string _Programme;
    protected string _description;
    protected int _duration;
    
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.Write($@"
Welcome to the {_Programme} Activity.

{_description}

How long, in seconds, would you like for your session? ");
    }
    
    public void DisplayEndingMessage()
    {
        Console.Write($"Thank you for using our Mindfulness App.");
        Thread.Sleep(5000);
        Console.Clear();
    }
    
    public void ShowSpinner(int seconds)
    {
        List<string> animationString = new List<string>();

        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("–");
        animationString.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        int i = 0;

        if (seconds != 101)
        {
            Console.WriteLine("Get ready..."); 
        }
        while (DateTime.Now < endTime)
        {
            string s = animationString[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");
            i++;

        if (i >= animationString.Count)
        {
            i = 0;
        }
        }
        Console.WriteLine("");
    }

public void ShowBreath(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        int i = 0;
        Console.Write("()");
        while (DateTime.Now < endTime){
            Thread.Sleep(1000);
            Console.Write("\b )");
            i++;
        }
        Console.WriteLine("");
    }

public void ShowExhale(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        int i = 0;
        Console.Write("(     )"); 
        while (DateTime.Now < endTime){
            Thread.Sleep(1000);
            Console.Write("\b\b) \b");
            i++;
        }
        Console.WriteLine("");
    }


    public void ShowCountDown(int second)
    {
        for (int i = second; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    
    public Activity()
    {
        _Programme= "";
        _description = "";
        _duration = 0;
    }    
    public Activity(string Programme, string description, int duration)
    {
        _Programme = Programme;
        _description = description;
        _duration = duration;
    }
}
public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompt = new List<string>();
    public ListingActivity() : base() 
    {
        _Programme = "Reflecting";
        _description = " This activity will help you reflct on positive aspects of your life by asking you to list as many as you can in a certain area. ";
    }

    public void Run()
    {
        DisplayStartingMessage();
        _duration = int.Parse(Console.ReadLine());
        _prompt.Add("Can you recall a recent accomplishment that you're proud of?");
        _prompt.Add("How do you contribute positively to your community or social circle?");
        _prompt.Add("Who has been a source of inspiration for you lately?");
        _prompt.Add("How do you overcome challenges or obstacles in your life?");
        _prompt.Add("In what ways do you seek personal growth and development?");
        GetPrompt();
        DsiplayPrompt();
        ShowSpinner(5);
        GetList();
        DisplayEndingMessage();
    }

public string GetPrompt()
{
    Random randomNUmber = new();
    int index = randomNUmber.Next(_prompt.Count);
    return _prompt[index];
}

public void DsiplayPrompt()
{
    Console.WriteLine($"----  {GetPrompt()}  ----");
    Console.WriteLine();
    Console.WriteLine("When you have something in mind, press enter to continue.");
    Console.ReadLine();
}

public void GetList()
{
    _count = 0;
    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(_duration);
    while (DateTime.Now < endTime)

    {
        Console.Write(">");
        Console.ReadLine();
        _count++;
    }
    Console.WriteLine($"Awesome! you worte {_count} entries. ");
    Thread.Sleep(2000);
}














}
