using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOPSnamkes
{
    public class BoardDrawer
    {

        Bitmap board = null;
        Image squares = Properties.Resources.snlboard001;
        Image snakes = Properties.Resources.s_l;
        Image red = Properties.Resources.redCounter;
        Image yellow = Properties.Resources.yellowCounter;
        Image green = Properties.Resources.greenCounter;
        Image blue = Properties.Resources.blueCounter;


        public BoardDrawer()
        {
            board = new Bitmap(600, 600);
        }

        public BoardDrawer(int x, int y)
        {
            board = new Bitmap(x, y);
        }

        public Bitmap DrawBoard()
        {
            using (Graphics g = Graphics.FromImage(board))
            {
                g.DrawImage(squares, 0, 0, board.Width, board.Height);
                g.DrawImage(snakes, 0, 0, board.Width, board.Height);
                g.DrawImage(red, 0, (board.Height / 10)*9, board.Width/10, board.Height / 10);
            }

            return board;
        }

    }
}
