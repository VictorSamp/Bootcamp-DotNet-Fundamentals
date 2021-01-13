using System;
using System.Text.RegularExpressions;

namespace validar_senhas_com_requisitos
{
    class Program
    {
        static void Main(string[] args)
        {
            string senhaDoUsuario;

            do
            {
                senhaDoUsuario = Console.ReadLine();

                bool validacaoDeTamanho = TamanhoMinimoEMaximo(senhaDoUsuario);
                bool validacaoMinusculasEMaiusculas = LetraMaiusculaEMinuscula(senhaDoUsuario);
                bool validacaoDeNumeros = MinimoDeNumeros(senhaDoUsuario);
                bool validacaoCaracteresEspeciais = CaracteresEspeciais(senhaDoUsuario);

                if (validacaoDeTamanho && validacaoMinusculasEMaiusculas &&
                    validacaoDeNumeros && validacaoCaracteresEspeciais)
                {
                    Console.WriteLine("Senha valida.");
                }
                else
                {
                    Console.WriteLine("Senha invalida.");
                }
            } while (!string.IsNullOrWhiteSpace(senhaDoUsuario));
        }

        public static bool TamanhoMinimoEMaximo(string senhaDoUsuario)
        {
            int tamanhoMinimo = 6;
            int tamanhoMaximo = 32;

            if (senhaDoUsuario.Length < tamanhoMinimo || senhaDoUsuario.Length > tamanhoMaximo)
            {
                return false;
            }

            return true;
        }

        public static bool LetraMaiusculaEMinuscula(string senhaDoUsuario)
        {
            int minimoDeLetrasMaiusculas = 1;
            int minimoDeLetrasMinusculas = 1;

            Regex padraoDeMaiusculas = new Regex("[A-Z]");
            Regex padraoDeMinusculas = new Regex("[a-z]");

            MatchCollection letrasMaiusculasEncontradas = padraoDeMaiusculas.Matches(senhaDoUsuario);
            MatchCollection letrasMinusculasEncontradas = padraoDeMinusculas.Matches(senhaDoUsuario);

            if (letrasMinusculasEncontradas.Count < minimoDeLetrasMinusculas || letrasMaiusculasEncontradas.Count < minimoDeLetrasMaiusculas)
            {
                return false;
            }

            return true;
        }

        public static bool MinimoDeNumeros(string senhaDoUsuario)
        {
            int minimoDeNumeros = 1;

            Regex padraoDeNumeros = new Regex("[0-9]");

            MatchCollection numerosEncontrados = padraoDeNumeros.Matches(senhaDoUsuario);

            if (numerosEncontrados.Count < minimoDeNumeros)
            {
                return false;
            }

            return true;
        }

        public static bool CaracteresEspeciais(string senhaDoUsuario)
        {
            int minimoDeCaracteresEspeciais = 0;

            Regex padraoDeCaracteres = new Regex("[^a-zA-Z0-9]");

            MatchCollection caracteresEncontrados = padraoDeCaracteres.Matches(senhaDoUsuario);

            if (caracteresEncontrados.Count != minimoDeCaracteresEspeciais)
            {
                return false;
            }

            return true;
        }
    }
}
