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
        private Player currentPlayer;

        public Carte(Models.Property p, Player player)
        {
            InitializeComponent();
            property = p;
            Nom_propiéte.Text = p.Name;
            Nom_propiéte.BackColor = p.color;
            pictureBox1.BackColor = p.color;
            label1.BackColor = p.color;
            price.Text = p.Price.ToString() + "€";
            PriceOneHouse.Text = p.PriceOneHome.ToString() + "€";
            PriceTowHouse.Text = p.PriceTwoHome.ToString() + "€";
            PriceThreeHouse.Text = p.PriceThreeHome.ToString() + "€";
            PriceFourHouse.Text = p.PriceFourHome.ToString() + "€";
            this.currentPlayer = player;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            currentPlayer.Capital -= property.Price;
            property.Owner = currentPlayer;
            currentPlayer.AddCard(property);
            ButtonQuitter.Enabled = true;
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
