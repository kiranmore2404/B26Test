//public delegate bool Predicate<in T>(T obj);

Predicate<string> del = s => s.Length > 5;
Console.WriteLine(del("kiran more")); // True
Console.WriteLine(del(" more"));

Predicate<int> del2 = number => number % 2 == 0;
Console.WriteLine(del2(10)); // True
Console.WriteLine(del2(11)); // True 
//public delegate void Action<in T>(T obj);


Action<string> del3 = s => Console.WriteLine(s);
del3("Hello, World!"); // Prints "Hello, World!"

//Action<int> del4 = (num, num2) => { Console.WriteLine(num + num2); };

Action<int> del4 = num => Console.WriteLine($"you entered {num}");
del4(10); // Prints "yiu entered 10"

Action<int ,int > del5 = (num, num2) => Console.WriteLine(num+num2);
del5(10, 54);


Func<string, int> del6 = s => s.Length;
 int res = del6("Hello, World!"); // Returns 13`
Console.WriteLine(res);




Console.ReadLine();