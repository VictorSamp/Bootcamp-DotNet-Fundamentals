using System;
using System.Text.RegularExpressions;

namespace validar_senhas_com_requisitos
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string senhaDoUsuario = Console.ReadLine();

                while (senhaDoUsuario != "")
                {
                    Validador senhaValidada = new Validador(senhaDoUsuario);

                    bool tamanhoSenha = senhaValidada.ValidaTamanhoMinimoEMaximo(senhaDoUsuario);
                    bool letrasMinusculas = senhaValidada.ValidaLetrasMinusculas(senhaDoUsuario);
                    bool letrasMaiusculas = senhaValidada.ValidaLetrasMaiusculas(senhaDoUsuario);
                    bool minimoDenumeros = senhaValidada.ValidaMinimoDeNumeros(senhaDoUsuario);
                    bool caracteresEspeciais = senhaValidada.ValidaCaracteresEspeciais(senhaDoUsuario);

                    if (tamanhoSenha && letrasMinusculas &&
                        letrasMaiusculas && minimoDenumeros &&
                        caracteresEspeciais)
                    {
                        Console.WriteLine("Senha valida.");
                    }
                    else
                    {
                        Console.WriteLine("Senha invalida.");
                    }
                    senhaDoUsuario = Console.ReadLine();
                }
            }
            catch
            {
                return;
            }            
        }
    }

    class Validador
    {
        // Atributos
        private string SenhaDoUsuario;
        private int TamanhoMinimo;
        private int TamanhoMaximo;
        private Regex RegexLetrasMinusculas;
        private Regex RegexLetrasMaiusculas;
        private Regex RegexMinimoDeNumeros;
        private Regex RegexCaracteresEspeciais;

        // Construtor
        public Validador(string senhaDoUsuario)
        {
            this.SenhaDoUsuario = senhaDoUsuario;
            this.TamanhoMinimo = 6;
            this.TamanhoMaximo = 32;
            this.RegexLetrasMinusculas = new Regex("[a-z]");
            this.RegexLetrasMaiusculas = new Regex("[A-Z]");
            this.RegexMinimoDeNumeros = new Regex("[0-9]");
            this.RegexCaracteresEspeciais = new Regex("[^a-zA-Z0-9]");
        }

        // Valida Tamanho Minimo e Máximo
        public bool ValidaTamanhoMinimoEMaximo(string senhadousuario)
        {
            if (senhadousuario.Length < this.TamanhoMinimo || senhadousuario.Length > this.TamanhoMaximo)
            {
                return false;
            }

            return true;
        }

        //Valida Letras Minusculas
        public bool ValidaLetrasMinusculas(string senhadousuario)
        {

            if (!RegexLetrasMinusculas.IsMatch(senhadousuario))
            {
                return false;
            }

            return true;
        }

        //Valida Letras Maiusculas
        public bool ValidaLetrasMaiusculas(string senhadousuario)
        {
            if (!RegexLetrasMaiusculas.IsMatch(senhadousuario))
            {
                return false;
            }

            return true;
        }

        //Valida Minimo de Numeros
        public bool ValidaMinimoDeNumeros(string senhadousuario)
        {
            if (!RegexMinimoDeNumeros.IsMatch(senhadousuario))
            {
                return false;
            }

            return true;
        }

        //Valida Caracteres Especiais
        public bool ValidaCaracteresEspeciais(string senhadousuario)
        {
            if (RegexCaracteresEspeciais.IsMatch(senhadousuario))
            {
                return false;
            }

            return true;
        }
    }
}
