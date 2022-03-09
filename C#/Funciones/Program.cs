// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int a = 1;
int b = 2;

int c = a + b;
int d = a + b;
show();
show();
show();
show();
sum(a, b);
Console.WriteLine(Mul(a, b));

static int Mul(int a, int b)
{
    return a * b;
}
static void sum(int a, int b)
{
    System.Console.WriteLine(a + b);
}
static void show()
{
    Console.WriteLine("Hola soy un texto que se imprime desde función show");
}