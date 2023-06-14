using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number");
            int n = Convert.ToInt32(Console.ReadLine());
            if (Math.Sqrt(n) % 1 == 0)
                Console.WriteLine("yes");
            else
                Console.WriteLine("n0");
        }
    }
}