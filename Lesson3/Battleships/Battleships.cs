using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships {
    class Battleships {
        static void Main(string[] args) {
            string[,] gameBoard = {
                { "X", "O", "O", "O", "O", "O", "X", "O", "O", "O" },
                { "O", "O", "O", "O", "O", "O", "O", "O", "O", "O" },
                { "O", "X", "X", "O", "O", "O", "O", "X", "X", "X" },
                { "O", "O", "O", "O", "O", "O", "O", "O", "O", "O" },
                { "O", "X", "X", "O", "O", "X", "O", "O", "O", "O" },
                { "O", "O", "O", "O", "O", "X", "O", "O", "X", "O" },
                { "X", "O", "O", "O", "O", "X", "O", "O", "O", "O" },
                { "O", "O", "O", "O", "O", "O", "O", "O", "O", "O" },
                { "O", "X", "X", "X", "X", "O", "O", "X", "X", "O" },
                { "O", "O", "O", "O", "O", "O", "O", "O", "O", "O" }
            };

            for ( int i = 0; i < gameBoard.GetLength(0); i ++ ) {
                for ( int j = 0; j < gameBoard.GetLength(1); j++ ) {
                    Console.Write($"{gameBoard[i,j]}");
                }
                Console.WriteLine();
            }
        }
    }
}
