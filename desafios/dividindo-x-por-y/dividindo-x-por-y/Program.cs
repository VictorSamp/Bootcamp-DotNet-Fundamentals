using System;
using System.Globalization;

namespace dividindo_x_por_y
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidadePares, valorX, valorY;
            string[] valores;
            double divisao;

            quantidadePares = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantidadePares; i++)
            {
                valores = Console.ReadLine().Split(' ');
                valorX = int.Parse(valores[0]);
                valorY = int.Parse(valores[1]);

                if (valorY == 0.0)
                {
                    Console.WriteLine("divisao impossivel");
                } else
                {
                    divisao = (double)valorX / valorY;
                    Console.WriteLine(divisao.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
