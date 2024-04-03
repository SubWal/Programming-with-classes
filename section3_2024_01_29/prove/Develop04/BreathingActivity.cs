public class BreathingActivity : Activity{
    
public BreathingActivity() : base(){
     _Programme= "Breathing";
     _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
 }
    public void Run(){
        Console.Clear();
        Console.WriteLine("==========================================================================");
        DisplayStartingMessage();
        _duration = int.Parse(Console.ReadLine());
        
        Console.Clear();
        ShowSpinner(5);

        for (int i = 0; i < _duration; i += 10){
            Console.Write("Breathe in..."); 
            ShowBreath(5);
            Console.WriteLine("");

            Console.Write("Now breathe out..."); 
            ShowExhale(5);
            Console.WriteLine("\n");

        }
        DisplayEndingMessage();
    }
}