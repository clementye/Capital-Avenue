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

        public Case()
        {
            flow = new FlowLayoutPanel();

        }

        public void AddPawn(Player player)
        {
            PictureBox picture = new PictureBox();
            flow.Controls.Add(picture);
            Image[] images = ConfigService.GetPlayerImages();
            picture.Image = images[player.Pawn];
            this.Controls.Add(flow);
        }

        public void RemovePawn(Player player)
        {
            Image[] images = ConfigService.GetPlayerImages();
            PictureBox pictureBoxToRemove = flow.Controls.OfType<PictureBox>().FirstOrDefault(p => p.Image == images[player.Pawn]);
            if (pictureBoxToRemove != null)
            {
                flow.Controls.Remove(pictureBoxToRemove);
                pictureBoxToRemove.Dispose();
            }
        }
    }
}
