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
        public List<Player> playerList { get; private set; }
        public List<Pawn> pawnList { get; private set; }

        public int currentPlayer;
        public List<Player> BankruptList { get; private set; }

        public Dice Dice { get; private set; }
        public Pawn CLPawn { get; private set; }
        public Case CLCase { get; private set; }
        private int Ldice = 0;
        private int NbDice = 2;
        public Game(List<Player> pList)
        {
            playerList = pList;
            currentPlayer = 0;
            Dice = new Dice();
        }

        

        public void Bankruptcy()
        {
            throw new NotImplementedException();
            /*if () //Check the number of player that are bankrupt and if there is less that the total number of player-1 (so, at least 2 players still in game)
            {
                playerList[currentPlayer].isBankrupt = true;
                this.EndTurn();
            }
            else
            {
                playerList[currentPlayer].isBankrupt = true;
                this.EndTurn();
                
                //Va surement avoir besoin de l'appel d'une autre fonction pour afficher le gagnant.
                //Code pour afficher qui est le gagnant
                //string Winner = playerList[currentPlayer].Name; <- Pour le nom du gagnant.
                System.Windows.Forms.Application.Exit(); //Fin du jeu, force la fermeture du jeu. Pourra être changé pour ramener à la page d'accueil.
            }*/
            throw new NotImplementedException();
        }

        /*public void Action()
        {
            //throw new NotImplementedException();
                Dice.DiceThrower();
                this.DiceResult();
                //int newCoor = Dice.DiceThrower();
                //CLPawn.locationUpdate(newCoor); //To launch the dice after clicking on the button
                                                //Do Action after moving the Pawn, so either through GameManager or calling the OnAction() of CLCase
                //CLCase.OnAction(CLPawn.Index);
                //this.EndTurn();
                
        }*/

        public void DiceInit()
        {
            Dice.addDice(Ldice, NbDice);
        }
        
        public void DiceResult()
        {
            Dice.DiceThrower();
            Dice.DoubleDice = 0;
            switch(Dice.isDouble)
            {
                case false:
                    playerList[currentPlayer].TotalDouble = 0;
                    break;
                case true:
                    playerList[currentPlayer].TotalDouble++;
                    if (playerList[currentPlayer].TotalDouble <= 2)
                    {
                        Dice.DoubleDice = rnd.Next(1, 7);
                        Dice.ResultDice += Dice.DoubleDice;
                    }
                    else
                    {
                        Dice.ResultDice = 0; //When the program for movement read a zero, will force the player to go to prison
                        playerList[currentPlayer].TotalDouble = 0;
                    }
                    break;

            }
        }
        

        // Code for when a player is in prison, reduce the time left in prison by one if no Double, and release them if they got a double
        /*public void DicePrison()
        {
            switch (isDouble)
            {
                case false:
                    Player.PrisonTime--;
                    break;
                case true:
                    Player.PrisonTime = 0;
                    break;
            }
        }*/
        
        public void EndTurn()
        {
            currentPlayer++;
            if (currentPlayer >= playerList.Count)
            {
                currentPlayer = 0; 
            }
        }
    }
}

