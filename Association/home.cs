//public class room
//{
//    public string roomtype {  get; set; }
//    public int destination {  get; set; }


//}


//public class Home
//{
//    public room[] romms { get; set; }
//    public Home()
//    {
//        romms = new room[] {
//            new room() { roomtype = "1BHK", destination = 10 },
//            new room() { roomtype = "2bhk", destination = 10 }


//        };
//        foreach (var r in romms)
//        {
//            Console.WriteLine("Room Type: {0}, Destination: {1}", r.roomtype, r.destination);

//        }

//    }
//}
public class employe
{
    public int Id { get; set; }
    public string Name { get; set; }

   
}


public class depatment
{
    public employe[] employes { get; set; }

    public void printemployee()
    {
        employes = new employe[] {
            new employe { Id = 1,Name = "kiran" },
            new employe { Id = 2,Name = "kishor" }
            
        };
        foreach (var item in employes)
        {
            Console.WriteLine("ID: {0}, Name: {1}", item.Id, item.Name);


        }

    }
 
    
}