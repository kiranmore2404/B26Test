public class customer
{
    public string firstname;
    public string lastname;
    public customer(string firstname, string lastname)
    {
        this.firstname = firstname;
        this.lastname = lastname;
    }

    public bool isvalid()
    {
        return !string.IsNullOrEmpty(firstname) &&
               !string.IsNullOrEmpty(lastname);
    }
    public void insert()
    {
        if (isvalid())
        {
            Console.WriteLine("Customer inserted successfully.");
        }
        else
        {
            Console.WriteLine("Invalid customer data. Please provide valid first and last names.");
        }
    }
}
