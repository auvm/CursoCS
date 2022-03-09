// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int op = -0;

switch (op)
{
    case 1:
        Console.WriteLine("seleccionaste 1");
        break;
    case 2:
        Console.WriteLine("seleccionaste 2");
        break;
    case 3:
        Console.WriteLine("seleccionaste 3");
        break;
    case 4:
        Console.WriteLine("seleccionaste 4");
        break;
    case > 5 and <= 10:
        Console.WriteLine("Seleccionaste entre 5 y 10");
        break ;
    case > 10 and < 100:
        Console.WriteLine("Seleccionaste entre 10 y 100");
        break;
    case < -1 or 0:
        Console.WriteLine("Seleccionaste 0 o uno menor");
        break;
    default: Console.WriteLine("Inválido");
        break;
}