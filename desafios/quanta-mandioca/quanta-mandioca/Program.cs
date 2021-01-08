using System;

namespace quanta_mandioca
{
    class Program
    {
        static void Main()
        {
            int qtdChico = 300 * int.Parse(Console.ReadLine());
            int qtdBento = 1500 * int.Parse(Console.ReadLine());
            int qtdBernardo = 600 * int.Parse(Console.ReadLine());
            int qtdMarina = 1000 * int.Parse(Console.ReadLine());
            int qtdIara = 150 * int.Parse(Console.ReadLine());
            int qtdMarlene = 225;
            int total = qtdChico + qtdBento + qtdBernardo + qtdMarina + qtdIara + qtdMarlene;
            Console.WriteLine(total);
        }
    }
}
