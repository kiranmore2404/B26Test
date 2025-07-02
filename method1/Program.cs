using System;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    static void Main()
    {
        //int[] ints = new int[5] { 1, 2, 3, 4, 5 };
        //sumofarray(ints);
        //Console.WriteLine(ints);
        //int a = 10; int b = 20, add,mul,sub,div;
        // add = calculator(a,b, out  sub, out mul, out  div);
        //Console.WriteLine($"Addtion is {a} + {b} = {add}");
        //Console.WriteLine($"Addtion is {a} - {b} = {sub}");
        //Console.WriteLine($"Addtion is {a} * {b} = {mul}");
        //Console.WriteLine($"Addtion is {a} / {b} = {div}");
        //Console.WriteLine("Main method called");
        //string name = "kishor";
        //printA(ref name);
        //Console.WriteLine(name);
        //    int [] numbers = new int[] { 12,20,30,40,};
        //    addnumber(numbers);
        //    int[] numbers2 = null;
        //    addnumber(numbers2);
        //    Console.Read();
        //}

        //static void printA(ref string name)
        //{
        //    name = "kiran";
        //}



        //static int calculator(int a, int b, out int sub, out int mul, out int div)
        //{
        //    sub = a - b;
        //    mul = b * a;
        //    div = a / b;
        //    return a + b;


        //}

        //static void addnumber(int[] number){ 
        //    int sum = 0;
        //    if (number != null && number.Length > 0)
        //    {
        //        foreach (int numbers in number)
        //        {
        //            sum += numbers;
        //        }
        //        Console.WriteLine($"The sum of All number is  {sum}");
        //    }
        //    else {
        //        Console.WriteLine("this is empty erray");
        //    }
        //}


        //2. Write a program to find whether the given input is prime or not.
        //Console.WriteLine("Enter a number to check if it is prime:");  
        //int number = int.Parse(Console.ReadLine());
        //bool isprime = true;
        //for (int i = 2; i < number; i++)
        //{
        //    if(number % i == 0)
        //    {
        //        isprime = false;
        //        break;
        //    }
        //}
        //string res = isprime ? "prime number " : "not a prime number";
        //Console.WriteLine($"{number} is a {res}");
        //Console.Read();

        //4. Write a program to print fibonacci series.       1 1 2 3 5 8 13 21…
        //Console.WriteLine("enter the number ");
        //int num = int.Parse(Console.ReadLine());
        //int a = 0, b = 1, c;
        //for (int i = 2; i < num; i++)
        //{
        //    c = a + b;
        //    Console.WriteLine(a);
        //    a = b;
        //    b = c;
        //}


        //5. Write a program to find if a given string is palindrome.

        //    Console.WriteLine("Enter the string to check if it is a palindrome:");
        //    string str = Console.ReadLine();

        //    string rev = string.Empty;
        //    for (int i = str.Length - 1; i >= 0; i--)
        //    {
        //        rev += str[i];
        //    }

        //    if (str.ToLower() == rev.ToLower())
        //    {
        //        Console.WriteLine($"{str} is a palindrome");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"{str} is not a palindrome");
        //    }


        //7.Write a program to reverse a string. (without using reverse method)
        //Console.WriteLine("Enter the string to reverse:");
        //string str = Console.ReadLine();
        //string rev = string.Empty;
        //for (int i = str.Length - 1; i >= 0; i--)
        //{
        //    rev += str[i];
        //}
        //Console.WriteLine($"Reversed string is: {rev}");


        //8.Write a program to reverse given array.
        //Console.WriteLine("Enter the array elements separated by commas:");
        //string input = Console.ReadLine(); // Example: "11,343,34,23"

        //string[] tokens = input.Split(',');
        //int[] arr = new int[tokens.Length];
        //string rev = string.Empty;

        //// Convert string tokens to integers
        //for (int i = 0; i < tokens.Length; i++)
        //{
        //    arr[i] = int.Parse(tokens[i].Trim()); // Trim removes any spaces
        //}

        //// Reverse
        //for (int i = arr.Length - 1; i >= 0; i--)
        //{
        //    rev += arr[i] + " ";
        //}

        //Console.WriteLine("Reversed array is:");
        //Console.WriteLine(rev);

        //12. Swap two numbers using third temporary variable.
        //Console.WriteLine("Enter the first number:");
        //int a = int.Parse(Console.ReadLine());
        //Console.WriteLine("Enter the second number:");
        //int b = int.Parse(Console.ReadLine());
        //Console.WriteLine($"Before swapping: a = {a}, b = {b}");
        //int temp = a;
        //a = b;
        //b = temp;
        //Console.WriteLine($"After swapping: a = {a}, b = {b}");
        //13. Swap two numbers without using third variable.
        //Console.WriteLine("Enter the first number:");
        //int a = int.Parse(Console.ReadLine());
        //Console.WriteLine("Enter the second number:");
        //int b = int.Parse(Console.ReadLine());
        //Console.WriteLine($"Before swapping: a = {a}, b = {b}");
        //a = a + b;
        //b = a - b;
        //a = a - b;
        //Console.WriteLine($"After swapping: a = {a}, b = {b}");

        //15.Write a program to find highest number from array.
        //int[] arr = new int[8] {12,34,45,565,56,56,67,78, };
        //int i, max, min;
        //int count = arr.Length;
        //max = arr[0];
        //min = arr[0];
        //for (i = 1; i < count; i++)
        //{
        //    if (arr[i] > max)
        //    {
        //        max = arr[i];
        //    }
        //    if (arr[i] < min)
        //    {
        //        min = arr[i];
        //    }

        //}

        //20. Use a for loop to print all even numbers from 1 to 20.
        //for (int i = 1; i < 20; i++)
        //{
        //    if(i % 2 != 0)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}

        //Console.WriteLine("enter the first number");
        //double num1 = Convert.ToDouble(Console.ReadLine());

        //Console.WriteLine("enter the second number");
        //double num2 = Convert.ToDouble(Console.ReadLine());
        //Console.WriteLine("enter the operator  = + ,-, / ,*");
        //string op  = Console.ReadLine();
        //double result;

        //if (op == "+")
        //{
        //    result = num1 + num2;
        //    Console.WriteLine($"result = {result}");
        //}
        //else if (op == "-")
        //{
        //    result = num1 - num2;
        //    Console.WriteLine($"result = {result}");

        //}
        //else if (op == "*")
        //{
        //    result = num1 * num2;
        //    Console.WriteLine($"result = {result}");
        //}
        //else if (op == "/")
        //{
        //    if (num1 > 0 && num2 > 0)
        //    {
        //        result = num1 / num2;
        //        Console.WriteLine($"result = {result}");


        //    }
        //    else
        //    {
        //        Console.WriteLine($"errror : division by zero");
        //    }


        //}
        //else {
        //    Console.WriteLine("invalid operator");
        //}

        //25. Write a program that takes an array of 5 numbers and prints the sum and average.


        //static void sumofarray(int[] arr)
        //{
        //    int sum = 0;
        //    if (arr != null && arr.Length > 0)
        //    {
        //        foreach (int i in arr)
        //        {
        //            sum += i;
        //        }



        //    }
        //    Console.WriteLine($"The sum of All number is  {sum}");
        //21. Write a program that asks the user to enter a number and prints its multiplication table (from 1 to 10).

        //Console.WriteLine("Enter a number to print its multiplication table:");
        //int number = int.Parse(Console.ReadLine());

        //for (int i = 1; i <= 10; i++)
        //{
        //    int result;
        //    result = i * number;
        //    Console.WriteLine($"{number} x {i} = {result}");

        //}

        //15. Write a program to find highest number from array.

        //int[] arr = new int [6] { 1, 2,  3 ,23,67,34};
        //int count = arr.Length;
        //int max = arr[0];
        //int min = arr[0];
 
        //for (int i = 1; i < count; i++) { 
    
        //    if (arr[i] > max)
        //    {
        //        max = arr[i];

        //    }
        //    if (arr[i] < min) {
        //        min = arr[i];
            
        //    }
        
        //}
        //Console.WriteLine($"maximum value is  =  {max}");
        //Console.WriteLine($"minimum value is   = {min}");

        Console.WriteLine("Enter a  first number");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter a  second number");
        int b = Convert.ToInt32(Console.ReadLine());

        int i, j;
        for (i = a; i <= b; i++)
        {
            for ( j = 2; j <= i; j++)
            {
                if (i % j == 0)
                    break;
            }
            if(i==j)
            Console.WriteLine(j + " ");

        }


        Console.Read();
        }
    
}