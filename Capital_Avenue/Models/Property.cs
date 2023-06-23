using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Capital_Avenue.Models
{
    public class Property : Case
    {
        public ColorProperty Groupe { get; set; }
        public int Price { get; set; }
        public int Rent { get; set; }
        private Dictionary<Player, string> PropertyBought = new Dictionary<Player, string>();

        public Property(int index, string name, ColorProperty groupe,Color color ,int prix, int loyer) : base(index, name)
        {
            this.Groupe = groupe;
            this.Name = name;
            this.Index = index;
            this.Price = prix;
            this.Rent= loyer;
        }

        public void BuyProperty(Player currentPlayer, Property property)
        {
            PropertyBought.Add(currentPlayer, property.Name);
            currentPlayer.Capital -= property.Price;
            MessageBox.Show($" La Propriété {property.Name}  vous appartient {currentPlayer.Name}");
            currentPlayer.OwnedProperties.Add(property);
        }
        public bool CheckPropietorship(Property propriety)
        {
            if (PropertyBought.ContainsValue(propriety.Name))
            {
                return true;
            }
            return false;
        }
        public void TaxProperty(Player currentPlayer, Property propriety)
        {
            Player owner = PropertyBought.FirstOrDefault(x => x.Value == propriety.Name).Key;
            if (owner.Name == currentPlayer.Name)
            {
                MessageBox.Show($" la propriété {propriety.Name} vous appartient");
            }
            else
            {
                currentPlayer.Capital -= propriety.Rent;
                MessageBox.Show($"{currentPlayer.Name} a été preléver {propriety.Rent}");
                owner.Capital += propriety.Rent;
                MessageBox.Show($"{currentPlayer.Name} est sur une propiéte achéte par {owner.Name} et doit payer {propriety.Rent} euros de loyer");
            }
        }
    }
}