// See https://aka.ms/new-console-template for more information

using Assignment_3;
using Assignment_3.ColorBall;
using Assignment_3.OOP_Design;

// 1. reverse Array
ReverseArray.Main();
/*
 * 10, 9, 8, 7, 6, 5, 4, 3, 2, 1
 */

// 2. Fibonacci Sequence
FibonacciSequence.Main();
/*
 * 1 1 2 3 5 8 13 21 34 55
 */
 
//
// Designing and Building Classes using object-oriented principles
//
// 1. Write a program that that demonstrates use of four basic principles of object-oriented programming /Abstraction/, /Encapsulation/, /Inheritance/ and /Polymorphism/.
// 2. Use /Abstraction/ to define different classes for each person type such as Student and Instructor. These classes should have behavior for that type of person.
// 3. Use /Encapsulation/ to keep many details private in each class.
// 4. Use /Inheritance/ by leveraging the implementation already created in the Person
// class to save code in Student and Instructor classes.
// 5. Use /Polymorphism/ to create virtual methods that derived classes could override to create specific behavior such as salary calculations.
// 6. Make sure to create appropriate /interfaces/ such as ICourseService, IStudentService, IInstructorService, IDepartmentService, IPersonService, IPersonService (should have person specific methods). IStudentService, IInstructorService should inherit from IPersonService.
// in folder OOP_Design
Person person = new Person("Smith", new List<string>(new string[]{"la", "da"}), new DateTime(1996, 10, 01), 1000m);
Console.WriteLine(person.CalculateSalary());

Instructor instructor = new Instructor("Tom", new List<string>(new string[] { "pa", "da" }), new DateTime(1984, 10, 01),
 3000m, new Department(), true, new DateTime(1999, 1, 1));
Console.WriteLine(instructor.CalculateSalary());
// 7. Try creating the two classes below, and make a simple program to work with them, as described below
Demo.Main();