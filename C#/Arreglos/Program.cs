// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//Un arreglo es una variable que puede almacenar una coleeción de variables

//arreglo de strings
string[] friends = new string[7];
friends[0] = "fuck ";
friends[1] = "the ";
friends[2] = "system ";
friends[3] = "32";
friends[4] = "!";
friends[5] = null;
friends[6] = null;


foreach (var friend in friends)
{
    Console.Write(friend); 
}