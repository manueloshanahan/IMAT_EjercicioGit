namespace IMAT_GitTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Subtract(2, 0));
        }


        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static double Multiply(int x, int y)
        {
            return x * y;
        }

        public static int Subtract(int x, int y)
        {
            return x - y;
        }
    }
}
