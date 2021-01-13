using System;
using System.Collections.Generic;

namespace programa_para_validacao_de_notas
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcaoUsuario = 1;
            List<double> notasValidas = new List<double>;
        }

        static string validarNota(double nota)
        {
            if (nota < 0.0 || nota > 10.0)
            {
                return Console.WriteLine("nota invalida");
            }
            else
            {
                notasValidas.Add(nota);
            }
        }
    }
}
