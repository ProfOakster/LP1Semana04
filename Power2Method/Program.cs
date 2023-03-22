using System;

namespace Power2Method
{
    class Program
    {
        /// <summary>
        /// Shows the powers of 2 from the N1th power, 
        /// up to the N2th power
        /// </summary>
        /// <param name="n1">
        /// Starting power of 2
        /// </param>
        /// <param name="n2">
        /// Final power of 2
        /// </param>
        private static void PowersOf2UntilN(int n1, int n2)
        {
            for (int i = 1 << n1 ; i <= ( 1 << n2 ) ; i<<=1 )
            {
                Console.WriteLine(i);
            }
        }



        /// <summary>
        /// Shows the powers of 2 up to the Nth power
        /// </summary>
        /// <param name="n">
        /// Last number shown is 2 to the power of this
        /// </param>
        private static void PowersOf2UntilN(int n)
        {
            for (int i = 1 ; i <= ( 1 << n ) ; i<<=1 )
            {
                Console.WriteLine(i);
            }
        }

        /// <summary>
        /// Shows the powers of 2 up to the 5th power
        /// </summary>
        private static void PowersOf2Until5()
        {
            PowersOf2UntilN(5);
        }

        /// <summary>
        /// Asks for an int twice and prints powers of 2 up to those powers,
        /// then prints powers of 2 up to the 5th power twice
        /// </summary>
        /// <param name="args">
        /// Unused
        /// </param>
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
