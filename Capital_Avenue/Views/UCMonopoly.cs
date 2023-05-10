using Capital_Avenue.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capital_Avenue.Views
{
    public partial class UCMonopoly : UserControl
    {
        
        private Game currentGame;
        private LeftUCPanel UCLeftPanel;
        public UCMonopoly(Game game)
        {
            InitializeComponent();
            this.currentGame = game;

            this.Dock = DockStyle.Fill;
            this.addPlayerPanel();

            /*this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location; */
        }

        public void addPlayerPanel()
        {
            UCLeftPanel = new LeftUCPanel(currentGame.playerList);
            UCLeftPanel.Size = new Size(500, 840);
            this.Controls.Add(UCLeftPanel);
            
        }

        public void onDiceClick()
        {
            // je lance les dés, je réfresh l'affichage, je déplace l'icone du joueur, j'actualise le monde.

            UCLeftPanel.UpdateValues();
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
    }
}
