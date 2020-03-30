using System;

namespace Algoritmo200402
{
    class Exercicio01
    {
        public static void Exe() {
            byte dia;
            Console.WriteLine("Faça um algoritmo que lê um número de 1 a 7 e \n"+
            "informa o dia da semana correspondente, sendo \n" +
            "domingo o número 1.Caso o número não \n" +
            "corresponder a um dia da semana, é exibida uma \n" +
            "mensagem de erro ");
            Console.WriteLine();
            do
            {
                Console.WriteLine("Digite o número da semana");
                dia = byte.Parse(Console.ReadLine());

                switch (dia)
                {
                    case 1: Console.WriteLine("Domingo"); break;
                    case 2: Console.WriteLine("Segunda-feira"); break;
                    case 3: Console.WriteLine("Terça-feira"); break;
                    case 4: Console.WriteLine("Quanta-feira"); break;
                    case 5: Console.WriteLine("Quinta-feira"); break;
                    case 6: Console.WriteLine("Sexta-feira"); break;
                    case 7: Console.WriteLine("Sábado"); break;
                    default: Console.WriteLine("Número inválido"); break;
                }
                Console.WriteLine();

            } while (true);
        }
    }
}
