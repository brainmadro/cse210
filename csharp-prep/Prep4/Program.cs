using System;

class Program
{
    static void Main(string[] args)
    {
        int response, sum = 0, largest = 0;
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        do
        {
            Console.Write("Enter a number: ");
            response = int.Parse(Console.ReadLine());
            numbers.Add(response);
        } while (response != 0);
        
        foreach (var item in numbers)
        {
            sum += item;
            if (item > largest)
            {
                largest = item;
            }
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {sum / (numbers.Count - 1)}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}