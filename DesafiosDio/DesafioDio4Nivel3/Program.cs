using System;


namespace DesafioDio4Nivel3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a1 = double.Parse(s[0]);
            double b1 = double.Parse(s[1]);
            double c1 = double.Parse(s[2]);

            //Convert.ToSingle converter double para float
            double[] arr = new double[3];
            arr[0] = a1;
            arr[1] = b1;
            arr[2] = c1;
            Array.Sort(arr);
            Array.Reverse(arr);
            double a = arr[0];
            double b = arr[1];
            double c = arr[2];
            double p2 = 2.0;

            //Método para potência 
            double a2 = Math.Pow(a, p2);
            double b2 = Math.Pow(b, p2);
            double c2 = Math.Pow(c, p2);
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);
            //continue a solucao
            if (a >= b + c)
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            else
            {
                if (a2 == b2 + c2)
                {
                    Console.WriteLine("TRIANGULO RETANGULO");

                }
                else if (a2 > b2 + c2)
                {
                    Console.WriteLine("TRIANGULO OBTUSANGULO");

                    if (a == b && c == a)
                    {
                        Console.WriteLine("TRIANGULO EQUILATERO");
                    }
                    else if (a == b || b == c || c == a)
                    {
                        Console.WriteLine("TRIANGULO ISOSCELES");
                    }
                }
                else if (a2 < b2 + c2)
                {
                    Console.WriteLine("TRIANGULO ACUTANGULO");

                    if (a == b && c == a)
                    {
                        Console.WriteLine("TRIANGULO EQUILATERO");
                    }
                    else if (a == b || b == c || c == a)
                    {
                        Console.WriteLine("TRIANGULO ISOSCELES");
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
