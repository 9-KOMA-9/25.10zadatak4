using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak25._10._04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("upusite recenicu");
            string s1 = Console.ReadLine();
            string[] rijeci = s1.Split(' ');
            Console.WriteLine(rijeci[0]);
            Console.WriteLine(rijeci[rijeci.Length-1]);
            Console.ReadKey();
        }
    }
}
