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
        public Color color { get; }
        public int housesCount { get; set; }
        public int PriceOneHome { get; set; }
        public int PriceTwoHome { get; set; }
        public int PriceThreeHome { get; set; }
        public int PriceFourHome { get; set; }
        public int PriceHostel { get; set; }
        public bool IsInBank;

        public Player Owner { get; set; }
      
        public Property(int index, string name, ColorProperty groupe, Color color, int prix, int loyer, int PriceOneHome, int PriceTwoHome, int PriceThreeHome,int PriceFourHome, int PriceHostel) : base(index, name)
        {
            this.Groupe = groupe;
            this.Name = name;
            this.Index = index;
            this.Price = prix;
            this.color = color;
            this.Rent= loyer;
            this.PriceOneHome = PriceOneHome;
            this.PriceTwoHome = PriceTwoHome;
            this.PriceThreeHome = PriceThreeHome;
            this.PriceFourHome = PriceFourHome;
            this.PriceHostel = PriceHostel;
            housesCount = 0;
            this.Owner = null;
            this.IsInBank = false;
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

            if (propriety.Owner.Name != currentPlayer.Name && propriety.IsInBank == false)
            {
                currentPlayer.Capital -= propriety.Rent;
                MessageBox.Show($"{currentPlayer.Name} a été prélevé de {propriety.Rent}€.");
                propriety.Owner.Capital += propriety.Rent;
                MessageBox.Show($"{currentPlayer.Name} est sur une propriété achetée par {Owner.Name} et doit payer {propriety.Rent}€ de loyer.");
            }
            else if(propriety.Owner.Name == currentPlayer.Name && propriety.IsInBank == true)
            {
                string message = $"Souhaitez-vous racheter cette propriété ?";
                DialogResult result = MessageBox.Show(message, " Sortir de Prison ",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    currentPlayer.Capital -= (propriety.Price * 110)/100;
                }
            }
        }
    }
}