namespace Capital_Avenue.Models
{
    public class Player
    {
        public string Name { get; set; }

        public int Pawn { get; set; }

        public int Capital { get; set; }
        List<string> OwnedProperties { get; set; }

        public List<string> Cards { get; private set; }
        public bool isBankrupt;

        public Player(string name, int pawn, int capital)
        {
            this.Name = name;
            this.Pawn = pawn;
            this.Capital = capital;
            this.OwnedProperties = new List<string>();
            this.Cards = new List<string>();
            isBankrupt = false;
        }
        public void AddCards(string Card)
        {
            Cards.Add(Card);
        }
    }
}
