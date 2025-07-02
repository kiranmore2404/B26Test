//2.Write a program to find whether the given input is prime or not.
//Console.WriteLine("Enter the number for check it is prime or not");
//int number = int.Parse(Console.ReadLine());
//bool isprime = true;
//for(int i = 2; i < number; i++)
//{
//    if (number % i == 0)
//    {
//        isprime = false;
//        break;
//    }
//}
//string res = isprime ? "prime number" : "not a prime number";
//Console.WriteLine(res);



//3.Write a program to print all prime numbers till target. (take target from user)

// 4. Write a program to print fibonacci series. 1 1 2 3 5 8 13 21…
//Console.WriteLine("enter the number");
//int number = int.Parse(Console.ReadLine());
//int a = 1, b = 2, c;
//for(int i = 3; i <= number; i++)
//{
//    c = a + b;
//    Console.WriteLine(a);
//    a = b;
//    b = c;
//}

//5. Write a program to find if a given string is palindrome.
//Console.WriteLine("enter the name");
//string ispailndrome = Console.ReadLine();   
//string res = string.Empty;
//for (int  i = ispailndrome.Length-1; i >= 0; i--)
//{
//    res = res + ispailndrome[i];
//}
//if (ispailndrome.ToLower() == res.ToLower())
//{
//    Console.WriteLine("It is a palindrome: " + res);
//}
//else
//{
//    Console.WriteLine( "not a pailndrome");
//}
// 7. Write a program to reverse a string. (without using reverse method)

//Console.WriteLine("enter the name");
//string revstring = Console.ReadLine();
//string rev = string.Empty;
//for(int i =revstring.Length-1;i>=0;i--)
//{
//    rev = rev + revstring[i];
//}
//Console.WriteLine(rev);

// 8.Write a program to reverse given array.
//int[] arr = new int[] { 1, 2, 3,4,5 };
//string rev = string.Empty;
//for (int i = arr.Length - 1; i >= 0; i--)
//{
//    rev += arr[i]; 
//}
//Console.WriteLine(rev);




//print 'THREE' if that number is divisbile by 3.
//	print 'FIVE' if that number is divisbile by 5.
//	print 'THREEFIVE' if that number is divisbile by 3 & 5 both.


//Console.WriteLine("enter the first number");
//int num1 = int.Parse(Console.ReadLine());
//if(num1 % 3 ==0 && num1 % 5 == 0)
//{
//    Console.WriteLine("'THREEFIVE' if that number is divisbile by 3 & 5 both. ");
//}else if(num1 % 3 == 0)
//{
//    Console.WriteLine("'THREE' if that number is divisbile by 3.");
//}else if(num1 % 5 == 0)
//{
//    Console.WriteLine("'FIVE' if that number is divisbile by 5.");
//}
//else
//{
//    Console.WriteLine("number is not divided by both number");
//}

//18. Write a program that takes two integers from the user and prints the largest one.
//Console.WriteLine("Enter the first number");
//int num1 = int.Parse(Console.ReadLine());
//Console.WriteLine("Enter the first number");
//int num2 = int.Parse(Console.ReadLine());
//if(num1 > num2)
//{
//    Console.WriteLine($" {num1 } num1 is greater than num 2");
//}
//else
//{
//    Console.WriteLine($" {num2} num2 is greater than num 1");
//}


//19. Write a C# program to check whether a given number is positive, negative, or zero.
//Console.WriteLine("Enter the number");
//int num1 = int.Parse(Console.ReadLine());

//if (num1 > 0)
//{
//    Console.WriteLine("positive number");
//}else if (num1 < 0)
//{
//    Console.WriteLine("negtaive number");
//}else if(num1 == 0){
//    Console.WriteLine("zero");
//}
//else
//{
//    Console.WriteLine("invalid number");
//}

//20. Use a for loop to print all even numbers from 1 to 20.
//for (int i = 2; i <= 20; i++) {
//    if (i % 2 == 0) {
//        Console.WriteLine($"even number is  {i}");
//    }
//}

