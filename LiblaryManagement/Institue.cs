
using LiblaryManagement;



public class Institue
{
    public string Name { get; set; }
    public student[] _students { get; set; }
    public Institue(student[] student)
    {
        _students = student;
    }

    public void detail()
    {
        Console.WriteLine("**** INSTITUDE DETAILS");
        Console.WriteLine($"Name : {Name}");
        Console.WriteLine("**** ALL STUDENTS ****");

        foreach (var student in _students)
        {
            if (student != null)
            {
                Console.WriteLine($"Roll Number: {student.RollNumber}, Name: {student.Name} Gender : {student.Gender} Date : {student.DateOfBirth}");
            }
            else
            {
                Console.WriteLine("student not present");
            }

        }
    }
    //public delegate bool IsEligibleDelegate(student s);
    public void Eligiblestudent(Predicate<student> isEligibleDelegate)
    {
        foreach (var student in _students)
        {
            //if (student.Name.StartsWith("k"))
            if (isEligibleDelegate(student))
            {
                {
                    Console.WriteLine(student.Name);
                }

            }
        }
    }
}