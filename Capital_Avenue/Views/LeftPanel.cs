using Capital_Avenue.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capital_Avenue.Views
{

    using Models;
    using Capital_Avenue.Services;
    public class LeftPanel : UserControl
    {
        private List<Player> PlayerList;
        public LeftPanel(List<Player> playerList)
        {
            this.PlayerList = playerList;
            List<string> colors = ConfigService.GetPlayerColors();
            int basePosition = 100;
            int space = 25;
            for(int i = 0; i < playerList.Count; i++)
            {
                int pos = basePosition;
                if (i > 0) pos = basePosition * (i + 1) + space * i;

                this.AddPlayerUC(playerList[i], colors[i], pos);
            }
        }

        public void AddPlayerUC(Player player, string color, int position)
        {
            UserControl uc1 = new UserControl();
            Panel p1 = new Panel();
            Label l1 = new Label();
            Label l2 = new Label();
            Label l3 = new Label();
            //PictureBox picture = new PictureBox();
            l1.Text = player.Name;
            p1.Controls.Add(l1);
            l2.Text ="Cartes : " + player.Cards.Count.ToString();
            l2.Location = new Point(0, 30);
            p1.Controls.Add(l2);
            l3.Text ="M : " + player.Capital.ToString();
            l3.Location = new Point(0,60);
            p1.Controls.Add(l3);
           

            ///p1.Controls.Add(picture);
            p1.BackColor = ColorTranslator.FromHtml(color);
            p1.Size = new Size(200, 100);
            //picture.Size = new Size(300, 110);
            //picture.Location = new Point(30, (p1.Height - picture.Height) / 2);
            //picture.Image =images[player.Pawn];

            uc1.Location = new Point(0, position);
            uc1.Size = new Size(200, 100);
            uc1.Controls.Add(p1);
            this.Controls.Add(uc1);

        }

        public void UpdatePlayerUC(Player player)
        {
            foreach (UserControl uc in this.Controls)
            {
                if (uc.Controls[0] is Panel p)
                {
                    if (p.Controls[0].Text == player.Name)
                    {
                        // Update the player's labels
                        //p.Controls[1].Text = "Cartes : " + player.Cards.Count.ToString();
                        p.Controls[2].Text = "M : " + player.Capital.ToString();
                    }
                }
            }
        }
    }
}
