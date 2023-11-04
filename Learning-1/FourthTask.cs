namespace Learning_1;

public class FourthTask
{
    public void InputNumber()
    {
        Console.WriteLine("Input the first number : ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Input the second number : ");
        int secondNumber = int.Parse(Console.ReadLine());

        if (firstNumber % 2 == 0 && secondNumber % 2 == 0)
        {
            Console.WriteLine("both are even number");
        }
        else if (firstNumber % 2 != 0 && secondNumber % 2 != 0)
        {
            Console.WriteLine("both are odds number");
        }
        else
        {
            Console.WriteLine("one of the are even number and the other are odds number");
        }
    }
}