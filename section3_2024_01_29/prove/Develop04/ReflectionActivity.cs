public class ReflectionActivity : Activity
{

    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public ReflectionActivity() : base() {
         _Programme = "Reflecting";
         _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _prompts.Add("What emotions did you experience during this experience?");
        _prompts.Add("How did this experience shape your perspective on helping others or standing up for what's right?");
        _prompts.Add("Reflecting on this experience, what did you learn about yourself?");
        _questions.Add("How do you think this experience has impacted your perspective on kindness, empathy, or compassion?");
        _questions.Add("Were there any unexpected moments of joy or satisfaction during this experience?");
        _questions.Add("How did you feel immediately after the experience compared to now, looking back on it?");
        _questions.Add("How do you think this experience has influenced your future decisions or behaviors?");

     }

    public void Run(){
        DisplayStartingMessage();
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine();
        GetPrompt();
        DisplayPrompt();
        GetRandomQuestion();
        DisplayQuestions();
        DisplayEndingMessage();
    }


    public string GetPrompt(){
        Random randomNumber = new ();
        int index = randomNumber.Next(_prompts.Count);
        return _prompts[index];
    }
    public void DisplayPrompt(){
        Console.WriteLine($" ——— {GetPrompt()} ——— ");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
    }
    public string GetRandomQuestion(){
        Random randomNumber = new ();
        int index = randomNumber.Next(_questions.Count);
        return _questions[index];
    }
    public void DisplayQuestions(){
        Console.WriteLine("You may begin in: "); ShowCountDown(5);
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
        Console.Write($"> {GetRandomQuestion()} ");
            Console.ReadLine();
            
        }
    }
}
