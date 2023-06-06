namespace Capital_Avenue.Models
{
    public class Player
    {
        public string Name { get; set; }

        public int Pawn { get; set; }

        public int Capital { get; set; }
        //List<string> OwnedProperties { get; set; }
        public List<Propriety> OwnedProperties { get; set; }


        public List<string> Cards { get; private set; }
        public bool isBankrupt;

        public int Money { get; set; }


        public Player(string name, int pawn, int capital)
        {
            this.Name = name;
            this.Pawn = pawn;
            this.Capital = capital;
            //this.OwnedProperties = new List<string>();
            OwnedProperties = new List<Propriety>();

            this.Cards = new List<string>();
            isBankrupt = false;
        }
        public void AddCards(string Card)
        {
            Cards.Add(Card);
        }
        public void DeductMoney(int amount)
        {
            Money -= amount;
        }
        public void AddMoney(int  amount)
        {
            Money += amount;
        }
        public void AddProperty(Propriety property)
        {
            OwnedProperties.Add(property);
        }
    }
}
