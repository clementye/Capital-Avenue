using Capital_Avenue.Views.Board;
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
        private Board board;

        public CardChance(Board board)
        {
            this.board = board;
        }
        public int GetRandomChanceCardAction()
        {
            Random random = new Random();
            int action = random.Next(0, 9); // Génère un nombre aléatoire entre 0 et 9
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
                    MoveToStart(player);
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
        }

        public void MoveToStart(Player player)
        {
            MessageBox.Show($"Vous avez été déplacé à la case départ, {player.Name}!");
            board.MovePawn(player, 0);
        }

        public void GoToColombia(Player player)
        {
            MessageBox.Show($"Rendez-vous à Colombia, {player.Name}!");
            board.MovePawn(player, 24);
        }

        public void GoToNigeria(Player player)
        {
            MessageBox.Show($"Avancez au Nigeria, {player.Name}!");
            board.MovePawn(player, 11);
        }

        public void RoadRepairs(Player player)
        {
            MessageBox.Show($"Vous êtes imposé pour les réparations de voirie. Payez 200 par maison et 400 par hôtel, {player.Name}!");
        }

        public void GoToShortTrucks(Player player)
        {
            MessageBox.Show($"Avancez jusqu'à ShortTrucks, {player.Name}!");
            board.MovePawn(player, 35);
        }

        public void WinCrosswordPrize(Player player)
        {
            MessageBox.Show($"Vous avez gagné le prix de mots croisés. Recevez 400, {player.Name}!");
            player.Capital += 400;

        }

        public void BankDividend(Player player)
        {
            MessageBox.Show($"La banque vous verse un dividende de 350, {player.Name}!");
            player.Capital += 350;
        }

        public void PayTuitionFee(Player player)
        {
            MessageBox.Show($"Payez pour frais de scolarité 150, {player.Name}!");
            player.Capital -= 150;
                      
        }
    }
}
