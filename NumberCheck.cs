public class NumberCheck
{

    void OddOrEven(int number)
    {
        if(number % 2 == 1)
        {
            System.Console.WriteLine($"Your number {number} is an odd number.");

        }
        
        if(number % 2 == 0)
        {
            System.Console.WriteLine($"Your number {number} is an even number.");
        }

        if(number % 5 == 0)
        {
            System.Console.WriteLine($"Your number {number} also a multiple of number 5.");
        }
    }

    static void Main(string args)
    {
        System.Console.WriteLine("Please give me your number!");
        int numberToCheck = Console.Readline();
        OddOrEven(numberToCheck);

    }
}