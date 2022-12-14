internal class Program
{
    private static void Main(string[] args)
    {
        
Numbers number = new();
        Console.WriteLine("Введите число");
        Console.WriteLine();
        string enter = Console.ReadLine();
        bool isParse = int.TryParse(enter, out var numbers);
        if (isParse)
        {
            number.Func(numbers);
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Свободен");
            Console.WriteLine();
        }
    }
}