//Console.WriteLine("enter the number");
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
//string result = isprime ? "prime" : "not prime";
//Console.WriteLine(result);

Console.WriteLine("enter the first number");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("enter the target number");
int traget = int.Parse(Console.ReadLine());
bool isprime = true;
for(int i  =num1; i < traget; i++)

{
    if(num1%traget == 0)
    {
        isprime = false;
        break;
    }
    if(num1 == traget)
    {
        isprime = true;
    
    }

    Console.WriteLine(traget);





}




Console.Read();


