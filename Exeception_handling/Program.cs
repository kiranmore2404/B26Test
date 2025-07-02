using System;

try
{
    Console.WriteLine("Please enter numerator");
    int num = int.Parse(Console.ReadLine());

    Console.WriteLine("Please enter denominator");
    int den = int.Parse(Console.ReadLine());

    try
    {
        calculator c1 = new calculator();
        c1.division(num, den);

    }
    catch (Exception ex)
    {
        Console.WriteLine($"outer catch : {ex.Message}");
    }
}
catch (FormatException ex)
{
    Console.WriteLine($"outer catch {ex.Message}");

}
catch (OverflowException ex)
{
    Console.WriteLine($"outer catch {ex.Message}");

}

Console.Read();





