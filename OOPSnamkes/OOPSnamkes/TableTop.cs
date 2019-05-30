using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPSnamkes
{
    public partial class TableTop : Form
    {
        ShakerDrawer shaker;
        BoardDrawer board;
        Shaker roller = new Shaker();


        public TableTop()
        {
            InitializeComponent();
        }

        private void TableTop_Load(object sender, EventArgs e)
        {
            shaker = new ShakerDrawer(pbx_Shaker.Width, pbx_Shaker.Height);
            board = new BoardDrawer(pbx_Board.Width, pbx_Board.Height);


            pbx_Shaker.Image = shaker.DrawShaker();
            
            pbx_Board.Image = board.DrawBoard();
        }

        private void btn_roll_Click(object sender, EventArgs e)
        {
            
            roller.GetTotal();
            pbx_Shaker.Image = shaker.DrawShaker(roller.Dice1.FaceValue, roller.Dice2.FaceValue);
        }
    }
}
