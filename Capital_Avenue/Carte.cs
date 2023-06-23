using Capital_Avenue.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capital_Avenue
{
    public partial class Carte : Form
    {
        private Models.Property property;
        private Game currentGame;
        public Carte(Models.Property p)
        {
            InitializeComponent();
            property = p;
            Nom_propiéte.Text = p.Name;
            Nom_propiéte.BackColor = p.color;
            pictureBox1.BackColor = p.color;
            label1.BackColor = p.color;
            price.Text = p.Price.ToString() + "€";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int currentPlayerIndex = currentGame.CurrentPlayer;
            Player currentPlayer = currentGame.PlayerList[currentPlayerIndex];
            //property.BuyProperty(, p)
            // Does it fetch PlayerList[CurrentPlayer]?
            // If not, how can it fetch it?
            //this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
