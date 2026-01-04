using System;

class StaffRecord
{
    // Public member
    public int staffId;

    // Protected member
    protected string section;

    // Private member
    private double pay;

    // Setter for salary
    public void AssignPay(double amount)
    {
        pay = amount;
    }

    // Getter for salary
    public double FetchPay()
    {
        return pay;
    }

    // Setter for department
    public void AssignSection(string sec)
    {
        section = sec;
    }
}

class TeamLead : StaffRecord
{
    public void ShowStaffDetails()
    {
        Console.WriteLine("Staff ID   : " + staffId);
        Console.WriteLine("Section    : " + section);
        Console.WriteLine("Salary     : ₹" + FetchPay());
    }
}

class OfficeApp
{
    static void Main()
    {
        TeamLead lead = new TeamLead();

        lead.staffId = 201;
        lead.AssignSection("AIML");
        lead.AssignPay(85000);

        lead.ShowStaffDetails();
    }
}
