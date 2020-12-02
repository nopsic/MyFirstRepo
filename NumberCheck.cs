public class NumberCheck
{

    void OddOrEven(int number)
    {
        if(number % 2 == 1)
        {
            System.Console.WriteLine($"Your number {number} is an odd number.");
        }
        else
        {
            System.Console.WriteLine($"Your number {number} is an even number.");
        }
    }

    static void Main(string args)
    {
        System.Console.WriteLine("Please give me your number!");
        int numberToCheck = Console.Readline();
        OddOrEven(numberToCheck);

    }
}