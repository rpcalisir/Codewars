using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeChecker
{
    public class TicTacToe
    {
        public int IsSolved(int[,] board)
        {
            for (int row = 0; row < board.GetUpperBound(0); row++)
            {
                for (int column = 0; column < board.GetUpperBound(1); column++)
                {
                    if (board[row, column] == 0)
                    {

                    }
                }
            }

            return 1;
        }

        private static bool IsAllFieldsTheSame()

    }
}
