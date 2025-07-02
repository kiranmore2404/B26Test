using System.Reflection;
using System.Xml.Linq;

student s1 = new student()
{
    Rollnumber = 1,
    Name = "kiran",
    gender = Gender.Male
};

student s2 = new student()
{

    Rollnumber = 2,
    Name = "kiran",
    gender = Gender.female,
};

Type gender = Enum.GetUnderlyingType(typeof(Gender));
Console.WriteLine($"Underlying type of {gender.Name}");


Console.WriteLine($"Rollnumber: {s1.Rollnumber}, Name: {s1.Name},Gender : {s1.gender}");
Console.WriteLine($"Rollnumber: {s2.Rollnumber}, Name: {s2.Name},Gender : {s2.gender}");
//static string Getgender(int gender)
//{
//    switch (gender)
//    {
//        case 1:
//            return "male";
//        case 2:
//            return "female";
//        case 3:
//            return "invalid";
//        default:
//            return "unknown"; 
//    }
//}
Console.Read();