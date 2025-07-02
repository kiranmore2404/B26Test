public class employee {
    public string firstname;
    public string lastname;
    

    public  virtual void print()
    {
        Console.WriteLine($"fullName : {firstname} {lastname}");
    }

}