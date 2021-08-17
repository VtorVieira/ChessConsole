using System;
using tabuleiro;
using chess;

namespace Chess_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PartidaDeChess partida = new PartidaDeChess();

                while (!partida.terminada)
                {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);

                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicaoChess().toPosicao();

                    bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();

                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);

                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerPosicaoChess().toPosicao();

                    partida.executaMotimento(origem, destino);
                }


            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e);
            }
            Console.ReadLine();
        }
    }
}
