class Program
{
    //To create a personalize exception, just got to create a class that inherit from
    //class exception, then you can implementen one of his methods, 
    //for example, for print the mesagge that describes the error
    public static void Main()
    {
        //this is an example
        //comment or uncomment one of is properties and
        //it will throw the exception
        try
        {
            Beer beer = new Beer()
            {
             //   Name = "London Porter",
                Brand = "Fuller's"
            };
            Console.WriteLine(beer);
        }
        catch (InvalidBeerException ex)
        {
            Console.WriteLine(ex.Message);
        }       
        
    }

    public class InvalidBeerException : Exception
    {
        public InvalidBeerException() :
            base("La cerveza no tiene nombre o marca, por lo cual es invalida.")
        {

        }

    }

    public class Beer
    {
        public string Name { get; set; }
        public string Brand { get; set; }

        public override string ToString()
        {
            if (Name == null || Brand == null)
                throw new InvalidBeerException();
            return $"Nombre: {this.Name}, Brand: {this.Brand}";
        }
    }
}