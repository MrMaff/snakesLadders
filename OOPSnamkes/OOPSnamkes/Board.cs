using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSnamkes
{
    class Board
    {
        private List<Square> squares;

        public List<Square> Squares
        {
            get
            {
                return squares;
            }
        }

        public Board()
        {
            LoadBoard();
        }

        private void LoadBoard()
        {

        }
    }
}
