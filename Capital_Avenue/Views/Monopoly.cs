using Capital_Avenue.Models;
using Capital_Avenue.Services;
using Capital_Avenue.Views.Auction;
using Capital_Avenue.Views.Board;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Imaging;
using System.Linq;
using System.Media;
using System.Numerics;
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
        private Button quitButton;

        public Monopoly(Game game)
        {
            InitializeComponent();
            this.BackgroundImage = Properties.Resources.font1;
            this.BackgroundImageLayout = ImageLayout.Stretch;
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

            quitButton = new Button();
            quitButton.Click += quitButton_Click;
            this.Controls.Add(quitButton);
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
            switch (currentGame.PlayerList[currentGame.CurrentPlayer].isInJail)
            {
                case true:
                    pictureBox1.Enabled = false;
                    pictureBox1.BackColor = Color.Red;
                    pictureBox2.Enabled = true;
                    pictureBox2.BackColor = Color.Green;
                    currentGame.JailDice();
                    break;
                case false:
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
                    break;
            }
            if (currentGame.PlayerList[currentGame.CurrentPlayer].Capital < 0)
            {
                this.BankruptAction();
            }
            UCLeftPanel.UpdatePlayerUC(currentGame.PlayerList[currentGame.CurrentPlayer]);
            this.ChangeOwnerShow();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            currentGame.EndTurn();
            pictureBox1.Enabled = true;
            pictureBox1.BackColor = Color.Green;
            pictureBox2.BackColor = Color.Red;
            pictureBox2.Enabled = false;
            switch (currentGame.PlayerList[currentGame.CurrentPlayer].isInJail)
            {
                case true:
                    currentGame.JailAction();
                    currentPlayerName.Text = currentGame.PlayerList[currentGame.CurrentPlayer].Name;
                    break;
                case false:
                    currentPlayerName.Text = currentGame.PlayerList[currentGame.CurrentPlayer].Name;
                    break;
            }
            UCLeftPanel.UpdatePlayerUC(currentGame.PlayerList[currentGame.CurrentPlayer]);
        }
        public void onBankrupt_Click(object sender, EventArgs e)
        {
            this.BankruptAction();
            currentPlayerName.Text = currentGame.PlayerList[currentGame.CurrentPlayer].Name;
            UCLeftPanel.UpdatePlayerUC(currentGame.PlayerList[currentGame.CurrentPlayer]);
            this.ChangeOwnerShow();
        }

        public void BankruptAction()
        {
            if (currentGame.PlayerList[currentGame.CurrentPlayer].Capital < 0)
            {
                PlayBankruptSoundEffect();
                currentGame.Bankruptcy();
            }
            else
            {
                DialogResult result = MessageBox.Show($"{char.ToUpper(currentGame.PlayerList[currentGame.CurrentPlayer].Name[0]) + currentGame.PlayerList[currentGame.CurrentPlayer].Name.Substring(1)} are you sure you want to declare bankruptcy?", "Confirm Bankruptcy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    PlayBankruptSoundEffect();
                    currentGame.Bankruptcy();
                }
                
            }
        }

        private void PlayBankruptSoundEffect()
        {
            try
            {
                SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.bankrupt_sound);
                soundPlayer.Play();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error playing bankrupt sound effect: " + ex.Message);
            }
        }

        private void SMButton_Click(object sender, EventArgs e)
        {
            SellMortgage SMA = new SellMortgage();
            string Action = "Sell";
            SMA.SMABox(currentGame.PlayerList[currentGame.CurrentPlayer], Action);
            SMA.ShowDialog();
            this.ChangeOwnerShow();
        }

        private void AuctionButton_Click(object sender, EventArgs e)
        {
            OtherPlayerChoice AuctionChoice = new OtherPlayerChoice();
            AuctionChoice.OPABox(currentGame.PlayerList[currentGame.CurrentPlayer], currentGame.PlayerList);
            AuctionChoice.ShowDialog();
            currentPlayerName.Text = currentGame.PlayerList[currentGame.CurrentPlayer].Name;
            this.ChangeOwnerShow();
        }
        private void quitButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to quit the game?", "Quit Game", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                PlayClosingSoundEffect();
                Task.Delay(2000).Wait();
                Application.Exit();
            }
        }

        private void PlayClosingSoundEffect()
        {
            try
            {
                SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.close);
                soundPlayer.Play();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error playing door sound effect: " + ex.Message);
            }
        }

        private void ChangeOwnerShow()
        {
            foreach (ProOwned PO in ucBoard1.CaseOwner)
            {
                foreach (Property P in currentGame.PlayerList[currentGame.CurrentPlayer].OwnedProperties)
                {
                    PO.UpdateShow(currentGame.PlayerList[currentGame.CurrentPlayer], P, currentGame.PlayerList);

                }
            }
        }
    }
}