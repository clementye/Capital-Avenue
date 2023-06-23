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
        public List<Player> PlayerList { get; private set; }
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

        

        public void Bankruptcy()
        {
            throw new NotImplementedException();
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
                        GameBoard.MovePlayerToJail(PlayerList[CurrentPlayer]);
                    }
                    break;
            }
        }
        
        public void EndTurn()
        {
            CurrentPlayer++;
            if (CurrentPlayer >= PlayerList.Count)
            {
                CurrentPlayer = 0; 
            }
        }
    }
}

