// See https://aka.ms/new-console-template for more information
using System.Text.Json;


Beer beer1 = new Beer("Pikatus", "Erdinger");
//Así se rerpesenta un objeto en formato Json:
//string json = "{\"Atributo1\": \"Valor1\", \"Atributo2\": \"Valor2\"}";

string json = "{\"Name\":\"Pikatus\",\"Brand\":\"Erdinger\"}";

//Un arreglo en formato Json es así:
string json2 = "[" +
    //notar que también lleva coma , para separar los objetos
    "{\"Name\": \"Pikatus\", \"Brand\": \"Erdinger\"}," + 
    "{\"Name\": \"Victoria\", \"Brand\": \"Modelo\"}" +
    "]";


//EJEMPLOS
Console.WriteLine("\n\tEjemplos!\t\n");
//Serialización
Console.WriteLine("Escrito por mi: ");
Console.WriteLine(json);

Console.WriteLine(" *** Objeto serializado ***");
string jsonSerializado = JsonSerializer.Serialize(beer1);
Console.WriteLine(jsonSerializado);


//Deserialización

Beer beerDeserializado = JsonSerializer.Deserialize<Beer>(jsonSerializado);
Console.WriteLine(" *** Objeto deserializado ***");
Console.WriteLine(beerDeserializado);


Console.WriteLine("\n\tEjemplo con un Arreglo\t\n");
//Ejemplo con un arreglo
//como el serializador funciona con genericos, debemos especificar que se trata de un arreglo de Beer's
Beer[] beerArray = new Beer[]
{
    new Beer("Pikatus", "Erdinger"),
    new Beer("Corona", "Modelo"),
    new Beer("Boing", "Pascual"),
    new Beer("Jumex de mango", "Jumex")
};

Console.WriteLine(" *** Areglo de bebidas ***");
foreach(Beer beer in beerArray)
    Console.WriteLine(beer);
Console.WriteLine(" *** Areglo de bebidas serializado ***");
string beerArraySerializado = JsonSerializer.Serialize(beerArray);
Console.WriteLine(beerArraySerializado);
Console.WriteLine(" *** Areglo de bebidas deserializado ***");
Beer[] beerArrayDeserializado = JsonSerializer.Deserialize<Beer[]>(beerArraySerializado);
foreach (Beer beer in beerArrayDeserializado)
    Console.WriteLine(beer);

public class Beer
{
    public string Name { get; set; }
    public string Brand { get; set; }

    public Beer() { }
    public Beer(string name, string brand)
    {
        Name = name;
        Brand = brand;
    }

    public override string ToString()
    {
        string cadena = $"Nombre: {Name}\nMarca: {Brand}";
        return cadena;
    }
}
