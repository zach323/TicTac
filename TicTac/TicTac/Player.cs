using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTac
{
    class Player
    {
        //for holding player's X or O
        private string Marker;

        public Player(string marker)
        {
            Marker = marker;
        }

        public string GetMarker()
        {
            return Marker;
        }


    }
}
