// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//class Test
//{
//    static void Main(string[] args)
//    {
//        Objeto o = new Objetito();
//        Console.WriteLine(o);
//    }
//}

//class Objeto
//{
//    public override string ToString()
//    {
//        return "Objeto";
//    }
//}

//class Objetito : Objeto
//{
//    public override string ToString()
//    {
//        return "Objetito";
//    }
//}

//class MainClass
//{
//    public static void Main(string[] args)
//    {
//        int[] a = new Int32[] { 6, 4, 3, 5, 63, 2 };
//        foreach (object o in a)
//        {
//            Console.Write(o + ", ");
//        }
//    }
//}

using System;

class Test
{
    static void Main(string[] args)
    {
        Console.WriteLine(new Objeto("yikes"));
    }
}

class Objeto
{
    string s;
    public Objeto(string s)
    {
        this.s = s;
    }

    public override string ToString()
    {
        return "s";
    }
}