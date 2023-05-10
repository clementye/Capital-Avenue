namespace Capital_Avenue.Models
{
    public class CLPlayer
    {
        public string Name { get; set; }

        public string Pawn { get; set; }

        public int Capital { get; set; }

        List<string> OwnedProperties { get; set; }

        public List<string> Cards { get; private set; }

        public CLPlayer(string name, string pawn, int capital)
        {
            this.Name = name;
            this.Pawn = pawn;
            this.Capital = capital;
            this.OwnedProperties = new List<string>();
            this.Cards = new List<string>();
        }

        public void AddCards(string Card)
        {
            Cards.Add(Card);
        }
       



    }
}
