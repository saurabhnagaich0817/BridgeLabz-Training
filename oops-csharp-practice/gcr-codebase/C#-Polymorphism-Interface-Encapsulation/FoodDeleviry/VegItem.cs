// VegItem class
public class VegItem : FoodItem, IDiscountable
{
    public VegItem(string name, double price, int qty) : base(name, price, qty) { }

    public override double CalculateTotalPrice()
    {
        // Veg items have 5% packing charge
        double total = Price * Quantity;
        double extraCharge = total * 0.05;
        return total + extraCharge;
    }

    public double ApplyDiscount()
    {
        // 10% discount on veg items
        return CalculateTotalPrice() * 0.10;
    }

    public string GetDiscountDetails()
    {
        return "Veg Item Discount: 10%";
    }
}

// NonVegItem class
public class NonVegItem : FoodItem, IDiscountable
{
    public NonVegItem(string name, double price, int qty) : base(name, price, qty) { }

    public override double CalculateTotalPrice()
    {
        // Non-veg items have 10% packing + 5% tax
        double total = Price * Quantity;
        double extraCharge = total * 0.15; // 10% packing + 5% tax
        return total + extraCharge;
    }

    public double ApplyDiscount()
    {
        // 5% discount on non-veg items
        return CalculateTotalPrice() * 0.05;
    }

    public string GetDiscountDetails()
    {
        return "Non-Veg Item Discount: 5%";
    }
}
