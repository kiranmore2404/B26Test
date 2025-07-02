
List<string> fruits = new List<string>() { "apple", "banana", "mango", "grape" };
//all
bool allfruits = fruits.All(s => s.Length > 3); //true
Console.WriteLine(allfruits);

bool alllongerthan3 = fruits.All(s => s.Length > 5); //false
Console.WriteLine(alllongerthan3);

//any

bool alllongerthan4 = fruits.Any(s => s == "mango");//true
Console.WriteLine(alllongerthan4);

bool alllongerthan5 = fruits.Any(s => s == "pineapple");//false
Console.WriteLine(alllongerthan5);
//contains

bool alllongerthan6 = fruits.Contains("apple");
Console.WriteLine(alllongerthan6);

bool alllongerthan7 = fruits.Contains("pineapple");
Console.WriteLine(alllongerthan7);

List<student> students = student.GetStudent();
foreach (var item in students)
{
    Console.WriteLine($"rollnumber : {item.rollnumber}, name : {item.name} , gender : {item.gender},city : {item.city} ");

}

student s2 = new student() { rollnumber = 1, name = "kiran", gender = "male", city = "pune" };
bool res = students.Contains(s2 ,new studenthelper());
Console.WriteLine(res); 









Console.Read();
