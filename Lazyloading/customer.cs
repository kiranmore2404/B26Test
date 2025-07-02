public class order
{
    public int id { get; set; }
    public string description { get; set; }
}



public class customer
{
    public string  Name { get; set; }

    //public Lazy< List<order>> orders { get; set; } 
    public List<order> orders { get; set; }

    public customer()
    {
        Name = "vishal";

   
        //orders = new Lazy<List<order>>(() => GetOrders());
    }


    public List<order> GetOrders()
    {
        return new List<order>()
        {
            new order() { id = 1, description = "order 1" },
            new order() { id = 2, description = "order 2" },
            new order() { id = 3, description = "order 3" }
        };
    }
    public void printorder()
    {
        orders = GetOrders(); // Initialize orders here
        foreach (var o in orders)
        {
            Console.WriteLine($"Order ID: {o.id}, Description: {o.description}");
        }

    }
}