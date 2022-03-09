
class Program
{

    static void Main(string[] args)
    {
        Sale mySale = new Sale(100, DateTime.Now);
        mySale.Total = 2;
        Console.WriteLine(mySale.Total);
        
    }
}
class Sale
{
    private int total;

    DateTime date;


    public int Total { 
        get { return total; }
        set { 
            if (value < 0)
                value = 0;
            total = value;
        }
    }

    public DateTime Date
    {
        get{
            return date;
        }
    }

    public Sale(int total, DateTime date)
    {
        this.total = total;
        this.date = date;
    }
}