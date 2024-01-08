using System;

class Employee
{
    // Properties
    public string Name { get; set; }
    public int EmpNo { get; set; }
    public float Basic { get; set; }
    public short DeptNo { get; }

    // Parameterized Constructor
    public Employee(string name, int empNo, float basic, short deptNo)
    {
        Name = name;
        EmpNo = empNo;
        Basic = basic;
        DeptNo = deptNo;
    }

    // Method to display all details
    public void DisplayEmployeeDetails()
    {
        Console.WriteLine("Employee Details:");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"EmpNo: {EmpNo}");
        Console.WriteLine($"Basic: {Basic}");
        Console.WriteLine($"DeptNo: {DeptNo}");
    }

    // Method to update Basic Pay with optional parameter
    public void UpdateBasicPay(float amount = 0.0f)
    {
        Basic += amount;

        // Local function to display EmpNo & Basic pay only
        void DisplayEmpNoAndBasic()
        {
            Console.WriteLine($"EmpNo: {EmpNo}");
            Console.WriteLine($"Basic: {Basic}");
        }

        Console.WriteLine("Basic Pay Updated. Details:");
        DisplayEmpNoAndBasic();
    }
}

class Program
{
    static void Main()
    {
        // Example usage
        Employee emp = new Employee("John Doe", 101, 50000.0f, 1);

        // Display initial details
        emp.DisplayEmployeeDetails();

        // Update Basic Pay with the default amount
        emp.UpdateBasicPay();

        // Update Basic Pay with a specific amount
        emp.UpdateBasicPay(2000.0f);
    }
}
