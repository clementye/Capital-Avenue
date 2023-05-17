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
        private UCPawn UCPawn;
        public UCMonopoly(Game game)
        {
            InitializeComponent();
            this.currentGame = game;

            this.Dock = DockStyle.Fill;
            this.addPlayerPanel();
            this.addPawnPanel();

            /*this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location; */
        }

        public void addPlayerPanel()
        {
            UCLeftPanel = new LeftUCPanel(currentGame.playerList);
            UCLeftPanel.Size = new Size(400, 640);
            this.Controls.Add(UCLeftPanel);

        }

        public void addPawnPanel()
        {
            foreach (CLPawn p in currentGame.pawnList)
            {
                UCPawn = new UCPawn(p);
                UCPawn.Size = new Size(40, 40);
                UCPawn.Location = new Point(550, 100);
                UCPawn.BringToFront();
                this.Controls.Add(UCPawn);

            }
        }

        public void onDice_Click()
        {
            // je lance les dés, je réfresh l'affichage, je déplace l'icone du joueur, j'actualise le monde.
            currentGame.Action();
            UCLeftPanel.UpdateValues();
        }

        public void onBankrupt_Click()
        {
            currentGame.Bankruptcy();
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
