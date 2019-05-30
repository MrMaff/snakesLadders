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
        Game game;
        ShakerDrawer shaker;
        BoardDrawer board;
        Shaker roller = new Shaker();
        Player currentPlayer;


        public TableTop(Game game)
        {
            InitializeComponent();
            this.game = game;
        }

        private void TableTop_Load(object sender, EventArgs e)
        {
            shaker = new ShakerDrawer(pbx_Shaker.Width, pbx_Shaker.Height);
            board = new BoardDrawer(pbx_Board.Width, pbx_Board.Height);

            pbx_Shaker.Image = shaker.DrawShaker();   
            pbx_Board.Image = board.DrawBoard();
            btn_NextPlayer.Enabled = false;

            currentPlayer = game.CurrentPlayer;
            updatePlayerName();
        }

        private void btn_roll_Click(object sender, EventArgs e)
        {
            btn_roll.Enabled = false;
            currentPlayer.Move(roller.GetTotal(), GameBoard: game.gameboard);
            if (roller.CompareDice())
            {
                pbx_Shaker.Image = shaker.DrawShaker(roller.Dice1.FaceValue, roller.Dice2.FaceValue, roller.Dice3.FaceValue);
            }
            else pbx_Shaker.Image = shaker.DrawShaker(roller.Dice1.FaceValue, roller.Dice2.FaceValue);

            pbx_Board.Image = board.UpdateBoard(game.gameboard);
            

            currentPlayer.ApplyRules(GameBoard: game.gameboard);
            

            pbx_Board.Image = board.UpdateBoard(game.gameboard);

            if (currentPlayer.winner)
            {
                //Declare Winner
                MessageBox.Show($" {currentPlayer.Name} You Win!");
            }
            else
            {
                //Show Next player Button
                btn_NextPlayer.Enabled = true;
            }
        }

        private void btn_NextPlayer_Click(object sender, EventArgs e)
        {
            game.NextPlayer();
            currentPlayer = game.CurrentPlayer;
            updatePlayerName();
            btn_roll.Enabled = true;
            btn_NextPlayer.Enabled = false;
        }

        private void updatePlayerName()
        {
            lbl_PlayerName.Text = $"Player: {currentPlayer.Name} It's your turn! ";
        }
    }
}
