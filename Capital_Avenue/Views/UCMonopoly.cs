using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capital_Avenue.Views
{
    public partial class UCMonopoly : UserControl
    {
        private string hexPlay1 = "#6aff2d";

        public UCMonopoly()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.addPlayerPanel();

            /*this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location; */
        }

        public void addPlayerPanel()
        {
            LeftUCPanel lucp = new LeftUCPanel();
            lucp.Size = new Size(500, 840);
            this.Controls.Add(lucp);
        }
        public void UserControl(string name)
        {

        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UCMonopoly_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

    }
}
