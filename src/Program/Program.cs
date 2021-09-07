using System;

namespace PII_Game_Of_Life
{
    class Program
    {
        static void Main(string[] args)
        {
            string rutaTablero = "..\\..\\assets\\board.txt";
            bool[,] tablero = BoardReader.Importar(rutaTablero);

            
        }
    }
}
