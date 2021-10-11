using System;


namespace DesafioDio2Nível3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            
            //leitura das variáveis
            int a = Convert.ToInt32(vet[0]);
            int b = Convert.ToInt32(vet[1]);
            int c = Convert.ToInt32(vet[2]);
           

            //Método Math.Abs devolve o resultado apenas em números positivos
            int MAIORAB = (a + b + Math.Abs(a - b)) / 2;

            if (MAIORAB > c)
            {
                int MAIOR = MAIORAB;
                Console.WriteLine($"{MAIOR} eh o maior");
            }
            else
            {
                int MAIOR = c;
                Console.WriteLine($"{MAIOR} eh o maior");
            }
        }
    }
}
