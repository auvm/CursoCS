// See https://aka.ms/new-console-template for more information
class Program
{
    public static void Main(string[] args)
    {
        MyList<int> numbers = new MyList<int>(3);
        numbers.Add(1);
        numbers.Add(2);
        numbers.Add(3);
        Console.WriteLine(numbers);

        MyList<string> strings = new MyList<string>(4);
        strings.Add("Angel");
        strings.Add("Uriel");
        strings.Add("Velasco");
        strings.Add("Mejia");
        Console.WriteLine(strings);

        Console.WriteLine("Indice 11 de numbers: " + numbers.GetElement(11));
        Console.WriteLine("Indice 2 de strings: " + numbers.GetElement(2));
        Console.WriteLine("Indice 0 y 1 de strings: ");
        Console.Write(strings.GetElement(0));
        Console.Write(strings.GetElement(1));

        Console.WriteLine();
        Console.WriteLine(numbers.GetString());
        Console.WriteLine(strings.GetString());

        MyList<People> myPeople = new MyList<People>(2);
        myPeople.Add(new People("Angel", "México"));
        myPeople.Add(new People("Miguel", "Germany"));
        Console.WriteLine(myPeople.GetString());
    }

}

public class People
{
    public string Name { get; set; }
    public string Country { get; set; }

    public People(string name, string country)
    {
        Name = name;
        Country = country;
    }
    public override string ToString()
    {
       
        return $"Nombre: {Name}  País: {Country}";
    }
}

public class MyList<T>
{
    private T[] _elements;
    private int _index = 0;

    public MyList(int n)
    {
        _elements = new T[n];
    }

    public void Add(T e)
    {
        if (_index < _elements.Length)
        {
            _elements[_index] = e;
            _index++;
        }
    }
    public override string ToString()
    {
        string s = string.Empty;
        foreach (var item in _elements)
        {
            s += item + ", ";
        }
        return s;
    }

    public T GetElement(int i)
    {
        if(i < _index && i >= 0)
        {
            return _elements[i];
        }else
            return default(T);
    }

    public string GetString()
    {
        string result = "";
        foreach (var item in _elements)
        {
            result += item + " | ";
        }
        return result;
    }
}