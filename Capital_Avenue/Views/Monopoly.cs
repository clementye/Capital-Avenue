
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
            this.AddPlayerPanel();
            currentPlayerName.Text = game.PlayerList[0].Name + ", lancer vos dés";
            this.InitializeDice();
            ucBoard1.InitPawns(game.PlayerList);
        }
        public void InitializeDice()
        {
            currentGame.DiceInit();
            pictureBox2.Enabled = false;
            pictureBox2.BackColor = Color.Red;
            pictureBox1.BackColor = Color.Green;
            this.DisplayDiceResult();
        }

        public void AddPlayerPanel()
        {
            UCLeftPanel = new LeftPanel(currentGame.PlayerList);
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
            DiceResultShow.Text = "Résultats  " + currentGame.Dice.ResultDice.ToString();
        }
        public void ShowDice()
        {

            currentGame.DiceResult();
            this.DisplayDiceResult();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            this.ShowDice();
            if (currentGame.Dice.isDouble == false)
            {
                pictureBox1.Enabled = false;
                //pictureBox1.Enabled = false;
                pictureBox1.BackColor = Color.Red;
                pictureBox2.Enabled = true;
                pictureBox2.BackColor = Color.Green;
            }
            int currentPlayerIndex = currentGame.CurrentPlayer;
            Player currentPlayer = currentGame.PlayerList[currentPlayerIndex];
            ucBoard1.MovePawn(currentPlayer, currentGame.Dice.ResultDice);
            UCLeftPanel.UpdatePlayerUC(currentGame.PlayerList[currentGame.CurrentPlayer]);

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            currentGame.EndTurn();
            pictureBox1.Enabled = true;
            pictureBox1.BackColor = Color.Green;
            pictureBox2.BackColor = Color.Red;
            pictureBox2.Enabled = false;
            currentPlayerName.Text = currentGame.PlayerList[currentGame.CurrentPlayer].Name + ", lancer vos dés";
            UCLeftPanel.UpdatePlayerUC(currentGame.PlayerList[currentGame.CurrentPlayer]);

        }

        private void onBankruptButton_Click(object sender, EventArgs e)
        {
            onBankrupt_Click();
        }
        public void onBankrupt_Click()
        {
            DialogResult result = MessageBox.Show($"{char.ToUpper(currentGame.PlayerList[currentGame.CurrentPlayer].Name[0]) + currentGame.PlayerList[currentGame.CurrentPlayer].Name.Substring(1)} are you sure you want to declare bankruptcy?", "Confirm Bankruptcy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                currentGame.Bankruptcy();
                UCLeftPanel.UpdatePlayerUC(currentGame.PlayerList[currentGame.CurrentPlayer]);
            }
        }

    }
}
