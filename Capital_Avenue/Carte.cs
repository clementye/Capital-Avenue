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
        public Carte(Models.Property p)
        {
            InitializeComponent();
            property = p;
            Nom_propiéte.Text = p.Name;
            Nom_propiéte.BackColor = Color.Orange;
            pictureBox1.BackColor = Color.Orange;
            label1.BackColor = Color.Orange;
            price.Text = p.Price.ToString() + "€";
        }

        private void button1_Click(object sender, EventArgs e)
        {
           //property.BuyProperty(Player p,)
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
