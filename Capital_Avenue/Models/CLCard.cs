using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capital_Avenue.Models
{
    public class CLCard : CLCase
    {
        string CardType { get; set; }
        public CLPawn CLPawn { get; private set; }
        public CLPlayer CLPlayer { get; private set; }

        public CLCard(int index, string name, string cardType) : base(index, name)
        {
            this.Name = name;
            this.Index = index;
            this.CardType = cardType;
        }

        public void OnAction()
        {
            string newCard = this.RandomCard(CLPawn);
            this.checkCard (newCard);
        }

        public string RandomCard(CLPawn pawn) //Faudra remplacer les magic numbers par deux liste, une pour la position des chances, et une autre pour l'autre cas. Cela simplifiera le tout.
            //Pareil pour les autres cases (Rue, Station, Gare, Spécial, ...)
        {
            if (pawn.Index == 2 || pawn.Index == 17 || pawn.Index == 33) //Case communitaire
            {
                string card = "Sortir_de_Prison"; //à remplacer par une génération aléatoire d'une carte en fonction de si c'est Chance ou Communotaire
                return card;
            }
            else if(pawn.Index == 7 || pawn.Index == 22 || pawn.Index == 36) //
            {
                string card = "Sortir_de_Prison";
                return card;
            }
            
        }

        public void checkCard(string card)
        {
            if (card.Contains("Sortir"))
            {
                CLPlayer.AddCards(card); //Accès au fichier non accordé, vois pas la raison pourquoi.
            }
            else if (card.Contains("Déplacer"))
            {
                int newCoor = int.Parse(card);
                CLPawn.locationUpdate(newCoor);
            }
            else if (card.Contains("Aller"))
            {   
                if (card.Contains("Prison"))
                {
                    CLPawn.updatePosition(30);
                }
                else
                {
                    throw new NotImplementedException(); //dans le cas où la carte dis d'aller vers une case autre que prison.
                }
                
            } *
            else if (card.Contains("Donner"))
            {
                throw new NotImplementedException(); //Dans le cas où une carte demande au joueur(s) de donner de l'argent à la banque/autre joueur
            }
            else 
            {
                throw new NotImplementedException(); //Dans le cas où la carte dis au joueur qu'il reçoit de l'argent.
            }
            
        }
    }
}
