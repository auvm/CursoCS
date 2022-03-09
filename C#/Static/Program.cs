// See https://aka.ms/new-console-template for more information

People people1 = new People()
{
    Name = "Uriel",
    Age = 19
};
People people2 = new People()
{
    Name = "Miguel",
    Age = 20
};
People people3 = new People()
{
    Name = "Eduardo",
    Age = 18
};

//Ejemplos de que los elementos estaticos se acceden directamente
//desde la clase
Console.WriteLine(People.Count);
Console.WriteLine(People.GetCount());


public class People
{
    //al hacer un atributo/propiedad statico se le agrega a la clase
    // no a los objetos, ahora Count pertenece a People en general.
    public static int Count = 0;
    public string Name { get; set; }
    public int Age { get; set; }

    public People()
    {
        //los elentos estaticos se pueden acceder directamente en cualquier
        //parte de la clase a la que pertenece
        Count++;
    }

    //También se pueden hacer a los métodos estaticos, de manera que se accedan
    //directamente desde en nombre de la clase
    public static string GetCount()
    {
        return $"La clase People se ha utilizado {Count} veces.";
    }
}