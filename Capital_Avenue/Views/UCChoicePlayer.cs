using Capital_Avenue.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capital_Avenue.Views
{
    public partial class UCChoicePlayer : UserControl
    {
        public UCChoicePlayer()
        {
            InitializeComponent();
            for (int i = 1; i <= 6; i++)
            {
                this.NumberPlayer.Items.Add(i);
            }
        }

        private void Valider_Click(object sender, EventArgs e)
        {
            if (this.NumberPlayer.SelectedItem == null)
            {

                MessageBox.Show("Choisir un nombre");
            }
            else
            {
                Program.PageHome.NextPage(new UCEnterPlayer(int.Parse(this.NumberPlayer.SelectedItem.ToString())));
                // System.Diagnostics.Debug.WriteLine(this.NumberPlayer.SelectedItem);
            }

        }
    }
}
