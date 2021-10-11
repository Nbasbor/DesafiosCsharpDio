using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDio3Nivel3
{
    class Program
    {
        static void Main(string[] args)
        {

            double media = 0;
            double mediaTotal = 0;

            int i = 0;

            do
            {
                double nota = double.Parse(Console.ReadLine());

                if (nota >= 0 && nota <= 10)
                {
                    i++;
                    media += nota;
                    mediaTotal = media / 2;
                }
                else
                {
                    Console.WriteLine("nota invalida");
                }


            }
            while (i != 2);

            Console.WriteLine($"media = {mediaTotal.ToString("N2")}");

        }
    }
}
