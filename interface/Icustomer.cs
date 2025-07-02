public interface Icustomer {
    int getticketAmount();
    void printticket();
    public int printticketanount { get; set; }

    public void kk();

}

public class Silvercustomer : Icustomer
{
    private int _printticketanoun;
    public int printticketanount
    {
        get { return printticketanount; }
        set { printticketanount = value; }
    }

    public int getticketAmount()
    {
        return 150;
    }

    public void kk()
    {
        Console.WriteLine("kk method called ()");
    }

    public void printticket()
    {
        Console.WriteLine("silver ticket printed");
    }
}
public class Goldcustomer : Icustomer
{
    private int _printticketanoun;
    public int printticketanount
    {
        get { return printticketanount; }
        set { printticketanount = value; }
    }

    int Icustomer.printticketanount { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public int getticketAmount()
    {
        return 250;
    }
    public void printticket()
    {
        Console.WriteLine("gold ticket printed");
    }

    int Icustomer.getticketAmount()
    {
        throw new NotImplementedException();
    }

    void Icustomer.kk()
    {
     
    }

    void Icustomer.printticket()
    {
        Console.WriteLine();
    }
}

