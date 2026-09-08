using System;

class Person
{
    public string Id { get; init; }
    public string FullName { get; set; }
    public int BirthYear { get; set; }

    public Person(string id, string fullName, int birthYear)
    {
        Id = id;
        FullName = fullName;
        BirthYear = birthYear;
    }

    public int GetAge(int currentYear)
    {
        return currentYear - BirthYear;
    }
}

class Employee : Person
{
    public decimal BaseSalary { get; set; }

    public Employee(
        string id,
        string fullName,
        int birthYear,
        decimal baseSalary)
        : base(id, fullName, birthYear)
    {
        BaseSalary = baseSalary;
    }

    public virtual decimal CalculateIncome()
    {
        return BaseSalary;
    }
}

public sealed class Manager : Employee
{
    public decimal ResponsibilityAllowance { get; set; }

    public Manager(
        string id,
        string fullName,
        int birthYear,
        decimal baseSalary,
        decimal allowance)
        : base(id, fullName, birthYear, baseSalary)
    {
        ResponsibilityAllowance = allowance;
    }

    public override decimal CalculateIncome()
    {
        return BaseSalary + ResponsibilityAllowance;
    }
}

class Program
{
    static void Main()
    {
        Employee employee = new Employee(
            "E01",
            "Nguyen Van A",
            2000,
            10000000);

        Manager manager = new Manager(
            "M01",
            "Tran Van B",
            1990,
            15000000,
            5000000);

        Console.WriteLine("===== NHAN VIEN =====");
        Console.WriteLine("Ten: " + employee.FullName);
        Console.WriteLine("Tuoi: " + employee.GetAge(2026));
        Console.WriteLine("Luong co ban: " +
                          employee.BaseSalary.ToString("N0"));
        Console.WriteLine("Thu nhap: " +
                          employee.CalculateIncome().ToString("N0"));

        Console.WriteLine();

        Console.WriteLine("===== QUAN LY =====");
        Console.WriteLine("Ten: " + manager.FullName);
        Console.WriteLine("Tuoi: " + manager.GetAge(2026));
        Console.WriteLine("Luong co ban: " +
                          manager.BaseSalary.ToString("N0"));
        Console.WriteLine("Thu nhap: " +
                          manager.CalculateIncome().ToString("N0"));
    }
}