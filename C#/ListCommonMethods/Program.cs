// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var Numbers = new List<int>()
{
    1, 2, 23, 24, 5, 43, 7, 11, 12, 10
};

ShowNumbers(Numbers);

//inserta con un indice, el número.  (index, value)
Numbers.Insert(0, 100);

ShowNumbers(Numbers);


//contains, para verificar si existe en la lista
bool result = Numbers.Contains(100);
if (result)
    Console.WriteLine("Existe el número 100");
else
    Console.WriteLine("No existe el número 100");

//indexOf, obtiene el indice de un elemento en la lista
int index  =Numbers.IndexOf(100);
Console.WriteLine($"El índice del número 100 es: {index}");

index = Numbers.IndexOf(200);
Console.WriteLine($"El índice de un número que no está en la lista siempre es: {index}");


//sort, para ordenar la lista, estas listas son mutables, se cambian al invocar el metodo
Numbers.Sort();
Console.WriteLine("Números ordenados...");
ShowNumbers(Numbers);

//la cadena no es mutable como una lista
string cadena = "Mi nombre";
cadena.ToUpper();
Console.WriteLine("la cedena no es mutable, por eso persiste a menos que se reasigne explicitamente...");
Console.WriteLine(cadena);
Console.WriteLine("de la siguiente manera..");
cadena = cadena.ToUpper();
Console.WriteLine(cadena);

//add range, para añadir varios elementos de una sola vez
Numbers.AddRange(new List<int>()
{
    3, 2, 1, 4, 0
});
Console.WriteLine("Al mostrar los datos, vemos que se añadieron al final y no están ordenados");
ShowNumbers(Numbers);

var otralista = new List<int>()
{
    1, 2, 3, 4, 100
}; //la lista ya puede estár creada para añadir en rango, osea otra lista

Numbers.AddRange(otralista);
ShowNumbers(Numbers);

void ShowNumbers(List<int> numbers)
{
    Console.WriteLine("  -- Números --");
    foreach (var number in Numbers)
    {        
        Console.WriteLine(number);
    }
}



