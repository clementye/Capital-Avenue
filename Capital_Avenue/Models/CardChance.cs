using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capital_Avenue.Models
{
    public class CardChance
    {
        public int GetRandomChanceCardAction()
        {
            Random random = new Random();
            int action = random.Next(0, 10); // Génère un nombre aléatoire entre 0 et 9
            return action;
        }

        public void ExecuteChanceCardAction(Player player)
        {
            int action = GetRandomChanceCardAction(); // Obtenir une action aléatoire pour la carte Chance

            switch (action)
            {
                case 0:
                    GetMoney(player);
                    break;
                case 1:
                    MovePawnToStart(player);
                    break;
                case 2:
                    GoToColombia(player);
                    break;
                case 3:
                    GoToNigeria(player);
                    break;
                case 4:
                    RoadRepairs(player);
                    break;
                case 5:
                    GoToShortTrucks(player);
                    break;
                case 6:
                    WinCrosswordPrize(player);
                    break;
                case 7:
                    BankDividend(player);
                    break;
                case 8:
                    GoBackThreeSpaces(player);
                    break;
                case 9:
                    PayTuitionFee(player);
                    break;
                default:
                    break;
            }
        }

        public void GetMoney(Player player)
        {
            MessageBox.Show($"Vous avez reçu 300 euros, {player.Name}!");
            player.Capital += 300;
            // Ajoutez ici le code pour effectuer d'autres opérations liées à l'obtention d'argent
        }

        public void MovePawnToStart(Player player)
        {
            MessageBox.Show($"Vous avez été déplacé à la case départ, {player.Name}!");
            // Ajoutez ici le code pour déplacer le joueur à la case départ
        }

        public void GoToColombia(Player player)
        {
            MessageBox.Show($"Rendez-vous à Colombia, {player.Name}!");
            // Ajoutez ici le code pour déplacer le joueur à la case Colombia
        }

        public void GoToNigeria(Player player)
        {
            MessageBox.Show($"Avancez au Nigeria, {player.Name}!");
            // Ajoutez ici le code pour déplacer le joueur à la case Nigeria
        }

        public void RoadRepairs(Player player)
        {
            MessageBox.Show($"Vous êtes imposé pour les réparations de voirie. Payez 200 par maison et 400 par hôtel, {player.Name}!");
            // Ajoutez ici le code pour facturer les réparations de voirie au joueur en fonction du nombre de maisons et d'hôtels qu'il possède
        }

        public void GoToShortTrucks(Player player)
        {
            MessageBox.Show($"Avancez jusqu'à ShortTrucks, {player.Name}!");
            // Ajoutez ici le code pour déplacer le joueur à la case ShortTrucks
        }

        public void WinCrosswordPrize(Player player)
        {
            MessageBox.Show($"Vous avez gagné le prix de mots croisés. Recevez 400, {player.Name}!");
            player.Capital += 400;
            // Ajoutez ici le code pour effectuer d'autres opérations liées à la récompense du prix de mots croisés
        }

        public void BankDividend(Player player)
        {
            MessageBox.Show($"La banque vous verse un dividende de 350, {player.Name}!");
            player.Capital += 350;
            // Ajoutez ici le code pour effectuer d'autres opérations liées au versement du dividende par la banque
        }

        public void GoBackThreeSpaces(Player player)
        {
            MessageBox.Show($"Reculez de trois cases, {player.Name}!");

        }

        public void PayTuitionFee(Player player)
        {
            MessageBox.Show($"Payez pour frais de scolarité 150, {player.Name}!");
            player.Capital -= 150;
            
            // Ajoutez ici le code pour effectuer d'autres opérations liées au paiement des frais de scolarité
        }
    }
}
