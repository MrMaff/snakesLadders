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
    public partial class AddPlayerForm : Form
    {

        private List<Player> players;

        public AddPlayerForm()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Player tempPlayer = new Player();
            tempPlayer.SetName(tbx_Name.Text);
            tempPlayer.SetColour(cbx_Colour.SelectedValue);
            players.Add(tempPlayer);
            btn_Add.Enabled = false;
            
            if (players.Count<4)
            {
                cbx_colours.Items.Remove(cbx_colours.SelectedItem);
                tbx_Name.Text = "";
                cbx_Colour.SelectedIndex = 0;
                updateInstructions();
                CheckReadyToPlay();
            }

            
        }

        private void AddPlayerForm_Load(object sender, EventArgs e)
        {
            btn_Add.Enabled = false;
            btn_OK.Enabled = false;
        }
        
        private void updateInstructions()
        {
            lbl_Instructions.Text = $"Player {(players.Count + 1).ToString()} Enter your name and choose your colour " ;
        }

        private void CheckReadyToPlay()
        {
            if (players.Count >= 2)
            {
                btn_OK.Enabled = true;
            }
            if (players.Count == 4)
            {
                btn_OK.Enabled = false;
            }
        }
        
    }
}
