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

            cbx_Colour.Items.Remove(cbx_Colour.SelectedItem);
            if (cbx_Colour.Items.Count>0)
            {
                //cbx_Colour.Text = cbx_Colour.Items.

            }
        }

        private void AddPlayerForm_Load(object sender, EventArgs e)
        {
            btn_Add.Enabled = false;
            btn_OK.Enabled = false;
        }
    }
}