//patterns

//1. Write a program to print the following pattern:
//for (int i = 1; i <= 5; i++)
//{
//    for (int j = 1; j <= i; j++)
//    {
//        Console.Write("* ");
//    }
//    Console.WriteLine();
//}
//Console.WriteLine("Enter the first number");
//int num1 = int.Parse(Console.ReadLine());
//Console.WriteLine("Enter the second number");
//int num2 = int.Parse(Console.ReadLine());
//int 
//j;
//for( int i = num1;i<=num2; i++)
//{
//    for ( j = 2; j <i; j++)
//    {
//        if (i % j == 0)
//            break;
//    }
//    if(i==j)
//        Console.WriteLine(j);


//}
//
//15.Write a program to find highest number from array.
//int[] number = new int[] {12,45,67,89,34,678,};
//int max = number[0];
//int min = number[0];
//for (int i = 1; i <= number.Length - 1; i++)
//{
//    if (number[i] > max)
//    {
//        max = number[i];
//    }
//    if (number[i] < min)
//    {
//        min = number[i];
//    }
//}
//Console.WriteLine(max);
//Console.WriteLine(min);

//21.Write a program that asks the user to enter a number and prints its multiplication table (from 1 to 10).
//Console.WriteLine("enter the number");
//int number = int.Parse(Console.ReadLine());
//for(int i =1; i <= 10; i++)
//{
//    Console.WriteLine($"{number} x {i} = {number*i}");

//}

//int[] arr = new int[] { 11, 2, 3, 44, 5,44,11,2 };    
//for (int i = 1; i <= arr.Length-1; i++)
//{
//    for (int j = 0; j < i; j++)
//    {
//        if (arr[i] == arr[j])
//        {
//            Console.WriteLine($"duplicate number is {arr[i]}");
//            break;
//        }
//    }

//}
//d duplicate number in array

//Console.WriteLine("Enter the number for check it dublictae or not");
//int number = int.Parse(Console.ReadLine());
//int[] ints = new int[] {12,45,56,78,98,5};
//for (int i = 0; i < ints.Length; i++)
//{
//    if (ints[i] == number)
//    {
//        Console.WriteLine("duplicate number is " + ints[i]);
//        break;
//    }
//    else
//    {
//        Console.WriteLine("not a duplicate number");
//    }
//}

//Console.WriteLine("Enter the number ");
//int number = int.Parse(Console.ReadLine());
//int fact = 1;
//for(int i = number; i >= 1; i--)
//{
//    fact *= i;
//}
//Console.WriteLine($"factorial of {number}  = {fact}");
//5. Write a program to find if a given string is palindrome.
//Console.WriteLine("enter the name");
//string name = Console.ReadLine();   
//string rev = string.Empty;

//for(int i = name.Length-1; i >= 0; i--)
//{
//    rev += name[i];
//}
//if(name.ToLower() == rev.ToLower())
//{
//    Console.WriteLine("pailndrome");
//}
//else
//{
//    Console.WriteLine("it is not a pailndrome");
//}

// 28/05/2025 pratice round

//2. Write a program to find whether the given input is prime or not.
//Console.WriteLine("enter the number");
//int number  = int.Parse(Console.ReadLine());
//bool isprime = true;
//for(int i = 2; i < number; i++)
//{
//    if (number % i == 0)
//        isprime = false;
//        break;
//}
//string result = isprime ? "prime" : "not prime";
//Console.WriteLine(result);

//3.Write a program to print all prime numbers till target. 
//(take target from user)

//Console.WriteLine("enter the number");
//int first  = int.Parse(Console.ReadLine());
//Console.WriteLine("enter the number");
//int second = int.Parse(Console.ReadLine());
//bool  isprime = true;
//int j;


//for(int i = first; i <= second; i++)
//{
//    for (j = 2; j < i; j++)
//    {
//        if(i % j == 0)
//        {
//            isprime = false;
//            break;
//        }


