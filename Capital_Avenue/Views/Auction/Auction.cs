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

namespace Capital_Avenue.Views.Auction
{
    public partial class Auction : Form
    {
        public Auction(Player Cplayer, Player Oplayer)
        {
            InitializeComponent();
            button1.Text = Cplayer.Name;
            button2.Text = Oplayer.Name;
            OptionChoice.Items.Add("Propriété");
            OptionChoice.Items.Add("Carte");
            OptionChoice.SelectedIndex = 0;
            this.CheckBoxGenerator(OptionChoice.SelectedText);
        }

        public void CheckBoxGenerator(string Choice)
        {
            switch (Choice)
            {
                case "Propriété":

                    break;
                case "Carte":
                    break;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // TODO :
        // Update when changing Player
        // Update the CheckedListBox when changing, while not loosing the choice.
        // Doing the action of transfering properties and/or cards
        // 
    }

}
