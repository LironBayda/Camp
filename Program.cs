using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace camp
{
    class Program
    {
        static void Main(string[] args)
        {
            Camp camp1 = new Camp( 22, 22, 44, 22, 44);
            Camp camp2 = new Camp( 222, 222, 424, 222, 244);
            Console.WriteLine(camp2 == camp1);
            Console.WriteLine(camp1 != camp2);
            Console.WriteLine(camp2 > camp1);
            Console.WriteLine(camp2 < camp1);
            Camp camp = camp1 + camp2;
            Console.WriteLine(camp.ToString());

            Console.ReadLine();

        }
    }
}
