
emploee e1 = new emploee();
e1.print(12,43);
e1.print("kiran");
e1.print("kiran",03);


Console.Read();

public class emploee
{
    public void print()
    {
        Console.WriteLine("print()");

    }
    public void print(string s) { Console.WriteLine(s); }
    public void print(int  i) { Console.WriteLine(i); }
    public void print(int a, int b)
    {
        Console.WriteLine($" {a} + {b} = { a+b}");

    }
    public void print(int a, int b, int c)
    {
        Console.WriteLine($" {a} + {b} + {c} = { a + b + c}");
    }
    public void print(int a, int b, int c, int d)
    {
        Console.WriteLine($" {a} + {b} + {c} + {d} = { a + b + c + d}");
    }

    public void print(string s, int i)
    {
        Console.WriteLine($" {s} + {i} = {s + i}");
    }   
    public void print(int i, string s)
    {
        Console.WriteLine($" {i} + {s} = {i + s}");
    }

    //    public string print()


    //public void prints()
    //{
    //    Console.WriteLine(print());

    //}




}
