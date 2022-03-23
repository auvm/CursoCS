// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


var auvm = new
{
    Name = "Uriel",
    country = "México"
};

Console.WriteLine(auvm);

//como objeto anónimo no se puede cambiar sus datos, es solo lectura.
//ESTO NO SE PUEDE HACER
//auvm.Name = "Fuck";

//También se pueden hacer arreglos anónimos
var beers = new[]
{
    new { Name = "red", Brand = "Delirius"},
    new { Name = "London Porter", Brand="Fullers"}
};

foreach (var beer in beers)
{
    Console.WriteLine($"Cerveza: {beer.Name} Marca: {beer.Brand}");
}