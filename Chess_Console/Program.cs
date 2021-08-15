using System;
using tabuleiro;
using chess;

namespace Chess_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            PosicaoChess pos = new PosicaoChess('c', 7);

            Console.WriteLine(pos);

            Console.WriteLine(pos.toPosicao());
            Console.ReadLine();
        }
    }
}
