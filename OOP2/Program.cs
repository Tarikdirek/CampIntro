
using OOP2;

internal class Program
{
    private static void Main(string[] args)
    {
        //Engin Demiroğ
        Individual individual1 = new Individual();
        individual1.CostumerNum = "12345";
        individual1.FirstName= "Engin";
        individual1.LastName = "Demiroğ";
        individual1.NotionalId = "1234567890";


        //Kodalama.io
        Coorporate coorporate1 = new Coorporate();
        coorporate1.Id = 2;
        coorporate1.CostumerNum="54321";
        coorporate1.CorporationName = "Kodlama.io";
        coorporate1.TaxNum = "1231546542";

        Costumer costumer1 = new Individual();
        Costumer costumer2 = new Coorporate();

        CostumerManager costumerManager1 = new CostumerManager();
        costumerManager1.Add(individual1);
        costumerManager1.Add(coorporate1);
           
    }
}