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
            Regex IamREGEX = new Regex(@"(\d+)(\w+)(\d*)");
            using (StreamReader currentFile = new StreamReader(OOPSnamkes.Properties.Resources.IamTheBOARD))
            {
                string temp;
                string[] temp2;

                while (!currentFile.EndOfStream)
                {
                    temp = currentFile.ReadLine();
                    temp2 = IamREGEX.Split(temp);

                    
                }
            }
        }
    }
}
