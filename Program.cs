namespace IMAT_GitTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Divide(2, 8));
        }


        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static double Multiply(int x, int y)
        {
            return x * y;
        }

        public static int Divide(int x, int y)
        {
            return x / y;
        }
    }

}
