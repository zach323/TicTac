using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTac

{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine();
            Player player1 = new Player("X");
            Player player2 = new Player("O");

            Board board = new Board();
            board.Initialize();
            board.Render();
            Position position = new Position(1, 2);
            board.SetPosition(position, player1);
            board.Render();

        }
    }
}
