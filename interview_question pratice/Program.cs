//2. Write a program to find whether the given input is prime or not.
//Console.WriteLine("Enter a number to check if it is prime:");
//int num = Convert.ToInt32(Console.ReadLine());


//bool isPrime = true;
//for (int i = 2; i < num; i++)
//{
//    if(num% i == 0) { 
//        isPrime = false;
//        break;
//    }

//}
//string result = isPrime ? "is prime" : "is not prime";
//Console.WriteLine($"The number {num} {result}.");

//4. Write a program to print fibonacci series. 1 1 2 3 5 8 13 21…

//Console.WriteLine("Enter the number of terms in the Fibonacci series:");
//int n = Convert.ToInt32(Console.ReadLine());
//int a = 0, b = 1, c;
//for (int i= 1; i <= n; i++)
//{
//    c = a + b;
//    a = b;
//    b = c;
//    Console.WriteLine(c);


//}
//Console.WriteLine();

//5. Write a program to find if a given string is palindrome.
//Console.WriteLine("Enter a string to check if it is a palindrome:");
//string str = Console.ReadLine();
//string reversedStr = string.Empty;
//for (int i = str.Length - 1; i >= 0; i--)
//{
//    reversedStr = reversedStr + str[i];

//}
//if (str == reversedStr)
//{
//    Console.WriteLine($"The string '{str}' is a palindrome.");
//}
//else
//{
//    Console.WriteLine($"The string '{str}' is not a palindrome.");
//}

//Console.WriteLine("enter the number :");
//int num = Convert.ToInt32(Console.ReadLine());
//int p = 0, q = 1, r;
//for (int i = 1; i <= num; i++)
//{
//    Console.WriteLine(p);
//    Console.WriteLine(q);
//    r = p + q;
//    p = q; 
//    q = r;
//    Console.WriteLine(r);

//}
//Console.WriteLine();
//Console.WriteLine("Enter a number check it is prime or not :");
//int num = int.Parse(Console.ReadLine());
//bool isprime = true;
//for (int i = 2; i < num; i++)
//{
//    if(num % i == 0)
//    {
//        isprime = false;
//        break;
//    }
//}
//string res = isprime ? "1" : "0";
//Console.WriteLine(res);

//4. Write a program to print fibonacci series.1 1 2 3 5 8 13 21…



//Console.Write("Enter number of terms: ");
//int num = int.Parse(Console.ReadLine());

//int a = 0, b = 1, c;

//Console.WriteLine("Fibonacci sequence:");

//for (int i = 1; i <= num; i++)
//{
//    Console.WriteLine(a); // print current number

//    c = a + b; // next term
//    a = b;     // move forward
//    b = c;


//}
//Console.WriteLine();


//5.Write a program to find if a given string is palindrome.



//Console.WriteLine("Enter a number:");
//int num = Convert.ToInt32(Console.ReadLine());
//if (num % 3 == 0 && num % 5 == 0)
//{
//    Console.WriteLine($" The number is divisible five or threee");
//}
//else if (num % 3 == 0)
//{
//    Console.WriteLine($" The number is divisible by three");
//}
//else if (num % 5 == 0)
//{
//    Console.WriteLine($" The number is divisible by five");
//}
//else
//{
//    Console.WriteLine($" The number is not divisible by five or three");

//}

//7. Write a program to reverse a string. (without using reverse method)
//Console.WriteLine("Enter a string to reverse:");
//string str = Console.ReadLine();
//string reversedStr = string.Empty;
//for (int i = str.Length - 1; i >= 0; i--)
//{
//    reversedStr += str[i];
//}
//Console.WriteLine($"Reversed string: {reversedStr}");


//int[] arr = new int[] { 10,20,30,40,50};
//for (int i = arr.Length - 1; i >= 0; i--)
//{
//    Console.WriteLine(arr[i]);
//}
//Console.WriteLine();

