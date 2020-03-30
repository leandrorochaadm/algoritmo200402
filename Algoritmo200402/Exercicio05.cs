using System;

namespace Algoritmo200402
{
    class Exercicio05
    {
        public static void Exe() {
          
        
                Console.WriteLine("Digite a idade do(a) nadador(a)");
                int idade = int.Parse(Console.ReadLine());

            if ((idade<=4)|(idade>20))
            {
                Console.WriteLine("Não aceito");
            } else if ((idade >= 5) | (idade <= 10))
            {
                Console.WriteLine("classe: Infantil");
            }
            else if ((idade >=11) | (idade <= 17))
            {
                Console.WriteLine("classe: Juvenil");
            }
            else if ((idade >= 5) | (idade <= 10))
            {
                Console.WriteLine("classe: Sênior");
            }

                Console.WriteLine();

          
        }
    }
}
