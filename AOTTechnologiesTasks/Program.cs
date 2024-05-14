using AOTTechnologiesTasks;

public static class Program
{
    //var summary = BenchmarkRunner.Run<Benchmark>();

    static void Main(string[] args)
    {
        int n1 = 3;
        string str1 = "abc de fghsij";
        Console.WriteLine("Reshape(" + n1 + ", \"" + str1 + "\") = \"" + ReshapeWordsByNSymbols.Reshape(n1, str1) + "\"");

        int n2 = 2;
        string str2 = "1 23 456";
        Console.WriteLine("Reshape(" + n2 + ", \"" + str2 + "\") = \"" + ReshapeWordsByNSymbols.Reshape(n2, str2) + "\"");
    }
}


