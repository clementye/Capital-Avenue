namespace Capital_Avenue.Models
{
    public class Player
    {
        public string Name { get; set; }

        public int Pawn { get; set; }

        public int Capital { get; set; }
        public List<Property> OwnedProperties { get; set; }
        public List<string> Cards { get; private set; }
        public int TotalDouble { get; set; }

        public bool isBankrupt;
        public bool isInJail;

        public Player(string name, int pawn, int capital)
        {
            this.Name = name;
            this.Pawn = pawn;
            this.Capital = capital;
            OwnedProperties = new List<Property>();
            this.Cards = new List<string>();
            isBankrupt = false;
            this.TotalDouble = 0; //Will be displaced into board or monopoly
            isInJail = false;
        }
    }
}
