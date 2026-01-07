using System;

public abstract class Product
{
    private string productId;
    private string name;
    private decimal price;

    public string ProductId { get { return productId; } set { productId = value; } }
    public string Name { get { return name; } set { name = value; } }
    public decimal Price 
    { 
        get { return price; } 
        set 
        { 
            if (value >= 0) price = value; 
            else Console.WriteLine("Price cannot be negative."); 
        } 
    }

    public Product(string id, string name, decimal price)
    {
        ProductId = id;
        Name = name;
        Price = price;
    }

    public abstract decimal CalculateDiscount();
}

public interface ITaxable
{
    decimal CalculateTax();
    string GetTaxDetails();
}
