using System;
using System.Text;

namespace PII_Game_Of_Life
{
    public class ConsolePrinter {
        public static void RefreshBoard(bool[,] board) {
            Console.Clear();
            int width = board.GetLength(0);
            int height = board.GetLength(1);

            StringBuilder s = new StringBuilder();

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if(board[x,y])
                    {
                        s.Append("|X|");
                    }
                    else
                    {
                        s.Append("___");
                    }
                }
                s.Append("\n");
            }

            Console.WriteLine(s.ToString());
        }
    }
}