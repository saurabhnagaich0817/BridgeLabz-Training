// Car class
public class Car : Vehicle, IInsurable
{
    private string insurancePolicyNumber;

    public Car(string number, decimal rate, string policyNumber)
        : base(number, "Car", rate)
    {
        insurancePolicyNumber = policyNumber;
    }

    public override decimal CalculateRentalCost(int days)
    {
        return RentalRate * days;
    }

    public decimal CalculateInsurance()
    {
        return RentalRate * 0.10m; // 10% of rentalRate as insurance
    }

    public string GetInsuranceDetails()
    {
        return $"Car Insurance Policy: {insurancePolicyNumber}";
    }
}

// Bike class
public class Bike : Vehicle, IInsurable
{
    private string insurancePolicyNumber;

    public Bike(string number, decimal rate, string policyNumber)
        : base(number, "Bike", rate)
    {
        insurancePolicyNumber = policyNumber;
    }

    public override decimal CalculateRentalCost(int days)
    {
        return RentalRate * days;
    }

    public decimal CalculateInsurance()
    {
        return RentalRate * 0.05m; // 5% of rentalRate as insurance
    }

    public string GetInsuranceDetails()
    {
        return $"Bike Insurance Policy: {insurancePolicyNumber}";
    }
}


public class Truck : Vehicle, IInsurable
{
    private string insurancePolicyNumber;

    public Truck(string number, decimal rate, string policyNumber)
        : base(number, "Truck", rate)
    {
        insurancePolicyNumber = policyNumber;
    }

    public override decimal CalculateRentalCost(int days)
    {
        return RentalRate * days + 1000;
    }

    public decimal CalculateInsurance()
    {
        return RentalRate * 0.15m; 
    }

    public string GetInsuranceDetails()
    {
        return $"Truck Insurance Policy: {insurancePolicyNumber}";
    }
}
