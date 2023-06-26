using Capital_Avenue.Views.Board;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

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
        public Board GameBoard { get; private set; }
        public Game(List<Player> pList)
        {
            PlayerList = pList;
            CurrentPlayer = 0;
            Dice = new Dice();
            GameBoard = new Board();

        }

        public void DiceInit()
        {
            Dice.addDice(Ldice, NbDice);
        }
        
       public void DiceResult()
        { //Change it to actual double rule
            Dice.DiceThrower();
            switch(Dice.isDouble)
            {
                case false: 
                    PlayerList[CurrentPlayer].TotalDouble = 0;
                    break;
                case true:
                    PlayerList[CurrentPlayer].TotalDouble++;
                    if (PlayerList[CurrentPlayer].TotalDouble > 0)
                    {
                        Dice.ResultDice = 0;
                        PlayerList[CurrentPlayer].TotalDouble = 0;
                        MessageBox.Show($"Trois Double à la suite. En Prison.");
                        PlayerList[CurrentPlayer].isInJail = true;
                        PlayerList[CurrentPlayer].JailTurn = 3;
                        GameBoard.MovePlayerToJail(PlayerList[CurrentPlayer]);
                    }
                    break;
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
            // Check if Player have the Card "GetOutOfJail"
            //If yes, show message asking if he want to play it.
            //If not, will ask if want to pay.
            //If do not want to pay, then let him play the dice and try getting a double -> JailDice;
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
            Player currentPlayer = PlayerList[CurrentPlayer];

            if (currentPlayer.isBankrupt || currentPlayer.Capital < 0)
            {
                PlayerList.Remove(currentPlayer);
            }

            CurrentPlayer++;

            if (CurrentPlayer >= PlayerList.Count)
            {
                CurrentPlayer = 0;
            }

            if (PlayerList.Count == 1)
            {
                Player winner = PlayerList[0];
                MessageBox.Show($"Player {winner.Name} has won the game!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

        }

        public void Bankruptcy()
        {
            Player currentPlayer = PlayerList[CurrentPlayer];
            currentPlayer.isBankrupt = true;

            foreach (Property property in currentPlayer.OwnedProperties)
            {
                //TODO : Add the property back to the game pool or perform any other necessary actions/reset number property
            }
            currentPlayer.OwnedProperties.Clear();

            currentPlayer.Capital = 0;

            MessageBox.Show($"Player {currentPlayer.Name} has gone bankrupt!", "Bankruptcy Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            EndTurn(); 
        }
    }
}

