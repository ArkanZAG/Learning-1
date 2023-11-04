namespace Learning_1;

public class ThirdTask
{
    public void InsertingNumber()
    {
        Console.WriteLine("Insert your first Number : ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Insert your second Number : ");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Type your choice of mathematics operation : ( +,-,*,/ )");
        string mathOperation = Console.ReadLine();

        int result = 0;

        switch (mathOperation)
        {
            case "+":
                result = firstNumber + secondNumber;
                break;
            case "-":
                result = firstNumber - secondNumber;
                break;
            case "*":
                result = firstNumber * secondNumber;
                break;
            case "/":
                result = firstNumber / secondNumber;
                break;
        }
        
        Console.WriteLine("Result" + " " + firstNumber + " " + mathOperation + " " + secondNumber + " = " + result);
    }
}