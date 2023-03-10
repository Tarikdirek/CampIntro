using OOP1;

class Program
{
    private static void Main(string[] args)
    {
        Product product1 = new Product();
        product1.Id = 1;
        product1.CategoryId = 2;
        product1.ProductName = "Masa";
        product1.UnitPrice = 500;
        product1.UnitStock = 3;

        Product product2 = new Product { Id = 2, CategoryId = 5, UnitStock = 5, ProductName = "Kalem", UnitPrice = 35 };

        ProductManager productManager = new ProductManager();
        productManager.Add(product1);
        productManager.Add(product2);

        Console.WriteLine();
        productManager.Update(product1);
        productManager.Update(product2);

        
    }
}