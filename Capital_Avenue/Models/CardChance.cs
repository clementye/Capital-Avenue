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
                    StockSell(player);
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

        public void StockSell(Player player)
        {
            MessageBox.Show($"Recevez votre intérêt sur l’emprunt 160€,{player.Name}!");
            player.Capital += 160;
        }

        public void MoveToStart(Player player)
        {
            int startCase = 0;
            MessageBox.Show($"Vous avez été déplacé à la case départ. {player.Name}!");
            board.MovePawnToPosition(player, startCase);
        }

        public void GoToColombia(Player player)
        {
            int colombiaIndex = 24;
            MessageBox.Show($"Rendez-vous à Colombia. {player.Name}!");
            board.MovePawnToPosition(player, colombiaIndex);
        }

        public void GoToNigeria(Player player)
        {
            int nigeriaIndex = 11;
            MessageBox.Show($"Avancez au Nigeria. {player.Name}!");
            board.MovePawnToPosition(player, nigeriaIndex);
        }

        public void RoadRepairs(Player player)
        {
            MessageBox.Show($"Vous êtes imposé pour les réparations de voirie. Payez 100€ par maison et 200€ par hôtel, {player.Name}!");
        }

        public void GoToShortTrucks(Player player)
        {
            int shortTruckIndex = 35;
            MessageBox.Show($"Avancez jusqu'à ShortTrucks, {player.Name}!");
            board.MovePawnToPosition(player, shortTruckIndex);
        }

        public void WinCrosswordPrize(Player player)
        {
            MessageBox.Show($"Vous avez gagné le prix de mots croisés. Recevez 200€ {player.Name}!");
            player.Capital += 200;

        }

        public void BankDividend(Player player)
        {
            MessageBox.Show($"La banque vous verse un dividende de 250€ {player.Name}!");
            player.Capital += 250;
        }

        public void PayTuitionFee(Player player)
        {
            MessageBox.Show($"Payez pour frais de scolarité 150€ {player.Name}!");
            player.Capital -= 150;
                      
        }
    }
}
