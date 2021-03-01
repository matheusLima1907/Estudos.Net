using System;
using System.Text;

namespace ValueRef
{
    class Program
    {
        public class Cliente/*reference type*/ : Object //por padrão tudo em C# herda da classe Object implicitamente, porem podemos fazer de maneira explicita 
        {
            public int Codigo;
            public string Nome;
            public string Telefone;
            public override string ToString()//ao mandar retornar o ponteiro indentado para a classe, por padrão, o C# retorna o nome da classe, porem com esse metodo retorna os atributos da msm em string
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Codigo - " + Codigo);
                sb.AppendLine("Nome - " + Nome);
                sb.AppendLine("Telefone - " + Telefone);

                return sb.ToString();
            }
        }
        static void Main(string[] args)//main
        {
            //ValueTypePrint();
            //RefTypePrint();
            //DoisPonteirosClasses();
        }

        private static void DoisPonteirosClasses()//instancia dois ponteiros para mesma classe e verifica se são ou não iguais
        {
            Cliente c = new Cliente();
            Cliente c2 = new Cliente();

            c.Codigo = 123;
            c.Nome = "Pings";
            c.Telefone = "99 99999-9999";
            c2.Nome = "Matheus";

            Console.WriteLine(c);
            Console.WriteLine($"{c2}\n");

            if (c.Equals(c2))//verifica se os ponteiros apontam para os mesmos objetos

                Console.WriteLine("c e c2 sao os mesmos objetos");
            else

                Console.WriteLine("c e c2 sao objetos diferentes");
        }

        private static void RefTypePrint()//printa valores declarados por Reference Types
        {
            Cliente c = new Cliente();

            c.Codigo = 123;
            c.Nome = "Pings";
            c.Telefone = "99 99999-9999";

            Console.WriteLine(c);//mostra nome da classe por padrão pois n sabe o valor dos seus atributos
            Console.WriteLine(c.Codigo);
            Console.WriteLine(c.Nome);
            Console.WriteLine(c.Telefone);
        }

        private static void ValueTypePrint()//printa valores declarados por Value Types
        {
            int x = 10;
            string s = "Pings";
            bool b = false;

            Console.WriteLine(x);
            Console.WriteLine(s);
            Console.WriteLine(b);
        }
    }
}
