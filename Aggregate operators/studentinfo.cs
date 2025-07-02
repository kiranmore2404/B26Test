public class student 
{
    public int Age { get; set; }
    public string Name { get; set; }
    public string gender { get; set; }
    public string city { get; set; }

    public static List<student> getstudent()
    {
        return new List<student>()
        {
            new student(){ Age = 22, Name = "kiran",  gender = "male", city = "pune" },
            new student(){ Age = 17, Name = "samiksha",gender = "female", city = "mumbai" },
            new student(){ Age = 18, Name = "kishor",  gender = "male", city = "sangli" },
            new student(){ Age = 26, Name = "rutuja",  gender = "female", city = "satara" },
         new student()  { Age = 32,  Name = "prathamesh",gender = "male", city = "pune" },
           new student() { Age = 25, Name = "pranali",  gender = "female", city = "mumbai" },
        };


    } 
}