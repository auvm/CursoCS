namespace SobreCarga
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();
            Console.WriteLine(math.sum(3, 5));
            Console.WriteLine(math.sum("3", "5"));

            int[] numbers = new int[] { 1, 2, 3, 4 };
            Console.WriteLine(math.sum(numbers));
        }


    }


    class Math
    {
        public int sum(int a, int b)
        {
            return a + b;
        }
        public int sum(string a, string b)
        {
            return int.Parse(a) + int.Parse(b);
        }
        public int sum(int a, int b, int c)
        {
            int sum = a + b + c;
            return sum;
        }

        public int sum(int[] numbers)
        {
            int result = 0;
            for (int i = 0; i < numbers.Length; i++)
                result += numbers[i];
            return result;
        }
    }
}