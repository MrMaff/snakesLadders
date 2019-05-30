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
        int squareSize { get { return board.Height / 10; } }


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
                //g.DrawImage(red, 0, (sqaureSize)*9, sqaureSize, sqaureSize);
            }

            return board;
        }

        public Bitmap UpdateBoard(Board gameboard)
        {
            using (Graphics g = Graphics.FromImage(board))
            {
                Image tempImg = null;
                g.DrawImage(squares, 0, 0, board.Width, board.Height);
                g.DrawImage(snakes, 0, 0, board.Width, board.Height);
                foreach (var square in gameboard.Squares)
                {
                    
                    if (square.Occupiers.Count > 0)
                    {
                        int shift = 0;
                        foreach (var player in square.Occupiers)
                        {
                            switch (player.Colour)
                            {
                                case "Red":
                                    tempImg = red;
                                    break;
                                case "Green":
                                    tempImg = green;
                                    break;
                                case "Yellow":
                                    tempImg = yellow;
                                    break;
                                case "Blue":
                                    tempImg = blue;
                                    break;
                                default:
                                    break;
                            }
                            shift = shift + 5;
                            g.DrawImage(tempImg, xloc(square.Number), yloc(square.Number) - shift, squareSize, squareSize);
                            shift = shift;
                        }
                    }
                    
                }
            }

            return board;
        }

        int xloc(int count)
        {
            int x = 0;
            if (count % 20 > 10)
            {
                //right to left
                x =  11 - (count % 10);
            }
            else
            {
                //left to right
                x = count % 10;
            }
            x = (squareSize * x) - squareSize;
            return x;
        }

        int yloc(int count)
        {
            int y = 0;
            double temp = count;
            y = (count / 10) + 1;
            y = (11 - y) * squareSize - squareSize;
            return y;
        }
    }
}
