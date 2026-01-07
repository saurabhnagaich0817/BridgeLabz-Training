// Electronics class
public class Electronics : Product, ITaxable
{
    public Electronics(string id, string name, decimal price) : base(id, name, price) { }

    public override decimal CalculateDiscount()
    {
        
        return Price * 0.10m;
    }

    public decimal CalculateTax()
    {
    
        return Price * 0.18m;
    }

    public string GetTaxDetails()
    {
        return "Electronics Tax: 18% GST";
    }
}

// Clothing class
public class Clothing : Product, ITaxable
{
    public Clothing(string id, string name, decimal price) : base(id, name, price) { }

    public override decimal CalculateDiscount()
    {
       
        return Price * 0.15m;
    }

    public decimal CalculateTax()
    {
       
        return Price * 0.12m;
    }

    public string GetTaxDetails()
    {
        return "Clothing Tax: 12% GST";
    }
}

// Groceries class
public class Groceries : Product
{
    public Groceries(string id, string name, decimal price) : base(id, name, price) { }

    public override decimal CalculateDiscount()
    {
        // Example: No discount
        return 0;
    }
}
