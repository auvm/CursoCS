// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

bool areYouHungry = true;
bool youHaveMoney = true;
if (areYouHungry && youHaveMoney && IsOpenRestaurant("Lonches pepes", 11))
{
    Console.WriteLine("Come come");

}
else
{
    Console.WriteLine("Pues no comes");
}

static bool IsOpenRestaurant(string name, int hour = 0)
{
    if(name == "Lonches pepes" && hour > 8 && hour < 23)
    {
        return true;
    }
    else if(name =="Restaurant 24 horas")
    {
        return true;
    }
    else
    {
        return false;
    }
}