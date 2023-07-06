using Capital_Avenue.Views.Board;

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
            Task.Delay(500).Wait();
            Task.Delay(500).Wait();
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
        public void ErrorMessage(Image image, string Message)
        {
            Card c = new Card(image, Message, "Chance");
            c.ShowDialog();
        }

        public void StockSell(Player player)
        {
           
            string Message = $"Recevez votre intérêt\n sur l’emprunt 160€,{player.Name}!";
            this.ErrorMessage(Properties.Resources.Emojy, Message);
            player.Capital += 160;
        }

        public void MoveToStart(Player player)
        {
            int startCase = 0;
            string Message = $"Vous avez été déplacé \nà la case départ. {player.Name}!";
            this.ErrorMessage(Properties.Resources.Enjoy3, Message);
            board.MovePawnToPosition(player, startCase);
        }

        public void GoToColombia(Player player)
        {
            int colombiaIndex = 24;
            string Message =$"Rendez-vous à Colombia\n. {player.Name}!";
            this.ErrorMessage(Properties.Resources.Enjoy3, Message);
            board.MovePawnToPosition(player, colombiaIndex);
        }

        public void GoToNigeria(Player player)
        {
            int nigeriaIndex = 11;
            string Message =$"Avancez au Nigeria\n. {player.Name}!";
            this.ErrorMessage(Properties.Resources.Enjoy3, Message);
            board.MovePawnToPosition(player, nigeriaIndex);
        }

        public void RoadRepairs(Player player)
        {
            string Message = $"Vous êtes imposé \n pour les réparations\n de voirie. \nPayez 100€ par maison \n et 200€ par hôtel, {player.Name}!";
            this.ErrorMessage(Properties.Resources.Emojy, Message);
        }

        public void GoToShortTrucks(Player player)
        {
            int shortTruckIndex = 35;
            string Message =$"Avancez jusqu'à ShortTrucks\n, {player.Name}!";
            this.ErrorMessage(Properties.Resources.Enjoy3, Message);
            board.MovePawnToPosition(player, shortTruckIndex);
        }

        public void WinCrosswordPrize(Player player)
        {
            string Message =$"Vous avez gagné le prix de mots \ncroisés. Recevez 200€ {player.Name}!";
            this.ErrorMessage(Properties.Resources.Emojy, Message);
            player.Capital += 200;

        }

        public void BankDividend(Player player)
        {
            string Message = $"La banque vous verse \n un dividende de 250€\n {player.Name}!";
            this.ErrorMessage(Properties.Resources.Emojy, Message);
            player.Capital += 250;
        }

        public void PayTuitionFee(Player player)
        {
            string Message=$"Payez pour frais \n de scolarité 150€ {player.Name}!";
            this.ErrorMessage(Properties.Resources.Emojy2, Message);
            player.Capital -= 150;
                      
        }
    }
}
