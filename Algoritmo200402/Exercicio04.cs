using System;

namespace Algoritmo200402
{
    class Exercicio04
    {
        public static void Exe() {
          
            Console.WriteLine("Faça um algoritmo que receba dois números, um \n"+
            "operador matemático(+, -, *,/) e efetue o cálculo \n"+
            "matemático baseado no operador digitado.O \n"+
            "resultado deverá ser exibido em seguida.Utilize o \n"+
            "comando escolha.");
            Console.WriteLine();
            Console.WriteLine("Digite um número");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro número");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um operação, exemplo: + - * / ");
            string sinal = Console.ReadLine();


            switch (sinal)
            {
                case "+": Console.WriteLine("Resultado: {0}",n1+n2); break;
                case "-": Console.WriteLine("Resultado: {0}",n1-n2); break;
                case "*": Console.WriteLine("Resultado: {0}", n1 * n2); break;
                case "/": Console.WriteLine("Resultado: {0}", n1 / n2); break;
                    
                default: Console.WriteLine("Operação inválida"); break;
            }
            Console.WriteLine();
           
        }
    }
}
