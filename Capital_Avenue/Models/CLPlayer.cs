namespace Capital_Avenue.Models
{
    public class CLPlayer
    {
        public string Name { get; set; }

        public string Pawn { get; set; }

        public int Capital { get; set; }

<<<<<<< HEAD
        List<string> OwnedProperties { get; set; }

        public List<string> Cards { get; private set; }

        public CLPlayer(string name, string pawn, int capital)
=======

        /*List<String> OwnedProperties;

        List<String> Cards;*/

        public CLPlayer(string name, string pawn, int capital) 
>>>>>>> f38c7195e728e5200a61581d6e8c1ffd3477df8e
        {
            this.Name = name;
            this.Pawn = pawn;
            this.Capital = capital;
            this.OwnedProperties = new List<string>();
            this.Cards = new List<string>();
        }

<<<<<<< HEAD
        public void AddCards(string Card)
        {
            Cards.Add(Card);
        }
       



=======
        /*public void addPlayer(string name, string pawn, int capital)
        {
            Name = name;
            Pawn = pawn;
            Capital = capital;
        }*/
>>>>>>> f38c7195e728e5200a61581d6e8c1ffd3477df8e
    }
}
