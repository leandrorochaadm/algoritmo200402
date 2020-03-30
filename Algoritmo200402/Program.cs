using System;

namespace Algoritmo200402
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n;
            do
            {
                Console.WriteLine("Digite o número do exercicio q deseja executar, \n ou digite numero 0(zero) pra sair");
                n = byte.Parse(Console.ReadLine());

                switch (n)
                {
                    case 1:
                        Exercicio01.Exe();
                        break;
                    case 2:
                        Exercicio02.Exe();
                        break;
                    case 3:
                        Exercicio03.Exe();
                        break;
                    case 4:
                        Exercicio04.Exe();
                        break;
                    case 5:
                        Exercicio05.Exe();
                        break;

                        Console.WriteLine();
                }
                } while (n != 0);
        }
    }
}
