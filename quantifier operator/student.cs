public class student
{
    public int rollnumber { get; set; }
    public string name { get; set; }
    public string gender { get; set; }
    public string city { get; set; }


    public static List<student> GetStudent()
    {
        return new List<student>()
        {
            new student() { rollnumber = 1, name = "kiran",gender = "male",city = "pune" },
             new student() { rollnumber = 2, name = "pankaj",gender = "male",city = "pune" },
             new student() { rollnumber = 3, name = "kishor",gender = "male",city = "pune" },
              new student() { rollnumber = 4, name = "samiksha",gender = "female",city = "pune" },
               new student() { rollnumber = 5, name = "pranali",gender = "female",city = "pune" },
    };
    }

    //public override bool Equals(object obj)
    //{
    //    student s = obj as student;

    //    return this.rollnumber.Equals(s.rollnumber) &&
    //           this.name.Equals(s.name) && this.gender.Equals(s.gender) &&
    //            this.city.Equals(s.city);
    //}
    //public override int GetHashCode()
    //{
    //    return this.rollnumber.GetHashCode() ^ this.name.GetHashCode() ^ this.gender.GetHashCode() ^ this.city.GetHashCode();

    //}
}
