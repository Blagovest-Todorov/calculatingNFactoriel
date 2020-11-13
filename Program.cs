using System;

namespace _09.WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            // calculate n! = 1 * 2 * 3 .... n;
            int result = 1;

            while (true)
            {
                if (n == 1)
                {
                    break;
                }
                result *= n;
                n--;
            }
            Console.WriteLine("n! = {0}", result);

        }
    }
}
