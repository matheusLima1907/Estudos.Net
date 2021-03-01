using System;

namespace ValueRef
{
    public class PosicaoClass //reference type
    {
        public int x;
        public int y;
    }
    class Program
    {
        public static void Dobrar(ref int valor)//dobra um Value Type, no caso um inteiro
        {
            valor = valor * 2;
        }
        public static void Dobrar(PosicaoClass valor)//dobra um Reference Type, no caso um inteiro
        {
            valor.x = valor.x * 2;
            valor.y = valor.y * 2;
        }
        static void Main(string[] args)
        {
            //ValueTypeInt();
            //RefTypeInt();
            //DobrarValue();
            //DobrarRef();

            Console.ReadLine();
        }

        private static void DobrarRef()
        {
            PosicaoClass pos1 = new PosicaoClass();//ponteiro
            pos1.x = 10;
            pos1.y = 20;

            PosicaoClass pos2 = new PosicaoClass();//ponteiro
            pos2.x = 30;
            pos2.y = 40;

            Dobrar(pos1);
            Dobrar(pos2);

            Console.WriteLine(pos1.x);
            Console.WriteLine(pos1.y);
            Console.WriteLine(pos2.x);
            Console.WriteLine(pos2.y);
        }//chama metodo declarado anteriormente de um reference type, atraves do valor original declarado na class PosicaoClass

        private static void DobrarValue()
        {
            int x = 10;
            Dobrar(ref x);
            Console.WriteLine(x);
        }//chama metodo declarado anteriormente de um value type, atraves de uma copia do valor indicado

        private static void RefTypeInt()
        {
            PosicaoClass pos1 = new PosicaoClass();//ponteiro
            pos1.x = 10;
            pos1.y = 20;

            PosicaoClass pos2 = new PosicaoClass();//ponteiro
            pos2.x = 30;
            pos2.y = 40;

            pos2 = pos1;//um ponteiro aponta para a msm posição de outro ponteiro, não gera uma copia como os Value Types
            pos2.x = 50;//afeta o x de pos 1 pois na linha anterior ambos os ponteiros apontam para o msm espaço de memoria
            Console.WriteLine(pos1.x);
            Console.WriteLine(pos1.y);
            Console.WriteLine(pos2.x);
            Console.WriteLine(pos2.y);
        }//metodo exemplo para Reference Type Int

        private static void ValueTypeInt()
        {
            int x = 10;
            int y = 20;
            y = x;//copia o valor de um value type para outro value type
            Console.WriteLine(x);
            Console.WriteLine(y);
        }//metodo exemplo para Value Type Int
    }
}
