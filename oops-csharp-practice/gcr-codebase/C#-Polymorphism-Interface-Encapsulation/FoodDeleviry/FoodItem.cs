using System;

// Abstract FoodItem class
public abstract class FoodItem
{
    private string itemName;
    private double price;
    private int quantity;

    // Encapsulated properties
    public string ItemName { get { return itemName; } set { itemName = value; } }
    public double Price { get { return price; } set { price = (value >= 0) ? value : 0; } }
    public int Quantity { get { return quantity; } set { quantity = (value > 0) ? value : 1; } }

    public FoodItem(string name, double price, int qty)
    {
        ItemName = name;
        Price = price;
        Quantity = qty;
    }

    // Abstract method to calculate total price
    public abstract double CalculateTotalPrice();

    // Concrete method to show item details
    public void GetItemDetails()
    {
        Console.WriteLine($"Item: {ItemName}, Price: {Price}, Quantity: {Quantity}");
    }
}

// Interface for discountable items
public interface IDiscountable
{
    double ApplyDiscount();
    string GetDiscountDetails();
}
