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
        List<PictureBox> pictureBoxes;


        public Case()
        {
            flow = new FlowLayoutPanel();
            pictureBoxes = new();
        }


        public void AddPawn(Player player)
        {
            PictureBox picture = new PictureBox();
            flow.Controls.Add(picture);
            Image[] images = ConfigService.GetPlayerImages();
            picture.Image = images[player.Pawn];
            pictureBoxes.Add(picture);

            this.Controls.Add(flow);
        }

        public void RemovePawn(Player player)
        {
            Image[] images = ConfigService.GetPlayerImages();
            for (int i = 0; i < pictureBoxes.Count(); i++)
            {
                if (images[player.Pawn] == images[player.Pawn])

                {
                    flow.Controls.Clear();
                    pictureBoxes[i].Controls.Clear();
                    pictureBoxes.Remove(pictureBoxes[i]);
                    break;
                }
            }
        }
    }
}
