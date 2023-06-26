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
            int action = random.Next(0, 8);
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
        public void ErrorMessage(Image image, string Message)
        {
            Card c = new Card(image, Message, "Carte Caumunauté");
            c.ShowDialog();
        }
        public void ReceiveAnnualIncome(Player player)
        {

            string Message = $"Recevez votre revenu\n annuel de 150€\n{player.Name}!";
            this.ErrorMessage(Properties.Resources.Emojy, Message);
            player.Capital += 150;

        }
       

        public void BirthdayGift(Player player)
        {
            MessageBox.Show($"C'est votre anniversaire!\n Chaque joueur doit vous\n donner 100€ {player.Name}!");
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


          
            string Message = $"Les contributions vous\n remboursent la somme\n de 200€ {player.Name}!";
            this.ErrorMessage(Properties.Resources.Emojy, Message);
            player.Capital += 200;
            // Ajoutez ici le code pour effectuer d'autres opérations liées au remboursement des contributions
        }
        public void ReceiveLoanInterest(Player player)
        {

            string Message = $"Recevez votre intérêt \n sur l'emprunt à 250€\n{player.Name}!";
            this.ErrorMessage(Properties.Resources.Emojy, Message);
            player.Capital += 250;
           
            // Ajoutez ici le code pour effectuer d'autres opérations liées à la réception de l'intérêt sur l'emprunt
        }
        public void PayInsurancePremium(Player player)
        {
            string Message =$"Payez votre \nPolice d'Assurance\n à 120€ {player.Name}!";
            this.ErrorMessage(Properties.Resources.Emojy2, Message);
            player.Capital -= 120;
            // Ajoutez ici le code pour effectuer d'autres opérations liées au paiement de la police d'assurance
        }

        public void PayFine(Player player)
        {
          
            string Message =$"Payez une amende \n de 180€ \n{player.Name}!";
            this.ErrorMessage(Properties.Resources.Emojy2, Message);
            player.Capital -= 180;
            // Ajoutez ici le code pour effectuer d'autres opérations liées au paiement de l'amende
        }
        public void GoBackThreeCase(Player player)
        {
            string Message = $"Reculez de trois \n cases, {player.Name}!";
            this.ErrorMessage(Properties.Resources.Enjoy3, Message);
            board.MovePawn(player, -3);
        }
        public void BeautyContestSecondPrize(Player player)
        {
            string Message = $"Vous avez remporté \nle deuxième prix de beauté\n ! Recevez 270€ {player.Name}!";
            this.ErrorMessage(Properties.Resources.Emojy, Message);
            player.Capital += 270;
        }

        public void Inheritance(Player player)
        {
            string Message = $"Vous héritez de 270€\n, {player.Name}!";
            this.ErrorMessage(Properties.Resources.Emojy, Message); 
            player.Capital += 270;
        }
    }
}
