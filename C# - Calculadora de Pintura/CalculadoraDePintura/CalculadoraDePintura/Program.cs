using System;

namespace CalculadoraDePintura
{
    class Program
    {
        static void Main(string[] args)
        {
            //constante que armazena valor da altura padrão 
            const double Altura = 2.9;
            
                //le largura do comodo
                Console.WriteLine("Qual a largura do comodo?");
                double largura = Double.Parse(Console.ReadLine());
            
                //le profundidade do comodo
                Console.WriteLine("Qual a profundidade do comodo?");
                double profundidade = Double.Parse(Console.ReadLine());

            //instancia da classe calculadora
            Calculadora calculadora = new Calculadora();

            //calculos armazenados na classe calculadora        

                //retorna area das paredes
                Console.WriteLine("A área das paredes é:");
                    Console.WriteLine(calculadora.CalculaAreaParede(largura, profundidade, Altura));
            
                //retorta area do teto
                Console.WriteLine("A área do teto é:");
                    Console.WriteLine(calculadora.CalculaAreaTeto(largura, profundidade));

            

             //retorna qtd de litros de tinta
                 Console.WriteLine("A litragem de tinta necessária é:");
                    Console.WriteLine(calculadora.CalculaLitragem());
                        Console.ReadLine();

        }
    }
}
