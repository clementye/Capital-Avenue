using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capital_Avenue.Services;
using Capital_Avenue.Models;

namespace Capital_Avenue.Views.Board
{
    public partial class ProOwned : UserControl
    {
        List<string> colors = ConfigService.GetPlayerColors();
        private int Index;

        public ProOwned(int index)
        {
            InitializeComponent();
            this.Size = new Size(31, 31);
            this.BackColor = Color.Transparent;
            Index = index;
        }

        public void UpdateShow(Player player, Property propertie, List<Player> Plist)
        {
            if (propertie.Owner.Name != null && propertie.Index == this.Index)
            {
                for (int i = 0; i<Plist.Count; i++)
                {
                    if (propertie.Owner.Name == Plist[i].Name) // Need to check if right properties.
                    {
                        Label House = new Label();
                        House.Text = propertie.housesCount.ToString();
                        this.BackColor = ColorTranslator.FromHtml(colors[i]);
                        this.Controls.Add(House);
                    }
                }
            }
            else if (propertie.Owner.Name == null)
            {

                Control[] existingLabel = this.Controls.Find("House", true);
                foreach (var label in existingLabel)
                {
                    this.Controls.Remove(label);
                    label.Dispose();
                }
                this.BackColor = Color.Transparent;
            }
            
        }
    }

    
}
