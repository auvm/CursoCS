// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int i = 0;
while(i < 10)
{
    Console.WriteLine("Iteración de i: " + i);
    i++;
}

int j = 0;

while (j < 100)
{
    if (j > 10)
        break;
    Console.WriteLine("Iteración de j: " + j);
    j++;
}

string[] friends = new string[7];
friends[0] = "fuck ";
friends[1] = "the ";
friends[2] = "system ";
friends[3] = "32";
friends[4] = "!";
friends[5] = null;
friends[6] = null;

int index = 0;
while(index < 7)
{
    Console.Error.WriteLine(friends[index]);
    index++; 
}

bool go = false; 
do
{
    Console.Error.WriteLine("Entro una vez y ya!");
}while(go);