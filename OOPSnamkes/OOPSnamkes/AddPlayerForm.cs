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

        }
    }
}
