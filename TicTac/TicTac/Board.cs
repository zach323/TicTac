using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTac
{
    class Board
    {
        //array for board
         private string[,] boardGrid;



        public Board()
        { //init board
            boardGrid = new string[3, 3];
        }

        //set either "X" or "O" on to board based off player parameter.....in progress.
        public void SetPosition(Position position, Player player)
        { 
          if (player.GetMarker().Equals("X"))
            {
                boardGrid[position.Row,position.Column] = player.GetMarker();
            }
        }

      
        //set initial board with "*"in each grid location
        public void Initialize()
        {
            for (int row = 0; row < 3; row++)
            {

                for (int col = 0; col < 3; col++)
                {
                    boardGrid[row, col] = "*";
                }
            }
        }

        //display board and clear previous render to console.
        public void Render()
        {
            System.Console.Clear();
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(boardGrid[row, col]);
                } Console.WriteLine();
            }
        }
    }
    
}
