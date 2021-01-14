using System;
using System.Collections.Generic;

namespace fila_no_banco
{
    class Program
    {
        static void Main(string[] args)
        {
            int casosDeTeste;

            casosDeTeste = int.Parse(Console.ReadLine());

            for (int i = 0; i < casosDeTeste; i++)
            {
                int numeroDeClientes = int.Parse(Console.ReadLine());

                for (int j = 0; j < numeroDeClientes; j++)
                {
                    string[] senhas = Console.ReadLine().Split(' ');

                    List<int> listaDeSenhas = new List<int> { };

                    foreach (string senha in senhas)
                    {
                        listaDeSenhas.Add(int.Parse(senha));
                    }

                    listaDeSenhas.or

                }
            }
        }
    }
}
