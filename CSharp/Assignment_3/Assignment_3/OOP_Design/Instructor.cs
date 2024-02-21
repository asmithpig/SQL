namespace Assignment_3.OOP_Design;

public class Instructor : Person, IInstructorService
{
    public Department Department { get; set; }
    public bool IsHeadOfDepartment { get; set; }
    public DateTime JoinDate { get; set; }

    public Instructor(string name, List<string> addresses, DateTime birthDate, decimal baseSalary, Department department, bool isHeadOfDepartment, DateTime joinDate) : base(name, addresses, birthDate, baseSalary)
    {
        Department = department;
        IsHeadOfDepartment = isHeadOfDepartment;
        JoinDate = joinDate;
    }

    public decimal CalculateSalary()
    {
        decimal totalSalary = BaseSalary + CalculateBonusBasedOnExperience();
        if (totalSalary < 0)
        {
            throw new Exception("Salary cannot be negative");
        }

        return totalSalary;
    }

    public decimal CalculateBonusBasedOnExperience()
    {
        int yearsOfExperience = DateTime.Now.Year - JoinDate.Year;
        if (DateTime.Now.DayOfYear < JoinDate.DayOfYear)
        {
            yearsOfExperience--;
        }
        // Assume a bonus of $100 for each year of experience
        return 100m * yearsOfExperience;
    }
}