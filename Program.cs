namespace IMAT_GitTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Divide(2, 4));
            Console.WriteLine(Subtract(2, 4));
        }

        static int Add(int x, int y)
        {
            return x + y;
        }

        static int Multiply(int x, int y)
        {
            return x * y;
        }

        static int Divide(int x, int y)
        {
            if (y == 0)
            {
                Console.WriteLine("El divisor no puede ser 0.");
                return;
            }
            return x / y;

        static int Subtract(int x, int y)
        {
            return x - y;

        }
    }
}