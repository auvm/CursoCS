// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] agrs)
    {
        B b = new B();
        Console.WriteLine(b.Hi());

        Sale sale = new Sale(10);
        sale.Add(97);
        sale.Add(3);
        Console.WriteLine(sale.GetTotal());

        SaleWithTax saleWithTax = new SaleWithTax(10, 0.16m);
        saleWithTax.Add(97);
        saleWithTax.Add(3);
        Console.WriteLine(saleWithTax.GetTotal());
    }

    public class Sale
    {   //privado solo lo puede utilizar la clase
        private decimal[] _amounts;
        private int _n;
        private int _end;

        public Sale() { }
        public Sale(int n)
        {
            _amounts = new decimal[n];
            _n = n;
            _end = 0;
        }

        public void Add(decimal amount)
        {
            if (_end < _n)
            {
                _amounts[_end] = amount;
                _end++;
            }
        }
        public virtual decimal GetTotal()
        {
            decimal result = 0;
            int i = 0;
            while(i < _amounts.Length)
            {
                result += _amounts[i];
                i++;
            }
            return result;
        }
    }
    public class SaleWithTax : Sale
    {
        private decimal _tax;
        public SaleWithTax() { }
        //se debe crear el contructor que solicita el padre
        public SaleWithTax(int n, decimal tax) : base(n)
        {
            _tax = tax;
        }
        public override decimal GetTotal()
        {   
            //Extiende la funcionalidad del padre, solicitando el total
            //para no tener que programar como se calcula y ya solo
            //regresa el valor del impuesto sobre el total 
            //en este caso 16%
            return base.GetTotal() * 0.16m;
        }
    }
    public class A
    {
        public virtual string Hi()
        {
            return "Hola soy A";
        }
    }
    public class B : A
    {
        public override string Hi()
        {
            //Para ampliar la funcionalidad del padre, se invoca al método del padre
            //con "base.el_metodo_padre() luego añades la extensión"
            //sino amplia funcionalidad solo sobre escibe la nueva funcionalidad
            return base.Hi() + "\nHola soy B";
        }
    }
}
