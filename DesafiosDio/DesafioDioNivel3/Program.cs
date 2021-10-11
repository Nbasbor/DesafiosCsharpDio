using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDioNivel3
{
    class Program
    {
        static void Main(string[] args)
        {

            //Declaração das variáveis globais
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;
            int pref = 0;
           

            do

            {

                pref = Convert.ToInt32(Console.ReadLine());

                switch (pref)
                {
                    case 1:
                        {
                            alcool++;
                            break;
                        }
                    case 2:
                        {
                            gasolina++;
                            break;
                        }
                    case 3:
                        {
                            diesel++;
                            break;
                        }
                    case 4:
                        //Console.WriteLine("Fim");
                        Console.WriteLine("MUITO OBRIGADO");

                        break;
                    default:
                        // Console.WriteLine("teste");
                        continue;
                }




            } while (pref != 4);
            

            Console.WriteLine("Alcool: {0}", alcool);
            Console.WriteLine("Gasolina: {0}", gasolina);
            Console.WriteLine("Diesel: {0}", diesel);
        }
    }
}
