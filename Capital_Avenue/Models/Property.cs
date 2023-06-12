using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Capital_Avenue.Models
{
    public class Propriety : Case
    {
        public PGroupe PGroupe { get; set; }
        public int Prix { get; set; }
        public int Loyer { get; set; }
        private Dictionary<Player, string> PropertyBy = new Dictionary<Player, string>();

        public Propriety(int index, string name, PGroupe groupe, int prix, int loyer) : base(index, name)
        {
            this.PGroupe = groupe;
            this.Name = name;
            this.Index = index;
            this.Prix = prix;
            this.Loyer = loyer;
        }

        public void ValiderProperty(Player currentPlayer, Propriety propriety)
        {
            PropertyBy.Add(currentPlayer, propriety.Name);
            currentPlayer.Capital -= propriety.Prix;
            MessageBox.Show($" La Propriété {propriety.Name}  vous appartient {currentPlayer.Name}");
            currentPlayer.OwnedProperties.Add(propriety);
        }
        public bool VerificationProperty(Propriety propriety)
        {
            if (PropertyBy.ContainsValue(propriety.Name))
            {
                return true;
            }
            return false;
        }
        public void TaxProperty(Player currentPlayer, Propriety propriety)
        {
            Player owner = PropertyBy.FirstOrDefault(x => x.Value == propriety.Name).Key;
            if (owner.Name == currentPlayer.Name)
            {
                MessageBox.Show($" la propriété {propriety.Name} vous appartient");
            }
            else
            {
                currentPlayer.Capital -= propriety.Loyer;
                MessageBox.Show($"{currentPlayer.Name} a été preléver {propriety.Loyer}");
                owner.Capital += propriety.Loyer;
                MessageBox.Show($"{currentPlayer.Name} est sur une propiéte achéte par {owner.Name} et doit payer {propriety.Loyer} euros de loyer");
            }
        }
    }
}