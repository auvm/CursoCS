// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Esto es una tupla
(int id, string name) product = (1, "cerveza stout");

//Puedo acceder a sus valores y modificarlos como si fuera
//un objeto.
Console.WriteLine($"ID: {product.id} Nombre: {product.name}");

product.name = "Fuck U";

Console.WriteLine($"ID: {product.id} Nombre: {product.name}");

//para crear una tupla de una forma más fácil

var person = (1, "Uriel", "Velasco");

//como no tienen nombre los valores definidos, accedemos por el número
//de ItemX
Console.WriteLine($"Id: {person.Item1} Nombre: {person.Item2} " +
                  $"Apellido: {person.Item3}");

var people = new[]
{
    (1, "uriel"),
    (2, "miguel"),
    (3, "angel")
};

foreach (var item in people)
{
    Console.WriteLine($"Id: {item.Item1} Nombre: {item.Item2}");
}



//puedo hacer que un método regrese más de un valor utilizando tuplas
(float lat, float lng, string name) getLocationCDMX()
{
    float lat = 19.12121f;
    float lng = -99.1912f;
    string name = "CDMX";
    //de esta forma regresa tres valores
    return(lat, lng, name);
}


//ahora, invoco para ejemplificar el retorno de varios valores

var cityInfo = getLocationCDMX();
Console.WriteLine($"Coordenadas: {cityInfo}");


//también podemos obviar valores si solo nos importa uno en particular
var (_, lng, _) = getLocationCDMX();
//utilizas guión bajo para ignorar los valores retornados
//que no importan
Console.WriteLine($"Solo longitud: {lng}");
