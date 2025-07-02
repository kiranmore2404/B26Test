public class Trainer
{
    public int Id { get; set; }

    public string Name { get; set; }

    public int Experience { get; set; }



    public static List<Trainer> GetAll()

    {

        return new List<Trainer>()

        {

            new Trainer(){ Id = 1, Name = "vikul", Experience = 14},

            new Trainer(){ Id = 2, Name = "usha", Experience = 3},

            new Trainer(){ Id = 3, Name = "atul", Experience = 4}

        };

    }

}
