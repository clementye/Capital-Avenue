using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capital_Avenue.Models
{
    public class Game
    {
        public List<CLPlayer> playerList { get; private set; }
        public List<CLPawn> pawnList { get; private set; }

        public int currentPlayer = 0;
        public List<CLPlayer> BankruptList { get; private set; }

        public CLDice CLDice { get; private set; }
        public CLPawn CLPawn { get; private set; }
        public CLCase CLCase { get; private set; }

        public Game(List<CLPlayer> pList)
        {
            playerList = pList;
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

        public void Action()
        {
                throw new NotImplementedException();
                int newCoor = CLDice.DiceThrower();
                CLPawn.locationUpdate(newCoor); //To launch the dice after clicking on the button
                                                //Do Action after moving the Pawn, so either through GameManager or calling the OnAction() of CLCase
                //CLCase.OnAction(CLPawn.Index);
                this.EndTurn();
                
        }

        public void EndTurn()
        {
            if (currentPlayer < playerList.Count())
            {
                currentPlayer++;
            }
            else
            {
                currentPlayer = 0;
            }
        }
    }
}

