using System;
using System.Threading;

namespace PII_Game_Of_Life
{
    class Program
    {
        static void Main(string[] args)
        {
            string rutaTablero = "..\\..\\assets\\board.txt";
            bool[,] tablero = BoardReader.Importar(rutaTablero);

            while (true) {
                ConsolePrinter.RefreshBoard(tablero);
                tablero = Game.NextGeneration(tablero);
                Thread.Sleep(300);
            }
        }
    }
}
