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
            using (StreamReader currentFile = new StreamReader(OOPSnamkes.Properties.Resources.IamTheBOARD))
            {
                string temp;
                string[] temp2;

                while (!currentFile.EndOfStream)
                {
                    temp = currentFile.ReadLine();
                    temp2 = IamREGEX.Split(temp);

                    switch (temp2[2])
                    {
                        case "Normal":
                            for(int i = 0; i < Convert.ToInt32(temp2[1]); i++)
                            {
                                Squares.Add(new Normal());
                            }
                            break;
                        case "Snake":
                                Squares.Add(new Snake(Convert.ToInt32(temp2[3])));
                            break;
                        case "Ladder":
                            Squares.Add(new Ladder(Convert.ToInt32(temp2[3])));
                            break;
                        case "Finito":
                            Squares.Add(new Final());
                            break;
                    }
                    
                }
            }
        }
    }
}
