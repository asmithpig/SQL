namespace Assignment_3.OOP_Design;

public class Student : Person, IStudentService
{
    public List<Course> courses { get; set; }
    private Dictionary<Course, Grade> courseGrades { get; set; }

    public Student(string name, List<string> addresses, DateTime birthDate, decimal baseSalary, List<Course> courses, Dictionary<Course, Grade> courseGrades) : base(name, addresses, birthDate, baseSalary)
    {
        this.courses = courses;
        this.courseGrades = courseGrades;
    }

    public decimal CalculateSalary()
    {
        if (BaseSalary < 0)
        {
            throw new Exception("Salary cannot be negative");
        }
        return BaseSalary;
    }

    public decimal CalculateGPA()
    {
        decimal total = 0;
        int count = 0;
        foreach (var course in courseGrades) {
            count++;
            switch (course.Value) {
                case Grade.A:
                    total += 5.00m;
                    break;
                case Grade.B:
                    total += 4.00m;
                    break;
                case Grade.C:
                    total += 3.00m;
                    break;
                case Grade.D:
                    total += 2.00m;
                    break;
                case Grade.E:
                    total += 1.00m;
                    break;
                case Grade.F:
                    total += 0m;
                    break;
            }
        }
        if (count < 1) return -1;
        return total / count;
    }
}