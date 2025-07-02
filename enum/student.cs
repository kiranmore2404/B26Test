using Microsoft.VisualBasic.FileIO;

public class student
{
    public int Rollnumber { get; set; }
    public string Name { get; set; }
    public Gender gender { get; set; }
}
public enum Gender{
    Male,female
}