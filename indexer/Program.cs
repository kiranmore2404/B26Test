using System.Data;

employe[] employes = new employe[]
{
    new employe(){ id = 1, name = "John Doe", city = "New York" },
     new employe(){ id = 2, name = "Jane Smith", city = "Los Angeles" },

};
company tcs = new company(employes) { name = "TaTa"};
tcs.detail();
string name = tcs[3];
Console.WriteLine("Employe with ID 3: {0}", name);
tcs[1] = "kiran";
Console.WriteLine("Employe with ID 1: {0}", tcs[1]);

Console.Read();