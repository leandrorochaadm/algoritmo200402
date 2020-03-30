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

                        Console.WriteLine();
                }
                } while (n != 0);
        }
    }
}
