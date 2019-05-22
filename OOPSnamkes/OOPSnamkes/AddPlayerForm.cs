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
        public List<Player> Players { get { return players; } }
        private bool validColour;
        private bool validName;

        public AddPlayerForm()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Player tempPlayer = new Player();
            tempPlayer.SetName(tbx_Name.Text);
            tempPlayer.SetColour(cbx_Colour.SelectedItem.ToString());
            players.Add(tempPlayer);
            btn_Add.Enabled = false;
            validColour = false;
            validName = false;
            cbx_Colour.Items.Remove(cbx_Colour.SelectedItem);
            tbx_Name.Text = "";

            if (cbx_Colour.Items.Count != 0)
            {
                cbx_Colour.SelectedIndex = 0;
            }
            
                updateInstructions();
                CheckReadyToPlay();

            
        }

        private void AddPlayerForm_Load(object sender, EventArgs e)
        {
            players = new List<Player>();
            btn_Add.Enabled = false;
            btn_OK.Enabled = false;
            validColour = false;
            validName = false;
        }
        
        private void updateInstructions()
        {
            lbl_Player.Text = $"Player {(players.Count + 1).ToString()} Enter your name and choose your colour " ;
        }

        private void CheckReadyToPlay()
        {
            if (players.Count >= 2)
            {
                btn_OK.Enabled = true;
            }
            if (players.Count > 4)
            {
                btn_OK.Enabled = false;
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            btn_Cancel.DialogResult = DialogResult.Cancel;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            btn_OK.DialogResult = DialogResult.OK;
        }

        private void cbx_Colour_SelectedValueChanged(object sender, EventArgs e)
        {
            if(((ComboBox)sender).SelectedItem != null)
            {
                validColour = true;
            }
            checkPlayerDetails();
        }

        private void checkPlayerDetails()
        {
            if(validName == true && validColour == true)
            {
                btn_Add.Enabled = true;
            }
        }

        private void tbx_Name_TextChanged(object sender, EventArgs e)
        {
            if(((TextBox)sender).Text != "")
            {
                validName = true;
            }
            checkPlayerDetails();
        }
    }
}
