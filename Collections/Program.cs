using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        List<string> names = new List<string> {"Engin", "Murat", "Kerem", "Halil" };
        
        foreach (var name in names) 
        {
            Console.WriteLine(name);
        }
        names.Add("İlker");

        Console.WriteLine(names[4]);
    }
}