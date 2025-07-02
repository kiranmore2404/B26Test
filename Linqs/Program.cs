////List<student> students = new List<student>
////{
////    new student() { Age = 22,Name = "kiran",gender = "male",city = "pune" },
////    new student() { Age = 23,Name = "kishor",gender = "male",city = "pune" },
////    new student() { Age = 24,Name = "pankaj",gender = "male",city = "sangli" },
////    new student() { Age = 25,Name = "abhi",gender = "male",city = "mumbai" },
////    new student() { Age = 21,Name = "shiv",gender = "male",city = "sangli" }
////};
////foreach (var student in students)
////{
////    Console.WriteLine($"Name: {student.Name}, Age: {student.Age} , gender : {student.gender} city : {student.city}");
////}
////Console.WriteLine();
////var sortedStudents = students.Where(s => s.city.Equals("pune"));

////foreach (var student in sortedStudents)
////{
////    Console.WriteLine($"Name: {student.Name}, Age: {student.Age} , gender : {student.gender} city : {student.city}");
////}
////Console.WriteLine();
////var studtn = from s in students
////                where s.gender == "male"
////                select s;

////foreach (var student in studtn)
////{
////    Console.WriteLine($"Name: {student.Name}");
////}


////    List<object> list = new List<object>() { 12, "kiran", 13f, 54, "kishor",'$',12.32d };
////var student3  = list.OfType<int>();
////var student4 = list.OfType<string>();
////foreach (var o in student4)
////{
////    Console.WriteLine(o);
////}

////List<car> cars = new List<car>()
////{
////    new Audi(),
////    new Mercedes(),
////    new BMW(),
////    new Tesla(),
////    new Tesla(),
////    new Mercedes(),
////    new Audi(),
////    new Audi(),



////};
////var audiCars = cars.OfType<Audi>();

////foreach (var car in audiCars)
////{
////    Console.WriteLine(car.name);
////}
////var mercedesCars = cars.OfType<Mercedes>();
////foreach (var car in mercedesCars)
////{
////    Console.WriteLine(car.name);

////}

//////var bmw = cars.OfType<BMW>();

//////foreach (var car in cars)
//////{
//////  if (car.name == "BMW")
//////    {
//////        Console.WriteLine(car.name);
//////    }

//////}

////var audi = cars.OfType<Audi>();

////foreach (var car in audi)
////{
////    Console.WriteLine(car.name);
////}



////List<student> students = student.getstudent();
////foreach (var student in students)
////{
////    Console.WriteLine($"Name: {student.Name}, Age:{student.Age} , gender : {student.gender},city : {student.city} ");

////}
////Console.WriteLine();
////// Sorting students by gender using LINQ
//////var sorts = students.OrderBy(s => s.gender);
////var sorts = from s in students
////            orderby s.Age descending
////            select s;

////foreach (var student in sorts)
////{
////    Console.WriteLine($"Name: {student.Name}, Age:{student.Age} , gender : {student.gender},city : {student.city} ");

////}
////Console.WriteLine();

////students.Reverse();
////foreach (var student in students)
////{
////    Console.WriteLine($"Name: {student.Name}, Age:{student.Age} , gender : {student.gender},city : {student.city} ");

////}
////Console.WriteLine();
////Console.WriteLine();
////IOrderedEnumerable<student> sortedStudents = students.OrderBy(s => s.Name);
////IOrderedEnumerable<student> sortedStudents1 = sortedStudents.ThenBy(s => s.Age);

////foreach (var student in sortedStudents1)
////{
////    Console.WriteLine($"Name: {student.Name}, {student.Age}");
////}


////List<int> number = new List<int> { 4, 2, 3 ,1,5};
////Console.WriteLine("before sorting");
////foreach (var item in number)
////{
////    Console.Write($"{item}\t");

////}
////Console.WriteLine();
//// var sorted = number.OrderBy(i => i);
////Console.WriteLine("after sorting");
////foreach (var item in sorted)
////{
////    Console.Write($"{item}\t");

////}

//// sorted = number.OrderByDescending(i => i);
////Console.WriteLine("after sorting");
////foreach (var item in sorted)
////{
////    Console.Write($"{item}\t");
////}

////List<student> students =  student.getstudent();
////IOrderedEnumerable<student>  sort = students.OrderByDescending(s => s.gender);
////foreach (var student in sort)
////{
////      Console.WriteLine($"Name: {student.Name}, Age:{student.Age} , gender : {student.gender},city : {student.city} ");


////}
////Console.WriteLine();
////IOrderedEnumerable<student> sort1 = sort.ThenByDescending(s => s.Age);
////foreach (var student in sort1)
////{
////    Console.WriteLine($"Name: {student.Name}, Age:{student.Age} , gender : {student.gender},city : {student.city} ");


////}
////List<int> students = new List<int> { 3,2,8,1,9,5,6,4, };
////students.Sort();
////Console.WriteLine("after sorting");

////foreach (var item in students)
////{
////    Console.Write($"{item}\t");
////}
////Console.WriteLine();
////List<string> names = new List<string> { "kiran", "kishor", "pankaj", "abhi", "shiv" };
////names.Sort();
////Console.WriteLine("Names after sorting");
////foreach (string item in names)
////{
////    Console.Write($"{item}\t");
////}

//using System.Linq;


////students.Sort();
////students.Sort(new studenthelper());
////students.Sort(0,3,new studenthelper());
////students.Sort()
////foreach (var student in students)
////{
////    Console.WriteLine($"Name: {student.Name}, Age:{student.Age} , gender : {student.gender},city : {student.city} ");

////}

////List<student> students = student.getstudent();
////students.Sort();
////foreach (var student in students)
////{
////    Console.WriteLine($"Name: {student.Name}, Age:{student.Age} , gender : {student.gender},city : {student.city} ");
////}
////Console.WriteLine();

////students.Sort(new studenthelp());
////students.Sort(0, 5, new studenthelp());

////foreach (var student in students)
////{
////    Console.WriteLine($"Name: {student.Name}, Age:{student.Age} , gender : {student.gender},city : {student.city} ");
////}
////Console.Read();

//List<student> students = student.getstudent();

////var sort = students.OrderBy(
//var sort =  students.OrderBy(s => s.gender);

//foreach (var student in sort)
//{
//    Console.WriteLine($"Name: {student.Name}, Age:{student.Age} , gender : {student.gender},city : {student.city} ");
//}
//Console.WriteLine();

//var sort1 = sort.ThenBy(s => s.Age);
//foreach (var student in sort1)
//{
//    Console.WriteLine($"Name: {student.Name}, Age:{student.Age} , gender : {student.gender},city : {student.city} ");
//}




////List<Student> students = Student.GetAll();















//Console.Read();