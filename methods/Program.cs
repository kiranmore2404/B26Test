
string getmessage()
{
    return "welcome to vihan classes";
}
Console.WriteLine(getmessage());

string getmessage2(string name)
{
    return $"welcome : {name}";
}
Console.WriteLine(getmessage2("kishor"));

void print(string fn ,string ln)
{
    Console.WriteLine($"first name is {fn} and last name is {ln}");
}
print("kishor", "more");

bool iseven(int num)
{
    if (num % 2 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }

}
bool result = iseven(10);
Console.WriteLine($"result is {result}");


Console.Read();
