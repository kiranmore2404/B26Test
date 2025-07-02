public interface IA
{

    void print();
    void printA();
}
public interface IB
{
    void print();
    void printB();
}

public class A : IA,IB
{
   


    //public void print()
    //{
    //    Console.WriteLine("A printed from print method");

        //}

    public void printA()
    {
        Console.WriteLine("A printed");
    }

    public void printB()
    {
        Console.WriteLine("B printed");

    }

    void IA.print()
    {
        Console.WriteLine("A printed from IA interface print method");

    }

    void IB.print()
    {
        Console.WriteLine("A printed from IB interface print method");

    }
}