using Capital_Avenue.Models;

namespace Capital_Avenue
{
    public partial class PropertyCard : Form
    {
        private Models.Property property;
        private Player currentPlayer;

        public PropertyCard(Models.Property p, Player player)
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
            // Switch that check if brought.
            // If yes, then question if want to buy a house instead of want to buy property
            currentPlayer.Capital -= property.Price;
            property.Owner = currentPlayer;
            currentPlayer.AddProperty(property); // <- AddCar is for Community Card and Chance Card.
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Switch 
            this.Close();
        }
    }
}
