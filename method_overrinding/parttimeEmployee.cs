public class parttimeemployee :employee
{
    public int hourssalary;

    public override void print()
    {
        Console.WriteLine($"fullName : {firstname} {lastname} salary  : {hourssalary}");
    }
}