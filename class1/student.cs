class Student

{

    // class fields / data member

    public string FirstName;

    public string LastName;

 

    public Student()

    {

        FirstName = "test";

        LastName = "name";

        Console.WriteLine("Student() Constructor Called.");

    }

 

    public Student(string fn, string ln) // parameterized constructor

    {

        FirstName = fn;

        LastName = ln;

        Console.WriteLine("Student(string fn, string ln) Constructor Called.");

    }

 

    public Student(Student s)

    {

        FirstName = s.FirstName;

        LastName = s.LastName;

    }

 

    // class method / member function

    public void Print()

    {

        Console.WriteLine($"Full Name : {FirstName} {LastName}");

    }

}