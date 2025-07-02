public class studentinfo
{
    public int Age { get; set; }
    public string Name { get; set; }
    public string gender { get; set; }
    public string city { get; set; }

    public static List<studentinfo> getstudent()
    {
        return new List<studentinfo>()
        {
            new studentinfo(){ Age = 22, Name = "kiran",  gender = "male", city = "pune" },
            new studentinfo(){ Age = 17, Name = "samiksha",gender = "female", city = "mumbai" },
            new studentinfo(){ Age = 18, Name = "kishor",  gender = "male", city = "sangli" },
            new studentinfo(){ Age = 26, Name = "rutuja",  gender = "female", city = "satara" },
         new studentinfo()  { Age = 32,  Name = "prathamesh",gender = "male", city = "pune" },
           new studentinfo() { Age = 25, Name = "pranali",  gender = "female", city = "mumbai" },
        };

    }

 
}




