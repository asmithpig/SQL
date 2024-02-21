using System.ComponentModel.DataAnnotations;

namespace Assignment_3.OOP_Design;

public class Person : IPersonService
{
    private string name;
    public DateTime BirthDate { get; set; }
    private List<string> addresses;
    public decimal BaseSalary { get; set; }

    public string Name
    {
        get
        {
            return name;
        }
        private set
        {
            name = value;
        }
    }

    public List<string> Addresses
    {
        get
        {
            return addresses;
        }
        private set
        {
            addresses = value;
        }
    }

    public Person(string name, List<string> addresses, DateTime birthDate, decimal baseSalary)
    {
        this.name = name;
        this.addresses = addresses;
        BirthDate = birthDate;
        BaseSalary = baseSalary;
    }

    public int CalculateAge()
    {
        int age = DateTime.Now.Year - BirthDate.Year;
        if (DateTime.Now.DayOfYear < BirthDate.DayOfYear)
        {
            age--;
        }
        return age;
    }

    public decimal CalculateSalary()
    {
        if (BaseSalary < 0)
        {
            throw new Exception("Salary cannot be negative");
        }
        return BaseSalary;
    }

    public List<string> GetAddresses()
    {
        return Addresses;
    }
}