using System;

namespace Algoritmo200402
{
    class Exercicio03
    {
        public static void Exe() {
            byte cod;
            Console.WriteLine("Faça um algoritmo (utilizando o comando escolha) \n"+
            "que, baseado no código digitado pelo usuário, retorne \n" +
            "o nome e valor do produto.");
            Console.WriteLine();
            do
            {  /*
                Console.WriteLine(
                "¤ 001 – Parafuso (R$ 0,15) \n "+
                "¤ 002 – Porca(R$ 0, 05) \n "+
                "¤ 003 – Prego(R$ 0, 10) \n "+
                "¤ 004 – Martelo(R$ 40, 00) \n "+
                "¤ 005 – Tomada(R$ 3, 00)");
                */

                Console.WriteLine("Digite o código do produto, entre 1 a 5");
                cod = byte.Parse(Console.ReadLine());

                switch (cod)
                {
                    case 1: Console.WriteLine("cod 001 – Parafuso (R$ 0,15)"); break;
                    case 2: Console.WriteLine("cod 002 – Porca(R$ 0, 05) "); break;
                    case 3: Console.WriteLine("cod 003 – Prego(R$ 0, 10)"); break;
                    case 4: Console.WriteLine("cod 004 – Martelo(R$ 40, 00)"); break;
                    case 5: Console.WriteLine("cod 005 – Tomada(R$ 3, 00)"); break;
                    
                    default: Console.WriteLine("Código inválido"); break;
                }
                Console.WriteLine();

            } while (true);
        }
    }
}
