List<studentinfo> students = studentinfo.getstudent();
foreach (studentinfo item in students)
{
    Console.WriteLine($"roll number : {item.Age} name : {item.Name} gender : {item.gender} city : {item.city} " +
        $"age : {item.Age}");
}
#region order by 

//Console.WriteLine("before sorting");

//foreach (student item in students)
//{
//    Console.WriteLine($"roll number : {item.Age} name : {item.Name} gender : {item.gender} city : {item.city} " +
//        $"age : {item.Age}");

//}
//Console.WriteLine("after sorting");
//IOrderedEnumerable<student> res = students.OrderBy(s => s.gender);
//foreach (student item in res)
//{
//    Console.WriteLine($"roll number : {item.Age} name : {item.Name} gender : {item.gender} city : {item.city} ");

//}

#endregion order by 

#region order by desc
//Console.WriteLine("before sorting");

//foreach (student item in students)
//{
//    Console.WriteLine($"roll number : {item.Age} name : {item.Name} gender : {item.gender} city : {item.city} " +
//        $"age : {item.Age}");

//}
//Console.WriteLine("after sorting");
//IOrderedEnumerable<student> res = students.OrderByDescending(s => s.Age);
//foreach (student item in res)
//{
//    Console.WriteLine($"roll number : {item.Age} name : {item.Name} gender : {item.gender} city : {item.city} ");

//}




#endregion order by desc

#region then by 


//IOrderedEnumerable<student> res = students.OrderBy(s => s.gender);
//foreach (student item in res)
//{
//    Console.WriteLine($"roll number : {item.Age} name : {item.Name} gender : {item.gender} city : {item.city} ");

//}
//Console.WriteLine();

//IOrderedEnumerable<student> res1 = res.ThenBy(s => s.Age);

//foreach (student item in res1)
//{
//    Console.WriteLine($"roll number : {item.Age} name : {item.Name} gender : {item.gender} city : {item.city} ");

//}


#endregion then by 

#region sort 4 overloads
//Console.WriteLine("before sorting");

//foreach (studentinfo item in students)
//{
//    Console.WriteLine($"roll number : {item.Age} name : {item.Name} gender : {item.gender} city : {item.city} " +
//        $"age : {item.Age}");

//}
//Console.WriteLine();
//students.Sort(); --1
//students.Sort(new studentcom()); --2
//students.Sort(0,4,new studentcom());---3
// students.Sort((x, y) => y.gender.CompareTo(x.gender));---4

//foreach (studentinfo item in students)
//{
//    Console.WriteLine($"roll number : {item.Age} name : {item.Name} gender : {item.gender} city : {item.city} ");

//}
#endregion sort 4 overloads

#region grouping 


//IEnumerable<IGrouping<string, studentinfo>> groups = students.GroupBy(s => s.gender);

//foreach (var group in groups)
//{
//    Console.WriteLine($"Group Age: {group.Key}, Number of Students: {group.Count()}");

//    foreach (var student in group)
//    {
//        Console.WriteLine($" - {student.Name}");
//    }
//}

//IEnumerable<IGrouping<string, studentinfo>> res = students.ToLookup(s => s.gender);
//foreach (var item in res)
//{
//    Console.WriteLine($"Group Gender: {item.Key}, Number of Students: {item.Count()}");

//    foreach (var student in item)
//    {
//        Console.WriteLine($" - {student.Name}");
//    }

//}

Console.Read();

#endregion grouping










Console.Read();