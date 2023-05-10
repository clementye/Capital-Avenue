using Capital_Avenue.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capital_Avenue.Views
{

    using Models;
    using Controllers;
    public class LeftUCPanel : UserControl
    {
        private int toto;
        private string hexPlay1 = "#6AFF2D";
        private string hexPlay2 = "#401ad6";
        private List<CLPlayer> PlayerList;
        public LeftUCPanel(List<CLPlayer> playerList)
        {
            this.PlayerList = playerList;
            List<string> colors = new List<string> {
                "#6AFF2D",
                "#401ad6"
            };
            int basePosition = 100;
            int space = 25;
            for(int i = 0; i < playerList.Count; i++)
            {
                int pos = basePosition;
                if (i > 0) pos = basePosition * (i + 1) + space * i;

                this.AddPlayerUC(playerList[i], colors[i], pos);
            }
        }

        public void AddPlayerUC(CLPlayer player, string color, int position)
        {
            UserControl uc1 = new UserControl();
            Panel p1 = new Panel();
            Label l1 = new Label();
<<<<<<< HEAD
            l1.Text = player.Name;
            p1.Controls.Add(l1);
            p1.BackColor = ColorTranslator.FromHtml(color);
            p1.Size = new Size(300, 120);
            uc1.Controls.Add(p1);
            uc1.Location = new Point(0, position);
            uc1.Size = new Size(1570, 120);
            this.Controls.Add(uc1);
=======
            l1.Text = CLPlayer.Fake1;
            p1.Controls.Add(l1);
            p1.BackColor = ColorTranslator.FromHtml(hexPlay1);
            p1.Size = new Size(500, 120);
            uc1.Controls.Add(p1);
            uc1.Location = new Point(0, 50);
            uc1.Size = new Size(1570, 120);
            this.Controls.Add(uc1);




            UserControl uc2 = new UserControl();
            Panel p2 = new Panel();
            Label l2 = new Label();
            l2.Text = "Joueur 2";
            p2.Controls.Add(l2);
            p2.BackColor = ColorTranslator.FromHtml(hexPlay2);
            p2.Size = new Size(500, 120);
            uc2.Controls.Add(p2);
            uc2.Location = new Point(0, 225);
            uc2.Size = new Size(1570, 120);
            this.Controls.Add(uc2);

        }
        public int getToto()
        {
            return toto;
>>>>>>> f38c7195e728e5200a61581d6e8c1ffd3477df8e
        }
        

        public void UpdateValues()
        {

        }
    }
}
