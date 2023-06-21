using Capital_Avenue.Views;
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
        public List<Player> PlayerList { get; private set; }
        public int CurrentPlayer;
        public Dice Dice { get; private set; }
        private int Ldice = 0;
        private int NbDice = 2;
        public Game(List<Player> pList)
        {
            PlayerList = pList;
            CurrentPlayer = 0;
            Dice = new Dice();
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
                    if (PlayerList[CurrentPlayer].TotalDouble > 2)
                    {
                        Dice.ResultDice = 0;
                        PlayerList[CurrentPlayer].TotalDouble = 0;
                        MessageBox.Show($"Trois Double à la suite. En Prison.");
                        PlayerList[CurrentPlayer].isInJail = true;
                    }
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

