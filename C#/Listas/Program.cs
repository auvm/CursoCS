// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//Para crear una lista
//Se pone el generico con el tipo de elemento que contendrá

List<int> numbers = new List<int>();

numbers.Add(1);
numbers.Add(2);
numbers.Add(3);

Console.WriteLine("Números en la lista numbers: "+numbers.Count);

//También se pueden inicializar y seguir agregando

List<int> numbers2 = new List<int>()
{
    1, 2, 3, 4, 5, 6, 7, 8, 9, 10
};

Console.WriteLine("Números en la lista numbers2: "+numbers2.Count);

//Para limpiar la lista

numbers2.Clear();
Console.WriteLine("Números en la lista numbers2: " + numbers2.Count);

List<string> countries = new List<string>();

countries.Add("México");
countries.Add("Chile");
countries.Add("Brasil");
countries.Add("España");

Console.WriteLine("Lista de paises:");
foreach (var item in countries)
{
    Console.WriteLine(item);
}
Console.WriteLine($"Total de paises: {countries.Count}");

