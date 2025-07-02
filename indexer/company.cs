public class company
{
    public string name { get; set; }
    employe[] _employes;
    public company(employe[] emps )
    {
        _employes = emps;

    }

    public string this[int id]
    {
        get
        {
            foreach(employe e in _employes)
            {
                if(e.id == id)
                {
                    return e.name;
                }
            } return "Notx";
        }
        set
        {
            foreach(employe e in _employes)
            {
                if(e.id == id)
                {
                    e.name = value;
                    return;
                }
            }
        }
    }
    public void detail()
    {
        Console.WriteLine("$Company Name: {0}", name);

        Console.WriteLine(" ******Employes***** ");

        foreach (var emp in _employes)
        {
            Console.WriteLine("Id: {0}, Name: {1}, City: {2}", emp.id, emp.name, emp.city);
        }
    }

}

