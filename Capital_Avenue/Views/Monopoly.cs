
using Capital_Avenue.Models;
using Capital_Avenue.Views.Board;
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
        public Monopoly(Game game)
        {
            InitializeComponent();
            this.currentGame = game;
            this.addPlayerPanel();
            currentPlayerName.Text = game.playerList[0].Name + ", lancer vos dés";
            this.InitializeDice();
            ucBoard1.InitPawns(game.playerList);
        }
        public void InitializeDice()
        {
            currentGame.DiceInit();
            pictureBox2.Enabled = false;
            pictureBox2.BackColor = Color.Red;
            pictureBox1.BackColor = Color.Green;
            this.DisplayDiceResult();
        }

        public void addPlayerPanel()
        {
            UCLeftPanel = new LeftPanel(currentGame.playerList);
            UCLeftPanel.Size = new Size(500, 840);
            this.Controls.Add(UCLeftPanel);

        }
        public void DisplayDiceResult()
        {

            for (int i = 0; i < currentGame.Dice.DiceList.Count; i++)
            {
                if (i == 0)
                {
                    DiceShow.Text = " Dés  :  " + currentGame.Dice.DiceList[i].ToString();
                }
                else
                {
                    DiceShow.Text += "  +  " + currentGame.Dice.DiceList[i].ToString();
                }
            }
            if (currentGame.Dice.DoubleDice > 0)
            {
                DiceShow.Text += " + " + currentGame.Dice.DoubleDice.ToString();
            }
            DiceResultShow.Text = "Résultats  " + currentGame.Dice.ResultDice.ToString();
        }
        public void diceShow()
        {

            currentGame.DiceResult();
            this.DisplayDiceResult();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            this.diceShow();
            pictureBox1.Enabled = false;
            //pictureBox1.Enabled = false;
            pictureBox1.BackColor = Color.Red;
            pictureBox2.Enabled = true;
            pictureBox2.BackColor = Color.Green;
            int currentPlayerIndex = currentGame.currentPlayer;
            Player currentPlayer = currentGame.playerList[currentPlayerIndex];
            ucBoard1.MovePawn(currentPlayer, currentGame.Dice.ResultDice);
            UCLeftPanel.UpdatePlayerUC(currentGame.playerList[currentGame.currentPlayer]);

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            currentGame.EndTurn();
            pictureBox1.Enabled = true;
            pictureBox1.BackColor = Color.Green;
            pictureBox2.BackColor = Color.Red;
            pictureBox2.Enabled = false;
            currentPlayerName.Text = currentGame.playerList[currentGame.currentPlayer].Name + ", lancer vos dés";
            UCLeftPanel.UpdatePlayerUC(currentGame.playerList[currentGame.currentPlayer]);

        }

        public void onBankrupt_Click()
        {
            currentGame.Bankruptcy();
            UCLeftPanel.UpdatePlayerUC(currentGame.playerList[currentGame.currentPlayer]);

        }
    }
}
