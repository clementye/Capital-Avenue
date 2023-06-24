using Capital_Avenue.Models;
using Capital_Avenue.Services;
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
        private PictureBox pictureBox = new PictureBox();
        private PictureBox picture = new PictureBox();
        private Image[] images = ConfigService.GetDice();
        private int diceIndex;
        private System.Windows.Forms.Timer diceTimer;

        public Monopoly(Game game)
        {
            InitializeComponent();
            this.currentGame = game;
            this.AddPlayerPanel();
            currentPlayerName.Text = currentGame.PlayerList[0].Name.ToUpper();
            currentPlayerName.Font = new Font(Label.DefaultFont, FontStyle.Bold);
            this.InitializeDice();
            ucBoard1.Init(game);

            diceIndex = 0;

            diceTimer = new System.Windows.Forms.Timer();
            diceTimer.Interval = 70;
            diceTimer.Tick += DiceTimer_Tick;
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
                    pictureBox.Image = images[currentGame.Dice.DiceList[i]];
                    pictureBox.Size = new Size(100, 100);
                    Dice_lef.Controls.Add(pictureBox);
                }
                else
                {
                    picture.Image = images[currentGame.Dice.DiceList[i]];
                    picture.Size = new Size(100, 100);
                    dice_right.Controls.Add(picture);
                }
            }
            // DiceResultShow.Text = "Résultats  " + currentGame.Dice.ResultDice.ToString();
        }

        public async void ShowDice()
        {
            currentGame.DiceResult();
            diceIndex = 0;
            await Task.Delay(currentGame.Dice.DiceList.Count * diceTimer.Interval);
            diceTimer.Start();
            this.DisplayDiceResult();



        }

        private void DiceTimer_Tick(object sender, EventArgs e)
        {
            // Update the dice image and increment the dice index
            if (diceIndex < currentGame.Dice.DiceList.Count)
            {
                if (diceIndex == 0)
                {
                    pictureBox.Image = images[currentGame.Dice.DiceList[diceIndex]];
                    pictureBox.Size = new Size(100, 100);
                    Dice_lef.Controls.Add(pictureBox);
                }
                else
                {
                    picture.Image = images[currentGame.Dice.DiceList[diceIndex]];
                    picture.Size = new Size(100, 100);
                    dice_right.Controls.Add(picture);
                }

                diceIndex++;
            }
            else
            {
                diceTimer.Stop();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.ShowDice();
            if (currentGame.Dice.isDouble == false)
            {
                pictureBox1.Enabled = false;
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
            currentPlayerName.Text = currentGame.PlayerList[currentGame.CurrentPlayer].Name;
            //currentPlayerName.Font = new Font("Arial", currentPlayerName.Font.Size);
            UCLeftPanel.UpdatePlayerUC(currentGame.PlayerList[currentGame.CurrentPlayer]);
        }

        public void onBankrupt_Click()
        {
            currentGame.Bankruptcy();
            UCLeftPanel.UpdatePlayerUC(currentGame.PlayerList[currentGame.CurrentPlayer]);
        }


    }
}
