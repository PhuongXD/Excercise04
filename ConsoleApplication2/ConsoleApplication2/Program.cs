using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Ceil((float) 2.3));
            Console.WriteLine(Floor((float) -12.3));
        }
        public static int Ceil(float x)
        {
            int a = (int)x;
            if(x > 0)
                if(x > a)
                a = a + 1;
            return a;
        }
        public static int Floor(float x)
        {
            int a = (int)x;
            if (x < 0 && x!=a)
            {
               a = a - 1 ;
            }
            else
            {
                a = a;
            }

            return a;
        }
    }
}
