using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capital_Avenue.Models
{
    public class CLPlayer
    {
        public string Name { get; set; }

        public string Pawn { get; set; }

        public int Capital { get; set; }


        /*List<String> OwnedProperties;

        List<String> Cards;*/

        public CLPlayer(string name, string pawn, int capital) 
        {
            Name = name;
            Pawn = pawn;
            Capital = capital;
        }

        /*public void addPlayer(string name, string pawn, int capital)
        {
            Name = name;
            Pawn = pawn;
            Capital = capital;
        }*/
    }
}
