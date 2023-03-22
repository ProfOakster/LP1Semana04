using System;

namespace Lucas
{
    class Program
    {
        private static int Lucas(int n)
        {
            int res;
            if (n==0)
                res = 2;
            else if (n==1)
                res = 1;
            else
                res = Lucas(n - 2) + Lucas(n - 1);

            return res;
        }

        static void Main(string[] args)
        {
            int inp = int.Parse(args[0]);
            Console.WriteLine(Lucas(inp));
        }
    }
}
