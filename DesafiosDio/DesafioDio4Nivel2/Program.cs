using System;


namespace DesafioDio4Nivel2
{
    class Program
    {
        static void Main(string[] args)
        {
            //leitura dos valores
            string[] line1 = Console.ReadLine().Split(' ');
            string[] line2 = Console.ReadLine().Split(' ');

            int finalExpediente = int.Parse(line1[0]);

            //conversão
            int presente1 = int.Parse(line2[0]);
            int presente2 = int.Parse(line2[1]);

            
            int totalNecessario = presente2 + presente1;

            //comparação
            if (totalNecessario > finalExpediente)
            {
                Console.WriteLine("Deixa para amanha!");
            }
            else
            {
                Console.WriteLine("Farei hoje!");
            }
        }
    }
}
