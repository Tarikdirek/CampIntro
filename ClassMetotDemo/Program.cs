using ClassMetotDemo;
using ClassMetotDemo.Concrete;

public class Program
{
    public static void Main(string[] args)
    {

        Costumer costumer1 = new Costumer 
        { 
            Id= 1,
            NationalId= 11111111,
            FirstName ="Harun",
            LastName = "Er",
            FatherName = "Abdullah"
        };
		Costumer costumer2 = new Costumer
		{
			Id = 2,
			NationalId = 22222222,
			FirstName = "Ada",
			LastName = "Elvan",
			FatherName = "Burak"
		};
		Costumer costumer3 = new Costumer
		{
			Id = 3,
			NationalId = 33333333,
			FirstName = "Deniz",
			LastName = "Demir",
			FatherName = "Salih"
		};

		CostumerManager costumerManager = new CostumerManager();
                costumerManager.Add(costumer1);
		costumerManager.Add(costumer2);
		costumerManager.Add(costumer3);

		List<Costumer> costumers = new List<Costumer>();
		costumers.Add(costumer1);
		costumers.Add(costumer2); costumers.Add(costumer3);
		Console.WriteLine();

		costumerManager.Listed(costumers);
	        Console.WriteLine();


                costumerManager.Delete(costumer1);
                costumerManager.Delete(costumer2);
                costumerManager.Delete(costumer3);


	}
}
