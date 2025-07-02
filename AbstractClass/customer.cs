//public  abstract class Customer
//{
//   public void todaysshow()
//   {
//       Console.WriteLine("Today's Show");
//    }
//    public abstract void printticket();

//}

//public class silvercustomer : Customer
//{
//    public override void printticket()
//    {
//        Console.WriteLine("Silver Customer Ticket Printed");
//    }

//}
//public  class goldcustomer : Customer
//{
//    public override void printticket()
//    {
//        Console.WriteLine("Gold Customer Ticket Printed");
//    }

//}

//12. Swap two numbers using third temporary variable
//int a = 12, b = 14, c;
//Console.WriteLine($"before swapping a = {a} b = {b}");
//c = a;
//Console.WriteLine(c);
//a = b;
//b = c;
//Console.WriteLine(a);
//Console.WriteLine(b);

//int d = 12, e = 14;

//Console.WriteLine($"before swapping  d = {d} e = {e}");
//d = d + e;
//Console.WriteLine(d);
//e = d - e;
//d = d - e;
//Console.WriteLine($"before swapping  d = {d} e = {e}");
//2.Write a program to find whether the given input is prime or not.

//Console.WriteLine("ebter the number to check is prime or not ");
//int number = int.Parse(Console.ReadLine());
//bool isprimr = true;
//for (int i = 2;i<number;i++)
//{
//    if(number % i == 0)
//    {
//        isprimr = false; break;
//    }
//}
//string res = isprimr ? "prime" : "not prime";
//Console.WriteLine(res);

//3. Write a program to print all prime numbers till target. (take target from user)
//Console.WriteLine("enter the first number");
//int num1 = 20;
//for (int i = 1; i <= num1; i++)
//{
//    if (i % 2 == 0)
//    {
//        Console.WriteLine(i);
//    }

//}

//4. Write a program to print fibonacci series.1 1 2 3 5 8 13 21…

//int a = 1, b = 1, c, n;

//Console.WriteLine("Enter number of terms:");
//n = int.Parse(Console.ReadLine());

//Console.Write(a + " " + b + " "); // पहिल्या दोन संख्यांचे प्रिंट

//for (int i = 3; i <= n; i++)
//{
//    c = a + b;
//    Console.Write(c + " ");
//    a = b;
//    b = c;
//}


//Console.WriteLine("enter the name ");
//string name =  Console.ReadLine();
//string rev =  string.Empty;
//for(int i = name.Length - 1; i >= 0; i--)
//{
//    rev += name[i];
//}
//if(name == rev)
//{
//    Console.WriteLine("is paindrome");
//}
//else
//{
//    Console.WriteLine("not a pailndrome");
//}
//
//25.Write a program that takes an array of 5 numbers and prints the sum and average.
//int[] arr = new int[] {10,20,30,40,50 };
//int sum = 0;
//for (int i = 0; i < arr.Length; i++)
//{
//    sum += arr[i];
//}
//Console.WriteLine(sum);
//float average = (float)sum / 5;
//Console.WriteLine(average);

// 21. Write a program that asks the user to enter a number and prints its multiplication table (from 1 to 10).
Console.WriteLine("enter the number");
int number = int.Parse(Console.ReadLine());
for(int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{number} x {i} = {number * i}");

}













Console.Read();
