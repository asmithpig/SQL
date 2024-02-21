namespace Assignment_3.OOP_Design;

public class Course : ICourseService
{
    public List<Student> EnrolledStudents { get; set; }
    
    public void AddStudent(Student student)
    {
        EnrolledStudents.Add(student);
    }
}