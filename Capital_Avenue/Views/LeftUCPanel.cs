using Capital_Avenue.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capital_Avenue.Views
{
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
            l1.Text = player.Name;
            p1.Controls.Add(l1);
            p1.BackColor = ColorTranslator.FromHtml(color);
            p1.Size = new Size(300, 120);
            uc1.Controls.Add(p1);
            uc1.Location = new Point(0, position);
            uc1.Size = new Size(1570, 120);
            this.Controls.Add(uc1);
        }
        

        public void UpdateValues()
        {

        }
    }
}
