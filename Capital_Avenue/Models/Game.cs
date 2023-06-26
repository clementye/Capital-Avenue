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
        public Board GameBoard { get; set; }
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

        public void SellProperty()
        {
            throw new NotImplementedException();
            // TO DISPLAY, SO SOMEONE ELSE : Show the player all of his property, and let him select those he want to sell
            // TO DISPLAY, SO SOMEONE ELSE : When he want to sell them, activate the function SellProperty
            // When he sell, the function check each property to then sell each houses/hotel on it,
            // giving half the value of their purchase price (normally common for all) <- Calling the resell of house function as many times as necessary
            // When it's done, sell the properties and giving the half the money of purchase, also being the same value for the mortgage
            // After it's done, it's done.
        }

        public void MortgageProperty()
        {
            throw new NotImplementedException();
            // Will most likely be put in models/property.cs
            // Will just change one parameter of the properties selectionned to IsInBank = true;
            // So, the job of the one doing the property and the HOUSES
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

