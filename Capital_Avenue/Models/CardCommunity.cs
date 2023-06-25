using Capital_Avenue.Views.Board;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capital_Avenue.Models
{
    public class CardCommunity
    {
        private Board board;
        
        public CardCommunity(Board board)
        {
            this.board = board;
           
        }
        public int GetRandomCommunityCardAction()
        {
            Random random = new Random();
            int action = random.Next(0, 9);
            return action;
        }
        public void ExecuteCommunityCardAction(Player player)
        {
            int action = GetRandomCommunityCardAction();

            switch (action)
            {
                case 0:
                    ReceiveAnnualIncome(player);
                    break;
                case 1:
                    BirthdayGift(player);
                    break;
                case 2:
                    RefundContributions(player);
                    break;
                case 3:
                    ReceiveLoanInterest(player);
                    break;
                case 4:
                    PayInsurancePremium(player);
                    break;
                case 5:
                    PayFine(player);
                    break;
                case 6:
                    GoBackThreeCase(player);
                    break;
                case 7:
                    BeautyContestSecondPrize(player);
                    break;
                case 8:
                    Inheritance(player);
                    break;
                default:
                    break;
            }
        }
        public void ReceiveAnnualIncome(Player player)
        {
            MessageBox.Show($"Recevez votre revenu annuel de 150€ {player.Name}!");
            player.Capital += 150;
        }

        public void BirthdayGift(Player player)
        {
            MessageBox.Show($"C'est votre anniversaire ! Chaque joueur doit vous donner 100€ {player.Name}!");
            /*
            foreach (Player otherPlayer in pList)
            {
                if (otherPlayer != player)
                {
                    otherPlayer.Capital -= 100; // Retirez 100 au joueur actuel
                    player.Capital += 100; // Ajoutez 100 au joueur célébrant son anniversaire
                }
            }*/
        }

        public void RefundContributions(Player player)
        {
            MessageBox.Show($"Les contributions vous remboursent la somme de 200€ {player.Name}!");
            player.Capital += 200;
            // Ajoutez ici le code pour effectuer d'autres opérations liées au remboursement des contributions
        }
        public void ReceiveLoanInterest(Player player)
        {
            MessageBox.Show($"Recevez votre intérêt sur l'emprunt à 250€ {player.Name}!");
            player.Capital += 250;
            // Ajoutez ici le code pour effectuer d'autres opérations liées à la réception de l'intérêt sur l'emprunt
        }
        public void PayInsurancePremium(Player player)
        {
            MessageBox.Show($"Payez votre Police d'Assurance à 120€ {player.Name}!");
            player.Capital -= 120;
            // Ajoutez ici le code pour effectuer d'autres opérations liées au paiement de la police d'assurance
        }

        public void PayFine(Player player)
        {
            MessageBox.Show($"Payez une amende de 180€ {player.Name}!");
            player.Capital -= 180;
            // Ajoutez ici le code pour effectuer d'autres opérations liées au paiement de l'amende
        }
        public void GoBackThreeCase(Player player)
        {
            MessageBox.Show($"Reculez de trois cases, {player.Name}!");

            board.MovePawn(player, -3);
        }
        public void BeautyContestSecondPrize(Player player)
        {
            MessageBox.Show($"Vous avez remporté le deuxième prix de beauté ! Recevez 270€ {player.Name}!");
            player.Capital += 270;
        }

        public void Inheritance(Player player)
        {
            MessageBox.Show($"Vous héritez de 270€, {player.Name}!");
            player.Capital += 270;
        }
    }
}
