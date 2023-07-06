using Capital_Avenue.Models;
using System.Data;
using System.Text;
using System.Configuration;
using Capital_Avenue.Services;
using System.Drawing;

namespace Capital_Avenue.Views.Auction
{

    public partial class OtherPlayerChoice : Form
    {
        private Player CurrentPlayer;
        private Player OtherPlayer;
        private List<Player> PlayerList;
        private int P1Color;

        public void OPABox(Player player, List<Player> playerList)
        {
            InitializeComponent();
            CurrentPlayer = player;
            PlayerList = playerList;
            Header.Text = player.Name + ", faire l'échange avec qui ?";
            int OGSize = 0;
            List<string> colors = ConfigService.GetPlayerColors();
            for (int i = 0; i < PlayerList.Count; i++)
            {
                if (PlayerList[i] != player)
                {
                    Button BP1 = new Button();
                    BP1.Location = new Point(10 + OGSize, 107);
                    BP1.BackColor = ColorTranslator.FromHtml(colors[i]);
                    BP1.Name = PlayerList[i].Name;
                    BP1.Text = PlayerList[i].Name;
                    BP1.TabIndex = i;
                    BP1.Click += BP1_Click;
                    BP1.Size = new Size(100, 50);
                    this.Controls.Add(BP1);
                    OGSize += 100;
                }
                else
                {
                    P1Color = i;
                }
            }
        }
        public void BP1_Click(object sender, EventArgs e)
        {
            string s = (sender as Button).Text;
            int i = (sender as Button).TabIndex;
            OtherPlayer = PlayerList.Where(pl1 => pl1.Name == s).FirstOrDefault();
            Auction AuctionShow = new Auction(CurrentPlayer, OtherPlayer, i, P1Color);
            AuctionShow.ShowDialog();
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
