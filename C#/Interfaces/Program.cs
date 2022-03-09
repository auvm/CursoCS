class Program
{
    public static void Main(string[] args)
    {
        Shark[] sharks = new Shark[]
        {
        new Shark("tiburonsin", 89),
        new Shark("pepe zorro", 10),
        };


        IFish[] fishs = new IFish[]
        {
            new Sirena(1000),
            new Shark("pepe botella", 200)
        };

        ShowFish(sharks);
        ShowAnimal(sharks);

        ShowFish(fishs);

    }


    public static void ShowFish(IFish[] fishs)
    {
        Console.WriteLine(" - Mostrando los peces - ");
        int i = 0;
        while(i < fishs.Length)
        {
            Console.WriteLine(fishs[i].Swim());
            i++;
        }
    }
    public static void ShowAnimal(IAnimal[] animals)
    {
        Console.WriteLine(" - Mostrando a los animales - ");
        int i = 0;
        while (i < animals.Length)
        {
            Console.WriteLine($"Se llama: {animals[i].Name}");
            i++;
        }
    }
    public class Sirena : IFish
    {
        public Sirena(int speed)
        {
            Speed = speed;
        }
        public int Speed { get; set; }
        public string Swim()
        {
            return $"La Sirena nada a {Speed} Km/h.";
        }
    }
    public class Shark : IAnimal, IFish
    {
        public string Name { get; set; }
        public int Speed { get; set; }

        public Shark(string name, int speed)
        {
            this.Name = name;
            this.Speed = speed;
        }
        public string Swim()
        {
            return $"El {Name} nada a {Speed} Km/h.";
        }

    }

    public interface IAnimal
    {
        public string Name { get; set; }
    }

    public interface IFish
    {
        public int Speed { get; set; }
        public string Swim();
    }
}
