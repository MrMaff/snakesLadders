using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace OOPSnamkes
{
    public class Board
    {
        public List<Square> Squares;

        public Board()
        {
            LoadBoard();
        }

        private void LoadBoard()
        {
            Regex IamREGEX = new Regex(@"(\d+)(\w+)(\d*)");

            string Boardtxt = OOPSnamkes.Properties.Resources.IamTheBOARD;
            List<string> currentFile = Boardtxt.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();

            Squares = new List<Square>();

            string temp;
            string[] temp2;
            int count = 1;


            while (currentFile.Count != 0)
            {
                temp = currentFile.First();
                temp2 = IamREGEX.Split(temp);

                switch (temp2[2])
                {
                    case "Normal":
                        for (int i = 0; i < Convert.ToInt32(temp2[1]); i++)
                        {
                            Squares.Add(new Normal(count));
                            count++;
                        }
                        break;
                    case "Snake":
                        Squares.Add(new Snake(count, Convert.ToInt32(temp2[3])));
                        count++;
                        break;
                    case "Ladder":
                        Squares.Add(new Ladder(count, Convert.ToInt32(temp2[3])));
                        count++;
                        break;
                    case "Finito":
                        Squares.Add(new Final(count));
                        count++;
                        break;
                }

                currentFile.RemoveAt(0);


            }
        }
    }
}
