//Console.WriteLine("welcome to coffee Shop");
//int tea = 0;
//int milk = 0;
//int coffee = 0;

//string choice = string.Empty;

//do 
//{
//         Console.WriteLine("what would you like to have");
//         Console.WriteLine($" 1 : TEA 2 : MILK 3 :COFFEE");
//          int select = int.Parse(Console.ReadLine());
//    switch (select)
//    {
//        case 1:
//            Console.WriteLine($"how much tea");
//            tea += int.Parse(Console.ReadLine());
//            Console.WriteLine($"you ordered {tea} tea");
//            break;
//        case 2:
//            Console.WriteLine($"how much milk");
//            milk += int.Parse(Console.ReadLine());
//            Console.WriteLine($"you ordered {milk} milk");
//            break;
//        case 3:
//            Console.WriteLine($"how much coffee");
//            coffee += int.Parse(Console.ReadLine());
//            Console.WriteLine($"you ordered {coffee} cofee");
//            break;
//        default:
//            Console.WriteLine("invalid order");
//            break;
//    }
//       Console.WriteLine("do you want continue");
//      choice = Console.ReadLine().ToLower();
//} while (choice == "yes" || choice == "y");

//int total = 0;
//if (tea>0 || milk>0 || coffee>0)
//{
//    Console.WriteLine("******* bill *******");
//    if (tea > 0 )
//    {
//        Console.WriteLine($"TEA {tea} * 10 = {tea * 10}");
//    }
//    if (milk > 0)
//    {
//        Console.WriteLine($"MILK {tea} * 10 = {milk * 20}");
//    }
//    if (coffee > 0)
//    {
//        Console.WriteLine($"cofee {coffee} * 10 = {coffee * 30}");
//    }
//    total = (tea*10 ) + (milk*20) + (coffee*30);
//    Console.WriteLine($"total amount is {total}");
//    Console.WriteLine($"thank you for visiting");
//}




Console.Read();
