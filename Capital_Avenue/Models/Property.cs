using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Capital_Avenue.Models
{
    public class Property : Case
    {
    
        public ColorProperty Groupe { get; set; }
        public int Price { get; set; }
        public int Rent { get; set; }
        public Color color { get; }
        public int housesCount { get; set; }
        public int PriceOneHome { get; set; }
        public int PriceTwoHome { get; set; }
        public int PriceThreeHome { get; set; }
        public int PriceFourHome { get; set; }


        public Player Owner { get; set; }
      
        public Property(int index, string name, ColorProperty groupe, Color color, int prix, int loyer, int PriceOneHome, int PriceTwoHome, int PriceThreeHome,int PriceFourHome) : base(index, name)
        {
            this.Groupe = groupe;
            this.Name = name;
            this.Index = index;
            this.Price = prix;
            this.color = color;
            this.Rent = loyer;
            this.PriceOneHome = PriceOneHome;
            this.PriceTwoHome = PriceTwoHome;
            this.PriceThreeHome = PriceThreeHome;
            this.PriceFourHome = PriceFourHome;
            housesCount = 0;
            this.Owner = null;
        }
      
        public bool CheckPropietorship(Property propriety)
        {
            if (propriety.Owner != null)
            {
                return true;
            }
            return false;
        }
       
        public void TaxProperty(Player currentPlayer, Property propriety)
        {
           
            if (propriety.Owner.Name == currentPlayer.Name)
            {
                MessageBox.Show($"La propriété {propriety.Name} vous appartient.");
            }
            else
            {
                currentPlayer.Capital -= propriety.Rent;
                MessageBox.Show($"{currentPlayer.Name} a été prélevé de {propriety.Rent} euros.");
              propriety.Owner.Capital += propriety.Rent;
                MessageBox.Show($"{currentPlayer.Name} est sur une propriété achetée par {Owner.Name} et doit payer {propriety.Rent} euros de loyer.");
            }
        }
    }
}
