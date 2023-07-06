using Capital_Avenue.Models;
using System.Data;

namespace Capital_Avenue.Views.Auction
{
    public partial class OtherPlayerChoice : Form
    {
        private Player CurrentPlayer;
        private Player OtherPlayer;
        private List<Player> PlayerList;


        public void OPABox(Player player, List<Player> playerList)
        {
            InitializeComponent();
            CurrentPlayer = player;
            PlayerList = playerList;
            Header.Text = player.Name + ", faire les enchères avec qui ?";
            int OGSize = 0;
            for (int i = 0; i < PlayerList.Count; i++)
            {
                if (PlayerList[i] != player)
                {
                    Button BP1 = new Button();
                    BP1.Location = new Point(10 + OGSize, 107);
                    BP1.Name = PlayerList[i].Name;
                    BP1.Text = PlayerList[i].Name;
                    BP1.Click += BP1_Click;
                    this.Controls.Add(BP1);
                    OGSize += 100;
                }
            }
        }
        public void BP1_Click(object sender, EventArgs e)
        {
            string s = (sender as Button).Text;
            OtherPlayer = PlayerList.Where(pl1 => pl1.Name == s).FirstOrDefault();
            Auction AuctionShow = new Auction(CurrentPlayer, OtherPlayer);
            AuctionShow.ShowDialog();
            this.Close();
        }
    }
}
