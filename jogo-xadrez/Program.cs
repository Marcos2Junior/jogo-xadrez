using System;
using tabuleiro;
using xadrez;

namespace jogo_xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PartidaXadrez partidaXadrez = new PartidaXadrez();

                while (!partidaXadrez.terminada)
                {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partidaXadrez.tab);

                    Console.Read();

                }
            }
            catch (TabuleiroException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
