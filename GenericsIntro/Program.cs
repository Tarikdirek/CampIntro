using GenericsIntro;

internal class Program
{
    private static void Main(string[] args)
    {
        //Bellek adresi         //Bellekte tutulan değerler
        //MyList<string> names = new MyList<string>();
        //names.Add("Engin");

        Dictionary<int, string> dictionary = new Dictionary<int, string>();
        dictionary.Add(8, "ada");
        
        foreach (var d in dictionary)
        Console.WriteLine(d);

        MyDictionary<string, string> myDictionary = new MyDictionary<string, string>();
        myDictionary.Add("adad", "ağaç");
        Console.WriteLine(myDictionary.Length);
    }
}