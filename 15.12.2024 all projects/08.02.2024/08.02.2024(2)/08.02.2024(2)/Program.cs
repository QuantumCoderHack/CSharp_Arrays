using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._02._2024_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int integer = rnd.Next(1,100);
            for (int i = 1; i <= 10;i++)
            {

                Console.WriteLine(integer);
                integer += i;
            }
               
            Console.ReadLine();
        }
    }
}
