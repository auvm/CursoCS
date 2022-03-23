// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


var Numbers = new List<int>()
{
    1, 2, 3, 4, 5, 6, 7, 8, 9, 10
};

foreach(var number in Numbers)
{
    Console.WriteLine(number);
}

string cadena = "Fuck the system 32!";

foreach(var letra in cadena)
    Console.Write(letra);


var myPeople = new People[]
{
    new People("Miguel", "México"),
    new People("Angel", "Oaxaca"),
    new People("Porfirio", "Sonora")
};

ShowPeople(myPeople);


void ShowPeople(People[] people)
{
    Console.WriteLine("\n\t--Personas--\t");
    foreach(var person in people)
    {
        Console.WriteLine($"Nombre: {person.Name}, Pais: {person.Country}");
    }
}

class People
{
    public string Name { get; set; }
    public string Country { get; set; }

    public People(string name, string country)
    {
        Name = name;
        Country = country;
    }
}