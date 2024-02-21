namespace Assignment_3.OOP_Design;

public class Department : IDepartmentService
{
    public Instructor HeadOfDeaprtment { get; set; }
    public decimal Budget { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    public List<Course> OfferedCourses { get; set; }
}