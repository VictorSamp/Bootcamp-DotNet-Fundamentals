using System;

namespace distancia
{
    class Program
    {
        static void Main(string[] args)
        {
            int quilometros, minutos;

            quilometros = int.Parse(Console.ReadLine());
            minutos = quilometros * 2;

            Console.WriteLine(minutos + " minutos");
        }
    }
}