using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Capital_Avenue.Models;

namespace Capital_Avenue.Controllers
{
    using Views;
    using Models;
    public class COGameManager
    {
        //À faire :
        // - Lancement aléatoire des dés
        // - Affichage de la "page" de lancer de dés
        // - Initialisation du jeu au départ
        // - Récupération des joueurs et affichage (Namory)
        // - Tirage aléatoire de carte (Sébastien)
        // - Gestion des achats, dont le code sera dans CLPropriety, qui vérifera si la case est déjà possédé ou non (Maguette)
        // - Gestion de l'argent, qui vérifiera si une case est déjà acheté, et ce qui ce passe quand on doit payer (Clément)
        // - En raison de la similitude des deux premières, deux faux comptes joueurs + trois case achetés sera intégrés à chaque faux joueurs pour aisance de test
        // - Déplacement du pion (récupération de la valeur des dés, vérification de si le dés ne pas dépacé la valeur max et si oui, faire un bon déplacement)
        // - 
        // 

        /*public Random dice = new Random();
        public int DTResult;
        private int baseCapital = 1500;
        public string Name { get; set; }
        public string Pawn { get; set; }

        public static List<CLPlayer> playersList;

        public string FaPlay1Name = "One";
        public string FaPlay2Name = "two";
        public string FaPlay1Pawn = "Dog";
        public string FaPlay2Pawn = "Car";
        internal string CPlayName; //Pour vérifier qui est le joueur actuel, à voir comment l'ajouter.
        internal int CPlayTurn = 0; //Pour vérifier quel est le tour actuel du jouer actif.
        //public int newIndex; //Sert à affecter la nouvelle position du pion.

        public int DiceThrower() //Le programme de lancer de dés est fait, mais rien n'arrivera à le récupérer car la views ne fonctionne pas correctement.
        {
            DTResult = 0;
            for (int i = 0; i < 2; i++)
            {
                DTResult += dice.Next(1, 7);
            }
            return DTResult;
        }

        /* public void gmaddPlayer(string name, string pawn) //Idée de l'ajout des joueurs est là, mais faudra trouver un moyen de lire les noms depuis le jeu (Namory)
         {
             for | foreach //faudra voir comment bien ajouter ça, pour ajouter le bon nom au bon joueur etc.
             CLPlayer player = new CLPlayer(name, pawn, baseCapital);
         }*/

        /*public void gmAddPlayerFake() //Zone créé pour les tests d'affichage, de fausse zone acheté et de perte|gain d'argent. Peut être d'autres trucs aussi.
        {
            CLPlayer Fake1 = new CLPlayer(FaPlay1Name, FaPlay1Pawn, baseCapital);
            CLPlayer Fake2 = new CLPlayer(FaPlay2Name, FaPlay2Pawn, baseCapital);
        }*/
        /*public void init()
        {
            CLPlayer Fake1 = new CLPlayer(FaPlay1Name, FaPlay1Pawn, baseCapital);
            CLPlayer Fake2 = new CLPlayer(FaPlay2Name, FaPlay2Pawn, baseCapital);
            playersList = new List<CLPlayer>()
            {
                Fake1 , Fake2
            };
        }
        
        public void readInput()
        {
            //l'endroit pour lire les boutons... Faudra sûrement séparer ça en diverses fonction, chacune liée à ce quelle fait (lancer de dés, fin de tour, achat,
            //utilisation de carte, lancement des enchères, dire qu'on se mets en faillite.
            throw new NotImplementedException();
        }
        

        public int movement(int DTResult)
        {
            throw new NotImplementedException();
            //return newIndex;
        }

        public string OnAction(/*Pawn.Index //Devra vérif l'index du pion, soit où il se trouve. Aucune idée de comment gérer ça pour l'instant)
        /*{
            throw new NotImplementedException();
        }*/
    }
}
