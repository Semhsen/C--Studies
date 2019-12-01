using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace milli_piyango_çekilişi
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rastgele = new Random();
            int a;
            int b;
            int c;
            int d;
            a = rastgele.Next(10);
            b = rastgele.Next(10);
            while (true)
            {
                Console.WriteLine("birinci sayıyı giriniz:");
                c = Convert.ToInt32(Console.ReadLine());
                if (c < 10 && c > -1) break;
            }                                                                               
            Console.WriteLine("ikinci sayıyı giriniz:");
            d = Convert.ToInt32(Console.ReadLine());
            if (a == c) Console.WriteLine("birinci sayıyı bildin");
            if (b == d) Console.WriteLine("ikinci sayıyı bildin");
            else Console.WriteLine("ikisinide bilemezdiniz");
            Console.ReadKey();
        }
    }
}
