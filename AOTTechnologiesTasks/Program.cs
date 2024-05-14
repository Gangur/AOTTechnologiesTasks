using AOTTechnologiesTasks;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 5, 2, 9, 8, 9, 7 };
        int result = SecondLargest.Find(numbers);
        Console.WriteLine("Second Largest: " + result); // Output: Second Largest: 8
    }
}