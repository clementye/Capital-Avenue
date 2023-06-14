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
            Dice.DoubleDice = 0;
            switch(Dice.isDouble)
            {
                case false: 
                    PlayerList[CurrentPlayer].TotalDouble = 0;
                    break;
                case true:
                    PlayerList[CurrentPlayer].TotalDouble++;
                    if (PlayerList[CurrentPlayer].TotalDouble <= 2)
                    {
                        Dice.DoubleDice = rnd.Next(1, 7);
                        Dice.ResultDice += Dice.DoubleDice;
                    }
                    else
                    {
                        Dice.ResultDice = 0;
                        PlayerList[CurrentPlayer].TotalDouble = 0;
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

