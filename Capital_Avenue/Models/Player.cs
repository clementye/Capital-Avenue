namespace Capital_Avenue.Models
{
    public class Player
    {
        public string Name { get; set; }

        public int Pawn { get; set; }

        public int Capital { get; set; }

        public List<Propriety> OwnedProperties { get; set; }
        public List<string> Cards { get; private set; }
        public int TotalDouble { get; set; }

        public bool isBankrupt;

        public Player(string name, int pawn, int capital)
        {
            this.Name = name;
            this.Pawn = pawn;
            this.Capital = capital;
 
            OwnedProperties = new List<Propriety>();

            this.Cards = new List<string>();
            isBankrupt = false;
            this.TotalDouble = 0; //Will be displaced into board or monopoly
        }
        public void AddCards(string Card)
        {
            Cards.Add(Card);
        }
        public void DeductMoney(int amount)
        {
            Capital -= amount;
        }
        public void AddMoney(int  amount)
        {
            Capital += amount;
        }
        public void AddProperty(Propriety property)
        {
            OwnedProperties.Add(property);
        }
    }
}
