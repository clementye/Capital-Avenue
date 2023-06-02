
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
    public partial class Monopoly : UserControl
    {

        private Game currentGame;
        private LeftPanel UCLeftPanel;
        private Dice d;
        private int Ldice = 0;
        private int NbDice = 2;
        public Monopoly(Game game)
        {
            InitializeComponent();
            this.currentGame = game;
            //this.Dock = DockStyle.Fill;
            this.addPlayerPanel();
            //this.addPawnPanel();
            currentPlayerName.Text = "Joueur " + game.playerList[game.currentPlayer].Name + ", lancer vos dés";
            d = new Dice();
            d.addDice(Ldice, NbDice);
            for (int i = 0; i < d.DiceList.Count; i++)
            {
                if (i == 0)
                {
                    DiceShow.Text = "Dés : " + d.DiceList[i].ToString();
                }
                else
                {
                    DiceShow.Text += " + " + d.DiceList[i].ToString();
                }

            }
            DiceResultShow.Text = "Résultats " + d.ResultDice.ToString();

            /*this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location; */
            ucBoard1.InitPawns(game.playerList);

        }

        public void addPlayerPanel()
        {
            UCLeftPanel = new LeftPanel(currentGame.playerList);
            UCLeftPanel.Size = new Size(500, 840);
            this.Controls.Add(UCLeftPanel);

        }

        /*public void addPawnPanel()
        {
            foreach (CLPawn p in currentGame.pawnList)
            {
                UCPawn = new UCPawn(p);
                UCPawn.Size = new Size(40, 40);
                UCPawn.Location = new Point(550, 100);
                UCPawn.BringToFront();
                this.Controls.Add(UCPawn);

            }
        }*/

        public void diceShow()
        {

        }

        public void onDice_Click(object sender, EventArgs e)
        {
            // je lance les dés, je réfresh l'affichage, je déplace l'icone du joueur, j'actualise le monde.
            currentGame.Action();
            Test.Text = "Hihi";
            //UCLeftPanel.UpdateValues();

            // launch a dice
            //int diceResult = 2; // TODO
            //ucBoard1.MovePawn(currentGame.playerList[currentPlayer], diceResult);
            // do the cell action
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
