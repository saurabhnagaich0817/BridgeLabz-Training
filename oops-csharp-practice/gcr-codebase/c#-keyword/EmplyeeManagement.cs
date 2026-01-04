using System;

class StaffMember
{
    // Static members
    public static string OrgName = "TechCorp";
    private static int staffCount = 0;

    // Readonly field
    public readonly int StaffId;

    // Instance fields
    public string FullName;
    public string Role;

    // Constructor
    public StaffMember(int id, string name, string role)
    {
        this.StaffId = id;
        FullName = name;
        Role = role;
        staffCount++;
    }

    // Static method
    public static void ShowStaffCount()
    {
        Console.WriteLine("Total Employees: " + staffCount);
    }

    // Instance method using 'is' operator
    public void ShowInfo(object data)
    {
        if (data is StaffMember)
        {
            Console.WriteLine($"{FullName} ({Role}), ID: {StaffId}");
        }
    }
}

class CompanyApp
{
    static void Main()
    {
        StaffMember staff = new StaffMember(1, "Saurabh Nagayach", "Developer");
        staff.ShowInfo(staff);
        StaffMember.ShowStaffCount();
    }
}
