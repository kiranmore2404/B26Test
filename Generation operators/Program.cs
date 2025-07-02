
List<int> number2 = new List<int>();
Console.WriteLine($"number of items in number2 {number2.Count}");

  IEnumerable<int> number3 =  number2.DefaultIfEmpty();
Console.WriteLine($"number of items in number3 {number3.Count()}");

IEnumerable<int> number4 = Enumerable.Empty<int>();
Console.WriteLine($"number of items in number4 {number4.Count()}");

Console.WriteLine();

IEnumerable<string> number5 =  Enumerable.Repeat<string>("kiran", 10);
Console.WriteLine($"number of items in number5 {number5.Count()}");
foreach (var name in number5)
{
    Console.Write($"{name}\t");
}
Console.WriteLine();


IEnumerable<int> number6 = Enumerable.Range(1, 15);
Console.WriteLine($"number of items in number6 {number6.Count()}");
foreach (var num in number6)
{
    Console.Write($"{num}\t");
}
Console.WriteLine();

List<int> number7 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
var res  = number7.Max();
Console.WriteLine($"Max number in number7 is {res}");

var res1 = number7.Min();
Console.WriteLine($"Max number in number7 is {res1}");
var res2 = number7.Sum();
Console.WriteLine($"Sum of number in number7 is {res2}");

var res3 = number7.Average();
Console.WriteLine($"Average of number in number7 is {res3}");

var res4 = number7.Aggregate((x, y) => x + y);
Console.WriteLine($"Aggregate of number in number7 is {res4}");

Console.WriteLine($"Aggregate of number in number7 is {number7.Aggregate((x, y) => x * y)}");

Console.WriteLine($"Aggregate of number in number7 is {number7.Aggregate((x, y) => x - y)}");


//List<int> number8 = new List<int>() { 1, 2,3,4 };
//Console.WriteLine($"Aggregate of number in number7 is {number8.Aggregate((x, y) => x + y)}");

Console.WriteLine("-------------------------------------------------");
List<student> students = student.getstudent();
//var res5 = students.Select(s => new {s.gender,s.Age});

// i wnat sorting on res5 using sort method
//students.Sort((x, y) => x.Age.CompareTo(y.Age));
//students.Sort((x, y) => x.Age.CompareTo(y.Age));
//students.Sort();
//IOrderedEnumerable<student> sortedRes = students.OrderBy(s => s.gender);
//IOrderedEnumerable<student> sortedRess = sortedRes.ThenBy(s => s.Age);


//foreach (var item in sortedRess)
//{
//    Console.WriteLine($" gender :{item.gender} Age : {item.Age}");
//}








Console.Read();
