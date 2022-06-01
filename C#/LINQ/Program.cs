using System.Linq;
namespace LINQ
{
    class Program
    {
        public static void Main()
        {
            List<Beer> beers = new List<Beer>()
            {
                new Beer("Corona", "México"),
                new Beer("Delirium", "Bélgica"),
                new Beer("Erdinger", "Alemania"),
            };
            foreach(Beer beer in beers)
                Console.WriteLine(beer.ToString());

            Console.WriteLine(" *-------------- Selecciono de la lista original --------------* ");
            
            //select
            var beersName = from beer in beers
                            select new
                            {
                                Name = beer.Name,
                                Letters = beer.Name.Length,
                                Fixed = 1
                            };
            foreach (var beer in beersName)
                Console.WriteLine($"Nombre: {beer.Name} Letras: {beer.Letters} NúmFijo: {beer.Fixed}");

            Console.WriteLine(" *-------------- Selecciono del resultado anterior solo nombres --------------* ");

            //obtiene los datos del resultado anterior
            var beersNameReal = from beer in beersName
                                select new
                                {
                                    Name = beer.Name
                                };
            foreach (var beer in beersNameReal)
                Console.WriteLine($"Nombre: {beer.Name}");

            Console.WriteLine(" *-------------- Selecciono de la original las que son de México o Alemania --------------* ");

            //filta resultados
            var beersMéxico = from beer in beers
                              where beer.Country == "México" || beer.Country == "Alemania"
                              select new
                              {
                                  Name = beer.Name,
                                  Country = beer.Country,
                              };

            foreach(var beer in beersMéxico)
                Console.WriteLine($"Nombre: {beer.Name} Pais:{beer.Country}");

            Console.WriteLine(" *-------------- Ordeno la lista original en una nueva variable --------------* ");
            Console.WriteLine("                                 (Ascendente)");

            //ordena asendentemente la lista en una nueva variable
            var orderedByCountry = from beer in beers
                          orderby beer.Country
                          select new
                          {
                              Name = beer.Name,
                              Country = beer.Country,
                          };
            foreach(var beer in orderedByCountry)
                Console.WriteLine($"Nombre: {beer.Name} Pais:{beer.Country}");

            Console.WriteLine(" *-------------- Ordeno la lista original en una nueva variable --------------* ");
            Console.WriteLine("                                 (Descendente)");

            //ordena desendentemente la lista en una nueva variable
            var orderedByCountryDesc = from beer in beers
                                   orderby beer.Country descending
                                   select new
                                   {
                                       Name = beer.Name,
                                       Country = beer.Country,
                                   };
            foreach (var beer in orderedByCountryDesc)
                Console.WriteLine($"Nombre: {beer.Name} Pais:{beer.Country}");

        }
        class Beer
        {
            public string Name { get; set; }
            public string Country{ get; set; }

            public Beer(string name, string country)
            {
                Name = name;
                Country = country;
            }
            public override string ToString()
            {
                return $"Nombre: {Name} Pais:{Country}";
            }
        }

    }
}