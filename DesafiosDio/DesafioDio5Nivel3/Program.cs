using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDio5Nivel3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            int x = int.Parse(vet[0]);
            int y = int.Parse(vet[1]);
            int i = 1;


            

            for (i = 1; i <= y; i++)
            {
                // Console.Write(i);
                if (i % x == 0)
                {
                    Console.WriteLine($" {i}");
                }
                else
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
