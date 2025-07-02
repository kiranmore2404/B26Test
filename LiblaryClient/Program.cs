using LiblaryManagement;

student[] s1 = new student[]
{
    new student() { RollNumber = 1,Name = "kiran",   Gender = "male" ,   DateOfBirth = DateTime.Parse("24/04/2003") },
    new student() { RollNumber = 3,Name = "samiksha",Gender = "female", DateOfBirth = DateTime.Parse("03/04/2003") },
    new student() { RollNumber = 2,Name = "kishor",  Gender = "male" ,   DateOfBirth = DateTime.Parse("28/08/2005") },
    new student() { RollNumber = 4,Name = "shiv",    Gender = "male"  ,  DateOfBirth = DateTime.Parse("13/04/2003") },

};



Institue i1 = new Institue(s1) { Name = "SVERI" };
i1.detail();

//IsEligibleDelegate del = criteria;
Predicate<student> del = criteria;
i1.Eligiblestudent(del);



static bool criteria(student s)
{
    return s.Name.StartsWith("k") && s.DateOfBirth.Year > 2003;
}







Console.Read();