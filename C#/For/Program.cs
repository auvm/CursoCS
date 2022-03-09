// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string[] friends = new string[7];
friends[0] = "fuck ";
friends[1] = "the ";
friends[2] = "system ";
friends[3] = "32";
friends[4] = "!";
friends[5] = null;
friends[6] = null;

for(int i = 0; i < 7; i++)
{
    Console.WriteLine(friends[i]);
}

bool condition = false;
for (int i = 0; i < 7 && condition; i++)
{
    Console.WriteLine(friends[i]);
}