using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafiosDioNivel1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Leitura Das Variáveis
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());

            
            int SOMA = A + B;

            //Print
            Console.WriteLine("SOMA = {0}", SOMA);

        }
    }
}
