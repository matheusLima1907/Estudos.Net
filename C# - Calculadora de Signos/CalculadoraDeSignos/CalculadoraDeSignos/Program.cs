using System;

namespace CalculadoraDeSignos
{
    class Program
    {
        static void Main(string[] args)
        {
            //variaveis de entrada
            string dia;
            string mes;

            //ler e armazenar valores das variaveis
            Console.WriteLine("Em que dia você nasceu?");
            dia = Console.ReadLine();
            Console.WriteLine("Em que mes você nasceu?");
            mes = Console.ReadLine();

            //variaveis para tratamento de exceções
            int diaInt = 0;
            int mesInt = 0;

            //tratamento de exceções
            try
            {
                diaInt = Convert.ToInt32(dia);
                mesInt = Convert.ToInt32(mes);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
                Environment.Exit(1);

            }

            //instanciar e utilizar classes e seus respectivos metodos e objetos
            InterpretadorSigno interpretador = new InterpretadorSigno();
            Signo signo = interpretador.Interpretar(diaInt, mesInt);

            //condições para o caso de o usuario entrar com valores invalidos e retorno das funções citadas acima
            if (signo != null)
            {
                Console.WriteLine("Seu signo é " + signo.nome + ":" + signo.caracteristicas);
            }
            else
            {
                Console.WriteLine("Digite um dia e um mes válidos, tente novamente!");
            }

            //parar o console para que seja possivel analizar as informações
            Console.ReadLine();
        }
    }
}
