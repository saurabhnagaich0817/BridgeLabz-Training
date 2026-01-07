using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
      
        List<Product> products = new List<Product>
        {
            new Electronics("E101", "Laptop", 50000),
            new Clothing("C101", "T-Shirt", 800),
            new Groceries("G101", "Rice", 1200)
        };

        // Print final prices
        foreach (var product in products)
        {
            decimal discount = product.CalculateDiscount();
            decimal tax = 0;

            // Check if product implements ITaxable
            if (product is ITaxable taxableProduct)
            {
                tax = taxableProduct.CalculateTax();
                Console.WriteLine($"{product.Name} -> Tax: {taxableProduct.GetTaxDetails()}");
            }

            decimal finalPrice = product.Price + tax - discount;
            Console.WriteLine($"Product: {product.Name}, Base Price: {product.Price}, Discount: {discount}, Tax: {tax}, Final Price: {finalPrice}\n");
        }
    }
}
