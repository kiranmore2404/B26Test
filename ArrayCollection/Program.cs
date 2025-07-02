
#region ArrayList Example
//using System.Collections;
//using System.Xml.Linq;

//ArrayList a1 = new ArrayList();
//a1.Add(12);
//a1.Add(43);
//a1.Add(65);
//a1.Add(89);
//foreach (var item in a1)
//{
//    Console.WriteLine(item);
//}
//Console.WriteLine(a1.Count);
//Console.WriteLine();

//ArrayList a2 = new ArrayList();
//a2.Add("kiran");
//a2.Add("kishor");
//a2.Add("samiksha");
//a2.Add("shiv");
//foreach (var name in a2)
//{
//    Console.WriteLine(name);

//}
//Console.WriteLine();
//Console.WriteLine(a2.Capacity);
//a2.RemoveAt(2);
//Console.WriteLine(a2.Count);
//a2.Insert(1, "samiksha");
//Console.WriteLine(a2);
//foreach (var name in a2)
//{
//    Console.WriteLine(name);

//}

//ArrayList a3 = new ArrayList();
//a3.Add(11);
//a3.Add(43);
//a3.Add(87);
//foreach (var item in a3)
//{
//    Console.WriteLine(item);
//}
//a3.Insert(3, 03);
//foreach (var item in a3)
//{
//    Console.
//        WriteLine(item);
//}

//HashSet<string> a4 = new HashSet<string>();
//a4.Add("a");
//a4.Add("b");
//a4.Add("c");
//foreach (var item in a4)
//{
//    Console.WriteLine(item);
//}

//student s1 = new student();
//string result = s1.print();


//string res = s1.printA();
//Console.WriteLine(res);

//Console.WriteLine(result);



//Console.Read();
#endregion ArrayList Example


#region Hashtable  example
//Hashtable h1 = new Hashtable();
//h1.Add(1, "kiran");
//h1.Add(2, "kishor");
//h1.Add(3, "pankaj");
//h1.Add(4, "shiv");
//Console.WriteLine($"number of count : {h1.Count}");
//foreach (DictionaryEntry item in h1)
//{
//    Console.WriteLine($"key : {item.Key} value : {item.Value}");
//}
//h1.Remove(1);
//bool reult = h1.ContainsKey(2);
//Console.WriteLine($"Does hashtable contain key 2? : {reult}"); // returns true if key 2 exists in the hashtable

//Console.WriteLine($"number of count : {h1.Count}");



//Dictionary<int, string> h2 = new Dictionary<int, string>();
//h2.Add(1, "kiran");
//h2.Add(2, "kishor");
//h2.Add(3, "pankjay");
//Console.WriteLine($"count of number is  : {h2.Count}");
//foreach (KeyValuePair<int, string> item in h2)
//{
//    Console.WriteLine($"key : {item.Key} value : {item.Value}");
//}
//h2.Remove(1);
//Console.WriteLine($"count of number is  : {h2.Count}");
// bool result = h1.ContainsKey(2);
//Console.WriteLine($"Does hashtable contain key 2? : {result}"); // returns true if key 2 exists in the hashtable



//Console.Read();


#endregion Hashtable  example

#region stack example
//using System.Collections;
//Stack s1 = new Stack();
//s1.Push(12);
//s1.Push(43);
//s1.Push("kiran");
//s1.Push(89);
//Console.WriteLine(s1.Count);

//foreach (var item in s1)
//{
//    Console.WriteLine(item);
//}
//s1.Pop();
//Console.WriteLine(s1.Count);
//s1.Peek();
//Console.WriteLine(s1.Count);


//Stack <int> s2 = new Stack <int>();
//s2.Push(12);
//s2.Push(32);
//s2.Push(65);
//s2.Push(89);
//Console.WriteLine(s2.Count);
//foreach (var item in s2){
//    Console.WriteLine(item);
//}
//s2.Pop();
//Console.WriteLine(s2.Count);
//s2.Peek();
//Console.WriteLine(s2.Count);

//Console.Read();

#endregion stack example

#region Queue example
//using System.Collections;
//Queue q1 = new Queue();
//q1.Enqueue(12);
//q1.Enqueue(43);
//q1.Enqueue("kiran");
//q1.Enqueue(89);
//Console.WriteLine(q1.Count);
//foreach (var item in q1)
//{
//    Console.WriteLine(item);
//}
//q1.Dequeue(); // removes the first element from the queue
//Console.WriteLine(q1.Count);
//q1.Peek(); // returns the first element without removing it
//Console.WriteLine(q1.Count);



//Queue<int> q2 = new Queue<int>();
//q2.Enqueue(12);
//q2.Enqueue(32);
//q2.Enqueue(65);
//q2.Enqueue(89);
//Console.WriteLine(q2.Count);
//foreach (var item in q2)
//{
//    Console.WriteLine(item);
//}
//q2.Dequeue(); // removes the first element from the queue
//q2.Peek();
//// returns the first element without removing it
//Console.WriteLine(q2.Count);


//Console.Read();


#endregion Queue example

#region LinkedList example
using System.Collections;

List<student> l1 = new List<student>();
{
        student s1 = new student() { Id = 1, Name = "kiran", city = "pune" },
               s2 = new student() { Id = 2, Name = "kishor", city = "mumbai" },
               s3 = new student() { Id = 3, Name = "pankaj", city = "nagpur" },
               s4 = new student() { Id = 4, Name = "shiv", city = "nashik" };


    l1.Add(s1);
    l1.Add(s2);
    l1.Add(s3);
    l1.Add(s4);

};



Console.WriteLine($"count of number is : {l1.Count}");
foreach (var item in l1)
{
    Console.WriteLine($"Id : {item.Id} Name : {item.Name} City : {item.city}");
}
l1.RemoveAt(2);
Console.WriteLine($"count of number is : {l1.Count}");
foreach (var item in l1)
{
    Console.WriteLine($"Id : {item.Id} Name : {item.Name} City : {item.city}");


}
Console.WriteLine();
Dictionary<int, student> l2 = new Dictionary<int, student>();
{
    student s1 = new student() { Id = 1, Name = "kiran", city = "pune" },
           s2 = new student() { Id = 2, Name = "kishor", city = "mumbai" },
           s3 = new student() { Id = 3, Name = "pankaj", city = "nagpur" },
           s4 = new student() { Id = 4, Name = "shiv", city = "nashik" };
    l2.Add(s1.Id, s1);
    l2.Add(s2.Id, s2);
    l2.Add(s3.Id, s3);
    l2.Add(s4.Id, s4);
};
foreach (var item in l2)
{
        Console.WriteLine($"Id : {item.Key} Name : {item.Value.Name} City : {item.Value.city}");
}
Console.Read();






#endregion LinkedList example








