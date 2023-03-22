using System;

namespace Power2Method
{
    class Program
    {
        private static void PowersOf2UntilN(int n)
        {
            for (int i = 1 ; i <= ( 1 << n ) ; i<<=1 )
            {
                Console.WriteLine(i);
            }
        }


        private static void PowersOf2Until5()
        {
            PowersOf2UntilN(5);
        }
        static void Main(string[] args)
        {
            string aux = Console.ReadLine();
            int nCount = Convert.ToInt32(aux);
            PowersOf2UntilN(nCount);

            aux = Console.ReadLine();
            nCount = Convert.ToInt32(aux);
            PowersOf2UntilN(nCount);

            PowersOf2Until5();
            PowersOf2Until5();
        }
    }
}
