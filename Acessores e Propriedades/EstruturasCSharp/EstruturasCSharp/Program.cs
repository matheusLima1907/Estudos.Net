using System;

namespace EstruturasCSharp
{
    public class PosicaoClass//reference type class e metodo override to string
    {
        public int X;
        public int Y;

        public override string ToString()
        {
            return $"x - {X.ToString()}, y - {Y.ToString()}";
        }
    }

    public struct PosicaoStruct//value type struct e metodo override to string
    {
        public int x;
        public int y;

        public override string ToString()
        {
            return $"x - {x.ToString()}, y - {y.ToString()}";
        }
    }
    public enum Role//enumera limita ou indica algo ao sistema, nesse caso o papel de cada pessoa em um projeto
    {
        Arquiteto, Developer, Tester
    }
    public enum Color//enumera limita ou indica algo ao sistema, nesse caso uma cor
    {
        Red = 0, Green = 1, Blue = 2
    }
    public enum FormaPagamento//enumera limita ou indica algo ao sistema, nesse caso uma forma de pagamento
    {
        Boleto, Cartao, Cheque
    }
    class Program
    {
        static void Main(string[] args)
        {
            //ChamarInstanciarPrintarClass();
            //ChamarinstanciarPrintarStruct();
            //ChamarInstaciarPrintarEnum();
        }

        private static void ChamarInstaciarPrintarEnum()//instancia um enum atraves de valores listados, devolvendo os valores das variaveis atribuidos do enum
        {
            FormaPagamento formaPagamento = FormaPagamento.Boleto;
            Role role = Role.Arquiteto;
            Color cor = Color.Red;

            Console.WriteLine(formaPagamento);
            Console.WriteLine(role);
            Console.WriteLine(cor);
        }

        private static void ChamarinstanciarPrintarStruct()//instancia uma struct atraves de valores primitivos, devolvendo os valores das variaveis atribuidos da struct
        {
            PosicaoStruct pos2 = new PosicaoStruct();
            pos2.x = 30;
            pos2.y = 40;

            PosicaoStruct pos3 = pos2;//ambos value type, não é apontamento por ponteiro, logo é uma copia
            pos3.y = 50;//pos3 não afeta pos2, principal diferença entre struct e class (value e reference)

            Console.WriteLine(pos2.ToString());
        }

        private static void ChamarInstanciarPrintarClass()//instancia uma classe atraves de um ponteiro, devolvendo os valores das variaveis atribuidos da classe
        {
            PosicaoClass pos1 = new PosicaoClass();
            pos1.X = 10;
            pos1.Y = 20;

            Console.WriteLine(pos1);
            Console.ReadLine();
        }
    }
}
