List<int> numbers = new List<int>() { 1, 22, 73, 94, 5, 76,9, 10 };
#region elementsatordefault
//elementat or elementatordefault
//elementat
//var elementat = numbers.ElementAt(6);
//Console.WriteLine($"Element at index 6 is : {elementat}");

//  elementat = numbers.ElementAt(11);
//Console.WriteLine($"Element at index 6 is : {elementat}");
////elementatordefault

//var elementatordefault = numbers.ElementAtOrDefault(3);
//Console.WriteLine($"Element at index 6 is : {elementatordefault}");

//elementatordefault = numbers.ElementAtOrDefault(11);// provide default value if index is out of range
//Console.WriteLine($"Element at index 11 is : {elementatordefault}");
#endregion elementsatordefault
#region firstordefault
//first
//var first = numbers.First();
//Console.WriteLine($"First element is : {first}");

//first = numbers.First(s => s > 160);
//Console.WriteLine($"First element greater than 160 is : {first}");

//firstordefault

//var firstordefault = numbers.FirstOrDefault(s => s > 160);
//Console.WriteLine($"First element greater than 160 is : {firstordefault}");

//firstordefault = numbers.FirstOrDefault(s=>s>1);
//Console.WriteLine($"First element greater than 160 is : {firstordefault}");





#endregion firstordefault
#region lastordefault
//last
//var last = numbers.Last(s=>s>12);
//Console.WriteLine($"Last element is : {last}");

//last = numbers.Last(s => s > 94);
//Console.WriteLine($"Last element greater than 12 is : {last}");



var lastordefault = numbers.LastOrDefault(s => s > 94);
Console.WriteLine($"Last element greater than 94 is : {lastordefault}");

#endregion lastordefault
Console.Read();
