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

        //Le système de lancer de dés est chiant à faire, faudra que je trouve une technique pour ça.
        //J'arrive pas à juste le faire s'afficher par dessus le reste en étant semi-transparent. Il doit y avoir une technique.
        public UCMonopoly() //Always here
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            //this.dicethrow();
            this.addPlayerPanel();

            /*this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location; */
        }

        public void addPlayerPanel()
        {
            LeftUCPanel lucp = new LeftUCPanel();
            lucp.Size = new Size(800, 840);
            this.Controls.Add(lucp);
        }

        /*public void dicethrow()
        {
            UCDiceThrower ucdt = new UCDiceThrower();
            ucdt.Size = new Size(1440, 840);
            ucdt.BringToFront();
            this.Controls.Add(ucdt);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
        }*/
        public void UserControl(string name)
        {

        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UCMonopoly_Load(object sender, EventArgs e)
        {

        }
    }
}
