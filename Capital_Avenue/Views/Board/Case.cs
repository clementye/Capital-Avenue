using Capital_Avenue.Models;
using Capital_Avenue.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capital_Avenue.Views.Board
{
    public abstract class Case : UserControl
    {
        FlowLayoutPanel flow;
        private Dictionary<Player, PictureBox> pictureBoxes;

        public Case()
        {
            flow = new FlowLayoutPanel();
            this.Controls.Add(flow);

            pictureBoxes = new Dictionary<Player, PictureBox>();
        }


        public void AddPawn(Player player)
        {
            PictureBox picture = new PictureBox();
            flow.Controls.Add(picture);
            Image[] images = ConfigService.GetPlayerImages();
            picture.Image = images[player.Pawn];
            pictureBoxes[player] = picture;

        }

        public void RemovePawn(Player player)
        {
            if (pictureBoxes.ContainsKey(player))
                flow.Controls.Remove(pictureBoxes[player]);
        }
    }
}
