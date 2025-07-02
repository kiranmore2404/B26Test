
//Console.WriteLine("Hello, World!");
//Console.WriteLine($"byte min size {byte.MinValue} and max {byte.MaxValue} and size of {sizeof(byte)}");
//short s = 12232;
//Console.WriteLine($"s {s} the minimum size of short {short.MinValue} and max is  {short.MaxValue} and size is {sizeof(short)}");
//Console.WriteLine($"s  the minimum size of int {int.MinValue} and max is  {int.MaxValue} and size is {sizeof(int)}");
//Console.WriteLine($"s  the minimum size of long {long.MinValue} and max is  {long.MaxValue} and size is {sizeof(long)}");



//string str = "Hello World";
//Console.WriteLine(str.Length);
//Console.WriteLine(str.ToUpper());
//Console.WriteLine(str.ToLower());
//string name = "                 kiran";
//Console.WriteLine(name.Trim());
//name = "\"kishor\"";
//Console.WriteLine(name);
//string name1 = "'samiksha'";
//Console.WriteLine(name1);
//string name2 = "\\samiksha\\";
//Console.WriteLine(name2);

//string firstName = "Kiran";
//string lastName = "more";
//string fullName =(firstName + " " + lastName);
//Console.WriteLine(fullName);
//fullName = (firstName + " \t" + lastName);
//Console.WriteLine(fullName);
//string middleName = "shahaji";

//fullName = string.Concat(firstName, " ", middleName, " ", lastName);
//Console.WriteLine(fullName);

//fullName = string.Join("-", firstName, middleName, lastName);
//Console.WriteLine(fullName);

////string interpolation
//fullName = $"{firstName} {middleName} {lastName}";
//Console.WriteLine(fullName);

////string interpolation with expression
//fullName = string.Format("full name is {3} {1} {2}", firstName, middleName, lastName);
//Console.WriteLine(fullName);
////string interpolation with expression
//string email = "kiran@gmail.com";
//int index = email.IndexOf('@');
//Console.WriteLine($"index of @ is {index}");
//string domain = email.Substring(0,index+   1);
//Console.WriteLine($"domain is {domain}");
//string studentname = "";
//bool isempty = string.IsNullOrEmpty(studentname);
//Console.WriteLine($"is student name empty {isempty}");

Console.WriteLine("enter the number");
int number = int.Parse(Console.ReadLine());
if(number == 10)
{
    Console.WriteLine($"you entered: {number} = 10");
}
else
{
    Console.WriteLine($"you entered: {number} not equal 10");
}

Console.ReadKey();
