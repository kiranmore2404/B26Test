public delegate bool IsEligibleDelegate(student s);

public class institue
{
    public string Name { get; set; }
    public student[] _Students { get; set; }
    public institue(student[] student)
    {
        _Students = student;

    }

    public void Detail()
    {
        Console.WriteLine("**** INSTITUDE DETAILS");
        Console.WriteLine($"Name : {Name}");
        Console.WriteLine("**** ALL STUDENTS ****");

        foreach (var student in _Students)
        {
            Console.WriteLine($"Roll Number: {student.Rollnumber}, Name: {student.Name} Gender : {student.Gender} Date : {student.DateOfBirth}");
        }

    }
    public void studentname(IsEligibleDelegate isEligibleDelegate)
    {
        foreach (var student in _Students)
        {
            if (isEligibleDelegate(student))
            {
                Console.WriteLine($"Eligible Student: {student.Name}");
            }
            else
            {
                Console.WriteLine($"Not Eligible Student: {student.Name}");
            }

        }
    }

}

