Console.WriteLine("welcome to coffee shop");
int cofee = 0;
int milk = 0;
int tea = 0;
string choice1 = string.Empty;
do
{
    Console.WriteLine("what would you like to have");
    Console.WriteLine($"1. cofeee 10Rs 2. milk 20Rs 3. Tea 30Rs");
    int choice = int.Parse(Console.ReadLine());
    switch (choice)
    {
        case 1:
            Console.WriteLine($"how much cofee");
            cofee += int.Parse(Console.ReadLine());
            Console.WriteLine($"you ordered {cofee} cofee");

            break;
        case 2:
            Console.WriteLine($"how much milk");
            milk += int.Parse(Console.ReadLine());
            Console.WriteLine($"you ordered {milk} cofee");
            break;

        case 3:
            Console.WriteLine($"how much milk");
            tea += int.Parse(Console.ReadLine());
            Console.WriteLine($"you ordered {tea} cofee");
            break;
        default:
            Console.WriteLine($"invalid choice");
            break;

          
    }
    Console.WriteLine("do you want cintinue");
    choice1 = Console.ReadLine().ToUpper();

} while (choice1 == "YES" || choice1 == "Y");

int total = 0;
if(cofee>0 || milk>0|| tea > 0)
{
    Console.WriteLine("******* bill *******");
    if (cofee >0)
    {
        Console.WriteLine($"cofee {cofee} * 10 = {cofee * 10}");
    }
    if (milk > 0)
    {
        Console.WriteLine($"milk {milk} * 20 = {milk * 20}");
    }
    if (tea > 0)
    {
        Console.WriteLine($"tea {tea} * 30 = {tea * 30}");
    }
    total = (cofee * 10) + (milk * 20) + (tea * 30);
    Console.WriteLine($"total amount is {total}");
    Console.WriteLine($"thank you for visiting");
}