


class student
{
    public string first_name;
    public string last_name;


   public student()
    {
        Console.WriteLine("student constuructor called  student()");

    }

    public student(string fn ,string ln)
    {
        first_name = fn;
        last_name = ln;
        Console.WriteLine("student parametarized  constuructor called  student(string fn ,string ln)");


    }

    public student (student s)
    {
        first_name = s.first_name;
        last_name = s.last_name;
        Console.WriteLine("copy constructor called");
    }


    public void print()
    {
        Console.WriteLine($"fullname = {first_name} {last_name}");
    }

    //public void start(string fn ,string ln) { 
    //    first_name = fn;
    //    last_name = ln;

    //}
}

