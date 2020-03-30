using System;

namespace Algoritmo200402
{
    class Exercicio02
    {
        public static void Exe() {
            char letra;
            Console.WriteLine("Faça um algoritmo que lê uma letra e informa se a \n"+
            "mesma é uma vogal ou consoante.A mesma deverá \n" +
            "exibir uma mensagem de erro no caso de digitação incorreta; ");
            Console.WriteLine();
            do
            {
                Console.WriteLine("Digite uma letra");
                letra = char.Parse(Console.ReadLine());

                switch (letra)
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                    case 'A':
                    case 'E':
                    case 'I':
                    case 'O':
                    case 'U': Console.WriteLine("Essa letra é uma vogal"); break;
                    case 'b': case 'c': case 'd': case 'f': case 'g': case 'h': case 'j': case 'k': case 'y': case 'l': case 'm': case 'n': case 'p': case 'q': case 'r': case 's': case 't': case 'v': case 'x': case 'z': case 'w':
                    case 'B':
                    case 'C':
                    case 'D':
                    case 'F':
                    case 'G':
                    case 'H':
                    case 'J':
                    case 'K':
                    case 'Y':
                    case 'L':
                    case 'M':
                    case 'N':
                    case 'P':
                    case 'Q':
                    case 'R':
                    case 'S':
                    case 'T':
                    case 'V':
                    case 'X':
                    case 'Z':
                    case 'W': Console.WriteLine("Essa letra é uma consoante");break;
                    default: Console.WriteLine("Letra inválida"); break;
                }
                Console.WriteLine();

            } while (true);
        }
    }
}
