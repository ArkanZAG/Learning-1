namespace Learning_1;

public class FirstTask
{
    private string firstLetter;
    private string secondLetter;
    private string thirdLetter;
    
    public void LetterInput()
    {
        Console.WriteLine("Input The First Letter : ");
        firstLetter = Console.ReadLine();
        Console.WriteLine("Input The Second Letter : ");
        secondLetter = Console.ReadLine();
        Console.WriteLine("Input The Third Letter : ");
        thirdLetter = Console.ReadLine();
    
        Console.WriteLine(thirdLetter + secondLetter + firstLetter);
    }
}