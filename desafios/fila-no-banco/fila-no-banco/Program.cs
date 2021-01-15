using System;

class Program
{
    static void Main()
    {
        int numeroDeTestes = int.Parse(Console.ReadLine());
        for (int i = 1; i <= numeroDeTestes; i++)
        {
            int semMudancas = 0;
            int quantidadeDeClientes = int.Parse(Console.ReadLine());
            string[] stringSenhas = Console.ReadLine().Split(' ');
            int[] senhas = new int[quantidadeDeClientes];
            int[] ordemDecrescente = new int[quantidadeDeClientes];
            for (int j = 0; j < senhas.Length; j++)
            {
                senhas[j] = int.Parse(stringSenhas[j]);
                ordemDecrescente[j] = int.Parse(stringSenhas[j]);
            }

            Array.Sort(ordemDecrescente);
            Array.Reverse(ordemDecrescente);



            for (int k = 0; k < stringSenhas.Length; k++)
            {
                if (senhas[k] == ordemDecrescente[k])
                {
                    semMudancas++;
                }
            }
            Console.WriteLine(semMudancas);
        }
    }
}