//    }
//    if (i == j)
//    {
//        Console.WriteLine(i);
//    }


//4. Write a program to print fibonacci series.
//1 1 2 3 5 8 13 21…
//Console.WriteLine("enter the number");
//int number= int.Parse(Console.ReadLine());


//int a = 1, b = 2, c;
//for(int i = 1; i <= number; i++)
//{
//    c = a + b;
//    Console.WriteLine(a);
//    a = b;
//    b = c;
//}

//5.Write a program to find if a given string is palindrome.

//Console.WriteLine("enter the string");
//string check = Console.ReadLine();  
//string rev = string.Empty;
//for(int i = check.Length-1; i >= 0; i--)
//{
//    rev = rev + check[i];
//}
//if(check == rev)
//{
//    Console.WriteLine("is pailndrome");
//}
//else
//{
//    Console.WriteLine("not a pailndrome");
//}

//int a = 12;
//int b = 13;
//int temp = 0;
//Console.WriteLine($"before swapping a = {a} b = {b}");
//temp = a + b;
//Console.WriteLine(a);
//a = b;
//b = temp;
//Console.WriteLine($"after swapping a = {a} b = {b}");
//int a = 12;
//int b = 13;
//int temp = 0;

//Console.WriteLine($"before swapping a = {a} b = {b}");
//temp = a;   
//a = b;
//b = temp;

//Console.WriteLine($"after swapping a = {a} b = {b}");

////13. Swap two numbers without using third variable.


//int x = 10;
//int y = 20;

//Console.WriteLine($"before swapping: a = {x}, b = {y}");


//x = x + y; //30
//y= x - y;//30-20 = 10
//x = x - y;//30-10 = 20


//Console.WriteLine($"After swapping: a = {x}, b = {y}");


//17.Write a program to find pairs from array whose sum is equal to 30.

//int [] arr = new int[] { 10, 20, 30, 40, 50,15,15, 60 };
//int target = 30;
//for (int i = 0; i < arr.Length - 1; i++)
//{
//    for (int j = i+1 ; j < arr.Length; j++)
//    {
//        if (arr[i] + arr[j] == target)
//        {
//            Console.WriteLine($"Pair found: {arr[i]} + {arr[j]} = {target}");
//        }
//    }
//}
//20. Use a for loop to print all even numbers from 1 to 20.
//for (int i = 1; i <= 20; i++)
//{
//    if (i % 2 == 0)
//    {
//        Console.WriteLine($"even number is {i}");
//    }
//}
//Console.WriteLine("Enter the number ");
//int number = int.Parse(Console.ReadLine());    
//int fact = 1;
//for(int i = number; i >= 1; i--)
//{
//    fact = fact * i;
//}
//Console.WriteLine(fact);

//25.Write a program that takes an array of 5 numbers and prints the sum and average.



//int[] arr = new int[] { 12, 343, 5, 232, 2 };
//int sum = 0;



//for (int i = 0; i <= arr.Length-1; i++) {
//    sum += arr[i];
//}
//double average  = (double)sum/ arr.Length;
//Console.WriteLine(sum);
//Console.WriteLine(average);

//int[] ints = new int[] {12,43,5,89,6,453,23, };
//int max = ints[0];
//int min = ints[0];
//int resut;
//for(int i = 1; i < ints.Length - 1; i++)
//{
//    if (ints[i] > max)
//        max = ints[i];  
//    if (ints[i] < min)
//        min = ints[i];


//}
//Console.WriteLine(max);
//Console.WriteLine(min);


Console.WriteLine("Enter the string");
string name = Console.ReadLine();   
string rev = string.Empty;  
for(int i = name.Length-1; i >= 0; i--)
{
    rev = rev + name[i];

    
}
if (name.ToLower() == rev.ToLower())
{
    Console.WriteLine("it is a pailndrome: " + rev);
}
else
{
    Console.WriteLine("it is not a pailndrome: " + rev);
}


    Console.Read();


















































