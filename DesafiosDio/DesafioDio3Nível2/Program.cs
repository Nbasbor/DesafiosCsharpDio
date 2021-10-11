using System;


namespace DesafioDio3Nível2
{
    class Program
    {
        static void Main(string[] args)
        {
            //lê a variavél tempo em segundos
            var timeInSeconds = int.Parse(Console.ReadLine());

            //transforma em horas
            int hours = timeInSeconds / 3600;
            if (hours > 0)
            {
                //tranforma em minutos e segundos
                int minutes = (timeInSeconds % 3600) / 60;
                var seconds = timeInSeconds % 60;
                Console.WriteLine($"{hours}:{minutes}:{seconds}");
            }
            //timeInSeconds = 
            else
            {
                int minutes = timeInSeconds / 60;
                var seconds = timeInSeconds % 60;
                Console.WriteLine($"{hours}:{minutes}:{seconds}");
            }
        }
    }
}
