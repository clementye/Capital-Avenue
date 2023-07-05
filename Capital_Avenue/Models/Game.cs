using Capital_Avenue.Views;
using Capital_Avenue.Views.Board;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;


namespace Capital_Avenue.Models
{
    public class Game
    {
        Random rnd = new Random();
        public List<Player> PlayerList { get; set; }
        public int CurrentPlayer;
        public Dice Dice { get; private set; }
        private int Ldice = 0;
        private int NbDice = 2;
        private int TotalPlayer;
        public Board GameBoard { get; set; }
        public Game(List<Player> pList)
        {
            PlayerList = pList;
            CurrentPlayer = 0;
            Dice = new Dice();
        }
        

        public void DiceInit()
        {
            Dice.addDice(Ldice, NbDice);
            TotalPlayer = PlayerList.Count;
        }

        public void DiceResult()
        {
            PlayDiceThrowSoundEffect();

            Task.Delay(900).Wait();

            Dice.DiceThrower();
            switch (Dice.isDouble)
            {
                case false:
                    PlayerList[CurrentPlayer].TotalDouble = 0;
                    break;
                case true:
                    PlayerList[CurrentPlayer].TotalDouble++;
                    if (PlayerList[CurrentPlayer].TotalDouble > 2)
                    {
                        Dice.ResultDice = 0;
                        PlayerList[CurrentPlayer].TotalDouble = 0;
                        MessageBox.Show($"Three doubles in a row. In Jail.");
                        PlayerList[CurrentPlayer].isInJail = true;
                        PlayerList[CurrentPlayer].JailTurn = 3;
                        GameBoard.MovePlayerToJail(PlayerList[CurrentPlayer]);
                    }
                    break;
            }
        }
        private void PlayDiceThrowSoundEffect()
        {
            try
            {
                SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.dice_throw);
                soundPlayer.Play();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error playing dice throw sound effect: " + ex.Message);
            }
        }

        public void JailAction()
        {

            string message = $"Souhaitez-vous payer 50 pour sortir de prison ?";
            DialogResult result = MessageBox.Show(message, " Sortir de Prison ",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                PlayerList[CurrentPlayer].Capital -= 50;
                PlayerList[CurrentPlayer].isInJail = false;
            }
            // TODO :
            // Check if Player have the Card "GetOutOfJail"
            //If yes, show message asking if he want to play it.
        }
        public void JailDice()
        {
            switch (Dice.isDouble)
            {
                case false:
                    PlayerList[CurrentPlayer].JailTurn--;
                    break;
                case true:
                    PlayerList[CurrentPlayer].JailTurn = 0;
                    break;
            }
        }

        public void EndTurn()
        {
            int WinNumber = 1;
            if (PlayerList[CurrentPlayer].isBankrupt == true)
            {
                TotalPlayer--;
            }
                CurrentPlayer++;
                if (CurrentPlayer >= PlayerList.Count)
                {
                    CurrentPlayer = 0;
                }
                while (PlayerList[CurrentPlayer].isBankrupt == true) // Need to correct that, do not work at all.
                {
                    CurrentPlayer++;
                    if (CurrentPlayer >= PlayerList.Count)
                    {
                      CurrentPlayer = 0;
                    }
                TotalPlayer--;
                }
                if (WinNumber == TotalPlayer)
                {
                    this.WinGame(PlayerList[CurrentPlayer]);
                }
        }

        public void WinGame(Player winner)
        {
            PlayWinnerSoundEffect();
            Task.Delay(1877).Wait();
            string message = $"Player {winner.Name} has won the game!";
            DialogResult result = MessageBox.Show(message, "Congratulation !",MessageBoxButtons.OK,MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        private void PlayWinnerSoundEffect()
        {
            try
            {
                SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.winner_sound);
                soundPlayer.Play();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error playing winner sound effect: " + ex.Message);
            }
        }


        public void Bankruptcy()
        {
            Player currentPlayer = PlayerList[CurrentPlayer];

            if (currentPlayer.Capital <= 0 && currentPlayer.OwnedProperties.Count !=0 || currentPlayer.OwnedProperties.Count >= 0)
            {
                var test = currentPlayer.OwnedProperties.All(p => p.IsInBank == true);
                if (test == true)
                {
                    currentPlayer.isBankrupt = true;
                    // If time, give mortgaged properties to either bank or the other players, to not become bankrup. Not obligatory.
                    currentPlayer.Capital = 0;

                    MessageBox.Show($"Player {currentPlayer.Name} has gone bankrupt!", "Bankruptcy Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    currentPlayer.Capital = 0;
                    SellMortgage SMA = new SellMortgage();
                    string Action = "Sell";
                    SMA.SMABox(currentPlayer, Action);
                    SMA.ShowDialog();
                }
            }
            EndTurn();
        }
    }
}