//12. Swap two numbers using third temporary variable.
//Console.WriteLine("Enter first number:");
//int num1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter second number:");
//int num2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"\nBefore swap: num1 = {num1}, num2 = {num2}");

//int temp = num1;
//num1 = num2;
//num2 = temp;
//Console.WriteLine($"After swap: num1 = {num1}, num2 = {num2}");


//13. Swap two numbers without using third variable.
//Console.WriteLine("Enter first number:");
//int num3 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Enter second number:");
//int num4 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine($"\nBefore swap: num3 = {num3}, num4 = {num4}");
//num3 = num3 + num4;
//num4 = num3 - num4;
//num3 = num3 - num4;
//Console.WriteLine($"After swap: num3 = {num3}, num4 = {num4}");

//int[] arr = new int[] { 10, 20, 30, 40, 50 };
//int max = 0;
//for (int i = 1; i < arr.Length; i++)
//{
//    if (arr[i] > max)
//    {
//        max = arr[i];

//    }

//}
//Console.WriteLine($"The maximum number is: {max}");

//2. Write a program to find whether the given input is prime or not.
//Console.WriteLine("enter the number ");
//int num = int.Parse(Console.ReadLine());
//bool isprime = true;
//for (int i = 2; i < num; i++)
//{
//    if(num% i == 0)
//    {
//        isprime = false;    
//        break;
//    }

//}
//string res = isprime ? "prime number" : "not prime number";
//Console.WriteLine(res);
//Console.WriteLine();

//4.Write a program to print fibonacci series. 1 1 2 3 5 8 13 21…
//Console.WriteLine("enter the number ");
//int num = int.Parse(Console.ReadLine());
//int a =0; int b = 1; int c;
//for (int i= 2; i <= num; i++)
//{
//    Console.WriteLine(a);
//    c = a + b;
//    a = b;
//    b = c;

//}
//5.Write a program to find if a given string is palindrome.

//Console.WriteLine("Enter a string to check if it is a palindrome:");
//string str = Console.ReadLine();
//string reversedStr = string.Empty;
//for (int i = str.Length - 1; i >= 0; i--)
//{
//    reversedStr = reversedStr + str[i];

//}
//if (str == reversedStr)
//{
//    Console.WriteLine($"The string '{str}' is a palindrome.");
//}
//else
//{
//    Console.WriteLine($"The string '{str}' is not a palindrome.");
//}


//7. Write a program to reverse a string. (without using reverse method)

//8. Write a program to reverse given array.
//int[] ints = new int[] { 10, 20, 30, 40, 50 };
//for (int i = ints.Length - 1; i >= 0; i--)
//{
//    Console.WriteLine(ints[i]);
//}
//12. Swap two numbers using third temporary variable
//Console.WriteLine("Enter first number:");
//int num1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter second number:");
//int num2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"\nBefore swap: num1 = {num1}, num2 = {num2}");
//int temp = num1;
//num1 = num2;
//num2 = temp;
//Console.WriteLine($"After swap: num1 = {num1}, num2 = {num2}");
//Console.WriteLine("enter the number ");
//int num = int.Parse(Console.ReadLine());

//bool isprime = true;
//for (int i = 2; i < num; i++)
//{
//    if (num % i == 0)
//    {
//        isprime = false;    
//        break;
//    }
//}
//string res = isprime ? "prime" : "not prime ";
//Console.WriteLine(res);

//Console.WriteLine("Enter a number ");
//int num = int.Parse(Console.ReadLine());
//int a = 0, b = 1, c;

//for(int i = 2
//    ;i<= num; i++)
//{
//    c = a + b;
//    a = b;
//    b = c;
//    Console.WriteLine(c);

//}

Console.WriteLine("enter the name");
string name = Console.ReadLine();
string rev = string.Empty;
for(int i = name.Length-1; i >= 0; i--)
{
rev = rev + name[i];
}
if(name == rev)
{
    Console.WriteLine($"{name} is pailndrome");

}
else
{
    Console.WriteLine("not a pailndrome");
}

Console.Read();


