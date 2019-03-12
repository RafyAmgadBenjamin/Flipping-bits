using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flipping_bits
{
    class Program
    {
        static long flippingBits(long n)
        {
            
            uint y = Convert.ToUInt32(n);
            return ~y;

        }

        static void Main(string[] args)
        {
            //  TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                long n = Convert.ToInt64(Console.ReadLine());

                long result = flippingBits(n);

                Console.WriteLine(result);
            }

            // textWriter.Flush();
            // textWriter.Close();
        }
    }
}
